using System;
using System.Collections.Generic;

namespace PeTest.Models
{
    public partial class TUnit
    {
        public TUnit()
        {
            TProduct = new HashSet<TProduct>();
        }

        public string UnitCode { get; set; }
        public string NameUnit { get; set; }

        public ICollection<TProduct> TProduct { get; set; }
    }
}
