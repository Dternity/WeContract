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
    public static class DBO
    {
        public static string ProjectRoot = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin"));
        public static string DbName = @$"filename={ProjectRoot}\db.db;mode=shared";

        public static void CreateDatabase()
        {
            using var db = new LiteDatabase(DbName);
            var col = db.GetCollection<Contract.Contract>("contract");
            var col2 = db.GetCollection<Customer.Customer>("customer");

            var customer = new Customer.Customer("Henrik", "Selsbanesgate 21", 41099661, 8514, "test@gmail.com", 47, "Hello World");

            var contract = new Contract.Contract(customer);

            col.Insert(contract);
            col.Update(contract);
            col.EnsureIndex(x => x.CID);
            col2.Insert(customer);
            col2.Update(customer);
            col2.EnsureIndex(x => x.CID);
            var ss = db.GetCollectionNames();

            var results = col.Find(x => x.CustomerName.StartsWith("He"));
        }
    }
}
