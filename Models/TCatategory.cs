using System;
using System.Collections.Generic;

namespace PeTest.Models
{
    public partial class TCatategory
    {
        public TCatategory()
        {
            TProduct = new HashSet<TProduct>();
        }

        public string CatId { get; set; }
        public string NameCat { get; set; }

        public ICollection<TProduct> TProduct { get; set; }
    }
}
