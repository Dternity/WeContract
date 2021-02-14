﻿using WeContractLib.Storage;

namespace WeContractLib
{
    public static class Controller
    {
        private static Customer.CustomerManager _customerM;
        private static Contract.ContractManager _contractM;
        private static ImageManager _imageM;

        public static void Initialize()
        {
            _customerM = new Customer.CustomerManager();
            _contractM = new Contract.ContractManager();
            _imageM = new ImageManager();
            CustomerManager = _customerM;
            ContractManager = _contractM;
            ImageManager = _imageM;
        }

        public static Customer.CustomerManager CustomerManager;
        public static Contract.ContractManager ContractManager;
        public static ImageManager ImageManager;
    }
}
