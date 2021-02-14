using System;

namespace WeContractLib.Misc
{
	public static class GlobalEventHandler
    {
        public class EventArgs<T> : EventArgs
        {
            public EventArgs(T obj) => Entity = obj;

			public T Entity { get; }
		}

        public static EventHandler<EventArgs<Customer.Customer>> CustomerAdded;
        public static EventHandler<EventArgs<Customer.Customer>> CustomerRemoved;
        public static EventHandler<EventArgs<Customer.Customer>> CustomerChanged;

        public static EventHandler<EventArgs<Contract.Contract>> ContractAdded;
        public static EventHandler<EventArgs<Contract.Contract>> ContractRemoved;
        public static EventHandler<EventArgs<Contract.Contract>> ContractChanged;

		public static EventHandler<EventArgs<string>> LoaderActionInvoked;
    }
}
