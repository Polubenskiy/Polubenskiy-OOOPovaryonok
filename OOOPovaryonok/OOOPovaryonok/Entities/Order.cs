namespace OOOPovaryonok.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderContent = new HashSet<OrderContent>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Required]
        [StringLength(3)]
        public string OrderCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDateDecoretion { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDateDelivery { get; set; }

        public int OrderStatusID { get; set; }

        public int OrderClientID { get; set; }

        public int OrderPointIssueID { get; set; }

        public int OrderProductAndCountID { get; set; }

        public virtual PointIssue PointIssue { get; set; }

        public virtual Status Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderContent> OrderContent { get; set; }
    }
}
