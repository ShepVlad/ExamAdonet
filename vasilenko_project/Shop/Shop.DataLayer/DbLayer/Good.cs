namespace Shop.DataLayer.DbLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Good")]
    public partial class Good
    {
        public Good()
        {
            Photos = new HashSet<Photo>();
            SalePos = new HashSet<SalePos>();
        }

        public int GoodId { get; set; }

        [Required]
        [StringLength(100)]
        public string GoodName { get; set; }

        public int? ManufacturerId { get; set; }

        public int? CategoryId { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal GoodCount { get; set; }

        public virtual Category Category { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }

        public virtual ICollection<SalePos> SalePos { get; set; }
    }
}
