namespace OOOPovaryonok.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Manufacture")]
    public partial class Manufacture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Manufacture()
        {
            Product = new HashSet<Product>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ManufactureID { get; set; }

        [Required]
        [StringLength(100)]
        public string ManufactureName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
