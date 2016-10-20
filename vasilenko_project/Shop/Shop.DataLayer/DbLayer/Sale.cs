namespace Shop.DataLayer.DbLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sale")]
    public partial class Sale
    {
        public Sale()
        {
            SalePos = new HashSet<SalePos>();
        }

        public int SaleId { get; set; }

        public DateTime SaleDate { get; set; }

        [Required]
        [StringLength(24)]
        public string SaleNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal SaleSumma { get; set; }

        public virtual ICollection<SalePos> SalePos { get; set; }
    }
}
