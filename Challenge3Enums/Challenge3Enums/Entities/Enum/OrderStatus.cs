﻿using System;

namespace Challenge3Enums.Entities.Enum
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3,
    }
}
