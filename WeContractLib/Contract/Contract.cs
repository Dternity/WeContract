using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WeContractLib.Diagnostics;
using WeContractLib.Misc;

namespace WeContractLib.Contract
{
    public class Contract : IThing, IDisplayable
    {

        public Contract()
        {
            CID = Guid.NewGuid();
            DateCreated = DateTime.Now;
            _items = new List<Item.Item>();
            
        }

        public Contract(Customer.Customer customer) : this()
        {
            Customer = customer;
            CustomerCID = customer.CID;
            CustomerName = customer.Name;
            Customer.AddContract(CID);
        }

        public List<object> GetColumnIndexes()
        {

            var customer = Customer;
            if (customer == null)
            {
                customer = Controller.CustomerManager.Get(CustomerCID);
            }
            if (customer == null)
            {
                Logger.Inst.Error($@"Customer is null on contract: {CID} Customer name:{CustomerName}", MethodBase.GetCurrentMethod());
                return null;
            }
            var customerContactedDate = "Nha";
            var customerEmail = "Nha";
            var archivedDate = "Nha";


            if (CustomerContactedDate != new DateTime())
            {
                customerContactedDate = CustomerContactedDate.ToShortDateString();
            }

            if (customer != null && !string.IsNullOrEmpty(customer.EmailAddress))
            {
                customerEmail = customer.EmailAddress;
            }

            if (ArchivedDate != new DateTime())
            {
                archivedDate = ArchivedDate.ToShortDateString();
            }

            var customerContacted = "Nha";

            if (CustomerContacted == false)
            {
                customerContacted = "Nha";
            }

            return new List<object>()
                {
                    customer.Name,
                    TextFormatting.PhoneNumberFormat(Convert.ToUInt32(customer.PhoneNumber)),
                    DateCreated.ToShortDateString(),
                    "Hei",
                    GetTotalCost().ToString("C2"),
                    Items.Count,
                    LastUpdatedDate.ToShortDateString(),
                    archivedDate,
                    customerContacted,
                    customerContactedDate,
                    customerEmail,
                    Note,
                };

        }

        /// <summary>
        /// Gets the total cost of all the items.
        /// </summary>
        /// <returns>Total cost as a double.</returns>
        public double GetTotalCost()
        {
            return Items.Sum(x => x.GetTotalPrice());
        }

        public string Note { get; set; } = string.Empty;
        public Guid CID { get; set; }
        public string CustomerName { get; set; }
        public Guid CustomerCID { get; set; }
        public Customer.Customer Customer
        {
            get
            {
                if (_IThing as Customer.Customer == null)
                {
                    Logger.Inst.Error($@"Customer(IThing) is null!", MethodBase.GetCurrentMethod());
                    return null;
                }

                return _IThing as Customer.Customer;
            }
            set
            {
                if (value == null)
                {
                    Logger.Inst.Error($@"Customer(IThing) is null!", MethodBase.GetCurrentMethod());
                    return;
                }

                _IThing = value;
            }
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public double Price { get; set; }
        public Tags Tags { get; set; }
        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public bool CustomerContacted { get; set; }
        public bool CloseOnPurchased { get; set; } = true;
        public DateTime CustomerContactedDate { get; set; }
        public DateTime SuspendedDate { get; set; }
        public bool CalculateWithTax { get; set; } = true;
        public bool IsArchived { get; set; }
        public DateTime ArchivedDate { get; set; }
        public bool IsOrdered;
        public bool IsDelivered;
        public bool IsPaid;
        public bool IsSuspended;
        public bool IsPriceRequest;

        public IList<Item.Item> Items
        {
            get => _items;
            set => _items = (List<Item.Item>)value;
        }

        internal List<Item.Item> _items;
        internal IThing _IThing;
    }


}
