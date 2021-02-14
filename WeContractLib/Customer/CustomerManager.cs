using System.Reflection;
using WeContractLib.Diagnostics;
using WeContractLib.Misc;

namespace WeContractLib.Customer
{
    public class CustomerManager: Atlas<Customer>
    {
        private bool _disposed = false;
        public CustomerManager() : base("customer")
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

        protected override bool AddToDbAfterInserted(LiteDB.LiteCollection<Customer> col, Customer entity)
        {
            GlobalEventHandler.CustomerAdded?.Invoke(this, new GlobalEventHandler.EventArgs<Customer>(entity));
            return col.EnsureIndex(x => x.Name);
        }

        protected override bool AddToDbPreCheck(Customer entity)
        {
            return true;
        }
    }
}
