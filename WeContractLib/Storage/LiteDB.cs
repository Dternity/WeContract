using LiteDB;
using WeContractLib.Customer;
using WeContractLib.Contract;
using WeContractLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeContractLib.Storage
{
    public static class LiteDB
    {

        public const string DbName = "db.db";

        public static void CreateDatabase()
        {
            using (var db = new LiteDatabase(DbName))
            {
                var col = db.GetCollection<Contract.Contract>("activecontracts");

                var customer = new Customer.Customer("Henrik", "Selsbanesgate 21", 41099661, 8514, "test@gmail.com", 47, "Hello World");

                var contract = new Contract.Contract(customer);

                col.Insert(contract);
                col.Update(contract);
                col.EnsureIndex(x => x.CID);
            }
        }
    }
}
