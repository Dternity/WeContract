using System;
using System.Collections.Generic;
using System.Linq;
using WeContractLib.Diagnostics;

namespace WeContractLib
{
    public class Atlas<T> where T : IThing
    {
        internal List<T> _listIThings;
        internal Dictionary<Guid, T> _dictIThings;
        internal string _TName = "IThing";
        internal int _indexCounter = 0;
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
                Logger.Inst.Error($"{_TName} with CID: {entity.CID} already exist in {_TName}Manager!");
                return false;
            }

            entity.ID = _indexCounter;
            _indexCounter++;

            _listIThings.Add(entity);
            _dictIThings.Add(entity.CID, entity);
            Logger.Inst.Info($"{_TName} with CID: {entity.CID} added to {_TName}Manager.");

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
                Logger.Inst.Info(entity.ToString());
            }
        }
    }
}
