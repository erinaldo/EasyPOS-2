﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    class DgvSalesDetailTenderPayTypeEntity
    {
        public Int32 Id { get; set; }
        public String PayType { get; set; }
        public Decimal Amount { get; set; }
        public String OtherInformation { get; set; }
    }
}
