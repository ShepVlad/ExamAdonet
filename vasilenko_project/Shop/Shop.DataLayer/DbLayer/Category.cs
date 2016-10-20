namespace Shop.DataLayer.DbLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        public Category()
        {
            Goods = new HashSet<Good>();
        }

        public int CategoryId { get; set; }

        [Required]
        [StringLength(20)]
        public string CategoryName { get; set; }

        public virtual ICollection<Good> Goods { get; set; }
    }
}
