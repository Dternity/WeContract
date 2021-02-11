namespace WeContractLib
{
    public static class Controller
    {
        private static Customer.CustomerManager _customerM;
        private static Contract.ContractManager _contractM;

        public static void Initialize()
        {
            _customerM = new Customer.CustomerManager();
            _contractM = new Contract.ContractManager();
            CustomerManager = _customerM;
            ContractManager = _contractM;
        }

        public static void Load()
        {
            
        }

        public static Customer.CustomerManager CustomerManager;
        public static Contract.ContractManager ContractManager;
    }
}
