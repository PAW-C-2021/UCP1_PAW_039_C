using System;
using System.Collections.Generic;

#nullable disable

namespace UCP1_PAW_039_C.Models
{
    public partial class Payment
    {
        public int IdPayment { get; set; }
        public string Price { get; set; }
        public int? CodePayment { get; set; }
    }
}
