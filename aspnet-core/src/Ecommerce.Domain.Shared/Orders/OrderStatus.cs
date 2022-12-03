using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Orders
{
    public enum OrderStatus
    {
        New,
        Confirmed,
        Processing,
        Shipping,
        Finished,
        Canceled
    }
}
