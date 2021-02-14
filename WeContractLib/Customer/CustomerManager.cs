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
        public void Test()
        {
            var customer = new Customer("Henrik", "Selsbanesgate 21", 41099661, 8514, "test@gmail.com", 47, "Hello World");
            _dictIThings.Add(customer.CID,customer);
            _dictIThings.TryGetValue(customer.CID, out var thing);
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
