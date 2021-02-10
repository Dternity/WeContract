using System;

namespace WeContractLib
{
    /// <summary>
    /// The tags for each Contract.
    /// </summary>
    [Flags]
    public enum Tags
    {
        Ordered = 1 << 0,
        PriceRequest = 1 << 1,
        Delivered = 1 << 2,
        Purchased = 1 << 3,
        Suspended = 1 << 4
    }

    /// <summary>
    /// The status of the Contract.
    /// </summary>
    public enum Status
    {
        NULL,
        Open,
        Closed,
        Suspended,
    }
}
