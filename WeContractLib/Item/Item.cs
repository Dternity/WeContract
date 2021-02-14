using System;
using WeContractLib.Diagnostics;
using static WeContractLib.Misc.GlobalEventHandler;

namespace WeContractLib.Item
{
    public class Item : IThing
    {
        private bool _delivered;
        private bool _ordered;
        private bool _paid;
        private double price;
        private ushort units;
        private DateTime paidDate;
        private string name;

        public Item()
        {
            CID = Guid.NewGuid();
            DateCreated = DateTime.Now;
        }

        public string Name
        {
            get => name; set
            {
                name = value;
                RaiseChanged();
            }
        }
        public int ID { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid Contract { get; set; }
        public double Price { get => price; set { price = value; UnitPriceChanged?.Invoke(this, new EventArgs<Item>(this)); RaiseChanged(); } }
        public ushort Units { get => units; set { units = value; UnitsChanged?.Invoke(this, new EventArgs<Item>(this)); RaiseChanged(); } }
        public Guid CID { get; set; }
        public bool Ordered { get => _ordered; set { _ordered = value; OrderedChanged?.Invoke(this, new EventArgs<Item>(this)); RaiseChanged(); } }
        public DateTime OrderDate { get; set; }

        public bool Delivered { get => _delivered; set { _delivered = value; DeliveredChanged?.Invoke(this, new EventArgs<Item>(this)); RaiseChanged(); } }
        public DateTime DeliveredDate { get; set; }

        public bool Paid { get => _paid; set { _paid = value; PaidChanged?.Invoke(this, new EventArgs<Item>(this)); RaiseChanged(); } }
        public DateTime PaidDate { get => paidDate; set => paidDate = value; }

        public double GetTotalPrice()
        {
            return Price * Units;
        }

        public void Subscribe()
        {
            OrderedChanged += OrderedChanged == null ? OnOrderedChanged : null;
            DeliveredChanged += DeliveredChanged == null ? OnDeliveredChanged : null;
            PaidChanged += PaidChanged == null ? OnPaidChanged : null;
        }

        public void UnSubscribe()
        {
            OrderedChanged -= OnOrderedChanged;
            DeliveredChanged -= OnDeliveredChanged;
            PaidChanged -= OnPaidChanged;
        }

        private void RaiseChanged()
        {
            Changed?.Invoke(this, new EventArgs<Item>(this));
        }

        public virtual void OnDeliveredChanged(object sender, EventArgs<Item> e)
        {
            Log.Debug($@"Item: {Name} delivered changed to {Delivered}");
            DeliveredDate = Delivered ? DeliveredDate = DateTime.Now : DeliveredDate = default;
        }

        public virtual void OnOrderedChanged(object sender, EventArgs<Item> e)
        {
            Log.Debug($@"Item: {Name} ordered changed to {Ordered}");
            OrderDate = Ordered ? OrderDate = DateTime.Now : OrderDate = default;
        }

        public virtual void OnPaidChanged(object sender, EventArgs<Item> e)
        {
            Log.Debug($@"Item: {Name} paid changed to {Paid}");
            PaidDate = Paid ? PaidDate = DateTime.Now : PaidDate = default;
        }

        public Item Clone()
        {
            var clone = new Item()
            {
                Name = Name,
                ID = ID,
                DateCreated = DateCreated,
                Contract = Contract,
                Price = Price,
                Units = Units,
                CID = CID,
                Ordered = Ordered,
                OrderDate = OrderDate,
                Delivered = Delivered,
                DeliveredDate = DeliveredDate,
                Paid = Paid,
                PaidDate = PaidDate,
            };
            return clone;
        }

        public bool AttachEntity(IThing entity)
        {
            if (Contract == entity.CID)
            {
                Log.Warning($@"Contract:{entity} is already added to item:{Name}");
                return false;
            }
            RaiseChanged();
            Contract = entity.CID;
            return true;
        }

        public bool DeattachEntity(IThing entity)
        {
            if (Contract == entity.CID)
            {
                Contract = Guid.Empty;
                return true;
            }

            Log.Warning($@"Contract:{entity} is not attached to item:{Name}");
            return false;
        }

        public event EventHandler<EventArgs<Item>> DeliveredChanged;
        public event EventHandler<EventArgs<Item>> OrderedChanged;
        public event EventHandler<EventArgs<Item>> PaidChanged;

        public event EventHandler<EventArgs<Item>> UnitPriceChanged;
        public event EventHandler<EventArgs<Item>> UnitsChanged;

        public event EventHandler<EventArgs<Item>> Changed;
    }
}
