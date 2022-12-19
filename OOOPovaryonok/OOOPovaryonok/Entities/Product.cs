namespace OOOPovaryonok.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderContent = new HashSet<OrderContent>();
        }

        [Key]
        [StringLength(100)]
        public string ProductArticleNumber { get; set; }

        [Required]
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public int ProductCategoryID { get; set; }

        [StringLength(100)]
        public string ProductPhoto { get; set; }

        public int ProductManufacturerID { get; set; }

        public decimal ProductCost { get; set; }

        public byte? ProductDiscountMax { get; set; }

        public byte ProductDiscountNow { get; set; }

        public int ProductQuantityInStock { get; set; }

        public int ProductUnitID { get; set; }

        public int ProductProviderID { get; set; }

        public virtual Category Category { get; set; }

        public virtual Manufacture Manufacture { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderContent> OrderContent { get; set; }

        public virtual Provider Provider { get; set; }

        public virtual Unit Unit { get; set; }
    }
}
