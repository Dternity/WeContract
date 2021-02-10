using System;

namespace WeContractLib.Contract
{
    public class Contract
    {
        public string Note { get; set; } = string.Empty;
        public Guid CID { get; set; }
        public string CustomerName { get; set; }
        public int Index { get; set; }
        public double Price { get; set; }
        public Tags Tags { get; set; }
        public Status Status { get; set; }
        public DateTime CreationDate { get; set; }
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
    }


}
