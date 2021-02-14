using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeContractLib.Misc
{
    public static class GlobalEventHandler
    {
        public class EventArgs<T> : EventArgs
        {
            private readonly T _obj;

            public EventArgs(T obj) => _obj = obj;

            public T Entity => _obj;
        }


        public static EventHandler<EventArgs<Customer.Customer>> CustomerAdded;
        public static EventHandler<EventArgs<Customer.Customer>> CustomerRemoved;
        public static EventHandler<EventArgs<Customer.Customer>> CustomerChanged;

        public static EventHandler<EventArgs<Contract.Contract>> ContractAdded;
        public static EventHandler<EventArgs<Contract.Contract>> ContractRemoved;
        public static EventHandler<EventArgs<Contract.Contract>> ContractChanged;

        public static EventHandler<EventArgs<string>> LoaderActionInvoked;

        //public static void OnCustomerAdded(object sender, EntityEventArgs<Customer.Customer> args)
        //{
        //    CustomerAdded?.Invoke(sender, args);
        //}

        //public static void OnCustomerRemoved(object sender, EntityEventArgs<Customer.Customer> args)
        //{
        //    CustomerRemoved?.Invoke(sender, args);
        //}

        //public static void OnCustomerChanged(object sender, EntityEventArgs<Customer.Customer> args)
        //{
        //    CustomerChanged?.Invoke(sender, args);
        //}
    }
}
