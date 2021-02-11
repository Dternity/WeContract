using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WeContractLib.Diagnostics;

namespace WeContractLib.Customer
{
    public class CustomerManager: Atlas<Customer>
    {

        public CustomerManager() : base("Customer")
        {
        }

        public override bool Add(Customer entity)
        {
            if (Exist(entity.CID))
            {
                Logger.Inst.Error($"{_TName} with CID: {entity.CID} already exist!", MethodBase.GetCurrentMethod());
                return false;
            }

            if (_listIThings.Exists(x => x.Name == entity.Name))
            {
                Logger.Inst.Error($"{_TName}  with Name: {entity.Name} already exist in {_TName}Manager");
                return false;
            }

            entity.ID = _indexCounter;
            _indexCounter++;

            _listIThings.Add(entity);
            _dictIThings.Add(entity.CID, entity);
            Logger.Inst.Info($@"{_TName} with name:{entity.Name} added to {_TName}Manager!.");
            return true;
        }

        public void Test()
        {
            var customer = new Customer("Henrik", "Selsbanesgate 21", 41099661, 8514, "test@gmail.com", 47, "Hello World");
            _dictIThings.Add(customer.CID,customer);
            _dictIThings.TryGetValue(customer.CID, out var thing);
        }
    }
}
