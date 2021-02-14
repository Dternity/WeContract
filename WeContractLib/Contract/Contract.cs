using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WeContractLib.Diagnostics;
using WeContractLib.Misc;
using static WeContractLib.Misc.GlobalEventHandler;

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
            var customer = Customer ?? Controller.CustomerManager.Get(CustomerCID);
            if (customer == null)
            {
                Log.Error($"Customer is null on contract: {CID} Customer name:{CustomerName}", MethodBase.GetCurrentMethod());
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

            if (!CustomerContacted)
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
        #region Item

        /// <summary>
        /// Gets the total cost of all the items.
        /// </summary>
        /// <returns>Total cost as a double.</returns>
        public double GetTotalCost()
        {
            return Items.Sum(x => x.GetTotalPrice());
        }

        public bool AddItem(Item.Item item)
        {
            if (item == null)
            {
                Log.Warning($"AddItem - Item is null contract:{CID}");
                return false;
            }

            if (Items.Contains(item))
            {
                Log.Warning($"AddItem - There is already an item attached to contract:{CID} Item:{item.Name}");
                return false;
            }

            Items.Add(item);
            item.AttachEntity(this);
            item.Subscribe();
            item.Changed += OnItemChanged;
            return true;
        }

        public bool RemoveItem(Item.Item item)
        {
            if (item == null)
            {
                Log.Warning($"RemoveItem - Item is null contract:{CID}");
                return false;
            }

            if (Items.Contains(item))
            {
                item.DeattachEntity(this);
                item.UnSubscribe();
                item.Changed -= OnItemChanged;
                return Items.Remove(item);
            }

            Log.Warning($"RemoveItem - Item:{item.Name} does on exist in contract:{CID}.");
            return false;
        }

        private void OnItemChanged(object sender, EventArgs<Item.Item> e)
        {
            Log.Debug($"Item: {e.Entity.Name}  changed!");
        }

        #endregion

        public bool AttachEntity(IThing entity)
        {
            var newCustomer = Controller.CustomerManager.Get(entity.CID);

            if(newCustomer == null)
            {
                Log.Warning($"Attach - new customer is null on contract:{CID}");
                return false;
            }

            if (Customer != null)
            {
                Log.Warning($"Attach - There is already a customer attached to contract:{CID} Current customer:{Customer.Name} new customer:{newCustomer.Name}");
                return false;
            }

            Customer = newCustomer;
            CustomerCID = newCustomer.CID;
            CustomerName = newCustomer.Name;
            return true;
        }

        public bool DeattachEntity(IThing entity)
        {
            if (Customer == null)
            {
                Customer = null;
                CustomerCID = Guid.Empty;
                CustomerName = string.Empty;
                return true;
            }

            if (Customer.CID != entity.CID)
            {
                Log.Warning($"Deattach - wrong CID, deattaching blocked on contract:{CID}");
                return false;
            }

            Customer = null;
            CustomerCID = Guid.Empty;
            CustomerName = string.Empty;
            return true;
        }

        public string Note { get; set; } = string.Empty;
        public Guid CID { get; set; }
        public string CustomerName { get; set; }
        public Guid CustomerCID { get; set; }
        public Customer.Customer Customer
        {
            get
            {
                if (!(_IThing is Customer.Customer))
                {
                    Log.Error("Customer(IThing) is null!", MethodBase.GetCurrentMethod());
                    return null;
                }

                return _IThing as Customer.Customer;
            }
            set
            {
                if (value == null)
                {
                    Log.Error("Customer(IThing) is null!", MethodBase.GetCurrentMethod());
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
        public bool WaitingToArchive { get; set; }
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

        public event EventHandler<EventArgs<Item.Item>> ItemChanged;
    }
}
