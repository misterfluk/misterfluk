using System;
using System.Collections.Generic;

namespace PeTest.Models
{
    public partial class TCustomer
    {
        public string CustId { get; set; }
        public string InitialCode { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string CustType { get; set; }

        public TType CustTypeNavigation { get; set; }
        public TTitel InitialCodeNavigation { get; set; }
    }
}
