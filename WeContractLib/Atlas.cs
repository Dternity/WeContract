using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WeContractLib.Diagnostics;
using WeContractLib.Storage;
using Logger = WeContractLib.Diagnostics.Logger;

namespace WeContractLib
{
    public abstract class Atlas<T> where T : IThing
    {
        internal List<T> _listIThings;
        internal Dictionary<Guid, T> _dictIThings;
        internal string _TName = "IThing";
        internal int _indexCounter = 0;
        private bool _disposed = false;

        public Atlas()
        {
            _listIThings = new List<T>();
            _dictIThings = new Dictionary<Guid, T>();
        }

        public Atlas(string name) : this()
        {
            _TName = name;
        }

        public virtual bool Add(T entity)
        {
            if (Exist(entity.CID))
            {
                Log.Error($"{_TName} with CID: {entity.CID} already exist in {_TName}Manager!");
                return false;
            }

            entity.ID = _indexCounter;
            _indexCounter++;

            _listIThings.Add(entity);
            _dictIThings.Add(entity.CID, entity);
            Log.Info($"{_TName} with CID: {entity.CID} added to {_TName}Manager.");

            return true;
        }

        public virtual bool Remove(Guid cid)
        {
            if (Exist(cid))
            {
                return false;
            }

            _listIThings.RemoveAll(x => x.CID == cid);
            _dictIThings.Remove(cid);

            return true;
        }

        public void Dispose()
        {
            Log.Info($@"Disposing {_TName}");
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // TODO: dispose managed state (managed objects).
            }

            // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
            // TODO: set large fields to null.

            _disposed = true;
        }

        #region DB

        public virtual bool AddToDb(T entity)
        {
            if(AddToDbPreCheck(entity) == false)
            {
                return false;
            }

            using var db = new LiteDatabase(DBO.DbName);

            var col = db.GetCollection<T>(_TName);

            if (col.Exists(x => x.CID == entity.CID))
            {
                Log.Error($"{_TName} with CID: {entity.CID} already exist!", MethodBase.GetCurrentMethod());
                return false;
            }

            var res = col.Insert(entity);
            var suc = col.EnsureIndex(x => x.CID) && AddToDbAfterInserted(col, entity);

            Log.Debug($@"Added {_TName} with name:{entity.CID} doc id:{res}");
            return suc;
        }

        protected abstract bool AddToDbPreCheck(T entity);
        protected abstract bool AddToDbAfterInserted(LiteCollection<T> col, T entity);


        public virtual T Get(Query query)
        {
            using var db = new LiteDatabase(DBO.DbName);

            var col = db.GetCollection<T>(_TName);

            return col.FindOne(query);
        }


        public virtual void Initialize()
        {
            using var db = new LiteDatabase(DBO.DbName);
            if (db.CollectionExists(_TName))
            {
                _listIThings = new List<T>(db.GetCollection<T>(_TName).FindAll());
                foreach (var entity in _listIThings)
                {
                    _dictIThings.Add(entity.CID, entity);
                }
                _indexCounter = _listIThings.Count;
                Log.Debug($@"Loaded: {_indexCounter} {_TName}");

                return;
            }

            Log.Error($"The collection '{_TName}' does not exist Type: {typeof(T)}",
                MethodBase.GetCurrentMethod());
        }
        #endregion

        public virtual bool Remove(T entity)
        {
            return Remove(entity.CID);
        }

        public T Get(Guid cid)
        {
            return (T)_listIThings.First(x => x.CID == cid);
        }

        public T Get(string name)
        {
            return _listIThings.FirstOrDefault(x => x.Name == name);
        }

        public bool Exist(Guid cid)
        {
            return _listIThings.Exists(x => x.CID == cid);
        }

        public int FindIndex(Guid cid)
        {
            return _listIThings.FindIndex(x => x.CID == cid);
        }

        public List<T> GetWithinCreatedDate(DateTime min, DateTime max)
        {
            return _listIThings.FindAll(x => x.DateCreated.Ticks > min.Ticks && x.DateCreated.Ticks < max.Ticks);
        }

        public IList<T> GetList()
        {
            return _listIThings;
        }

        public int GetNextIndexCounter()
        {
            var index = _indexCounter;
            _indexCounter++;
            return index;
        }

        public string GetTName()
        {
            return _TName;
        }

        public void ListItems()
        {
            for (int i = 0; i < _listIThings.Count; i++)
            {
                var entity = _listIThings[i];
                Log.Info(entity.ToString());
            }
        }
    }
}
