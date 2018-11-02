using System;
using System.Collections.Generic;

namespace PeTest.Models
{
    public partial class TSatus
    {
        public TSatus()
        {
            TProduct = new HashSet<TProduct>();
        }

        public string StatusId { get; set; }
        public string StatusName { get; set; }

        public ICollection<TProduct> TProduct { get; set; }
    }
}
