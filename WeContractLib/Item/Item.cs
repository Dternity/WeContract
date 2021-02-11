using System;

namespace WeContractLib.Item
{
    public class Item : IThing
    {
        private bool _delivered;
        private bool _ordered;
        private bool _purchased;


        public Item()
        {
            CID = Guid.NewGuid();
            DateCreated = DateTime.Now;
        }

        public string Name { get; set; }
        public int ID { get; set; }
        public DateTime DateCreated { get; set; }
        public double Price { get; set; }
        public ushort Quantity { get; set; }
        public Guid CID { get; set; }
        public bool Ordered { get => _ordered; set { _ordered = value; OnOrderedChanged(this, value); } }
        public DateTime OrderDate { get; set; }

        public bool Delivered { get => _delivered; set { _delivered = value; OnDeliveredChanged(this, value); } }
        public DateTime DeliveredDate { get; set; }

        public bool Purchased { get => _purchased; set { _purchased = value; OnPurchasedChanged(this, value); } }
        public DateTime PurchasedDate { get; set; }

        public double GetTotalPrice()
        {
            return Price * Quantity;
        }

        public virtual void OnDeliveredChanged(object sender, bool e)
        {
            DeliveredChanged?.Invoke(sender, e);
        }

        public virtual void OnOrderedChanged(object sender, bool e)
        {
            OrderedChanged?.Invoke(sender, e);
        }

        public virtual void OnPurchasedChanged(object sender, bool e)
        {
            PurchasedChanged?.Invoke(sender, e);
        }

        public Item Clone()
        {
            var clone = new Item()
            {
                Name = Name,
                ID = ID,
                DateCreated = DateCreated,
                Price = Price,
                Quantity = Quantity,
                CID = CID,
                Ordered = Ordered,
                OrderDate = OrderDate,
                Delivered = Delivered,
                DeliveredDate = DeliveredDate,
                Purchased = Purchased,
                PurchasedDate = PurchasedDate,
            };
            return clone;
        }

        public event EventHandler<bool> DeliveredChanged;
        public event EventHandler<bool> OrderedChanged;
        public event EventHandler<bool> PurchasedChanged;
    }
}
