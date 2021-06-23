using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping.Models
{
    public partial class ItemsCat
    {
        public ItemsCat()
        {
            ItemsSubCats = new HashSet<ItemsSubCat>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; }

        public virtual ICollection<ItemsSubCat> ItemsSubCats { get; set; }
    }
}
