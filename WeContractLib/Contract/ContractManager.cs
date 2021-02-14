using LiteDB;
using System.Reflection;
using WeContractLib.Diagnostics;
using WeContractLib.Misc;

namespace WeContractLib.Contract
{
    public class ContractManager : Atlas<Contract>
    {
        private bool _disposed = false;
        public ContractManager() : base("contract")
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
            }

            _disposed = true;

            // Call base class implementation.
            base.Dispose(disposing);
        }

        protected override bool AddToDbPreCheck(Contract entity)
        {
            if (!entity.WaitingToArchive)
            {
                Log.Error($"{_TName} with CID: {entity.CID} is not ready to be archived!", MethodBase.GetCurrentMethod());
                return false;
            }

            return true;
        }

        protected override bool AddToDbAfterInserted(LiteCollection<Contract> col, Contract entity)
        {
            GlobalEventHandler.ContractAdded?.Invoke(this, new GlobalEventHandler.EventArgs<Contract>(entity));
            return col.EnsureIndex(x => x.WaitingToArchive);
        }
    }
}