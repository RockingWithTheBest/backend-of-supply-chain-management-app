using System.ComponentModel.DataAnnotations;
using xx1.Db;

namespace Back_End.Models
{
    public class OrderEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string OrderStatus { get; set; }
        [Required]
        [StringLength(50)]
        public string TaxStatus { get; set; }
        [Required]
        public int Quantity { get; set; }

        [Required]
        public int ProductId { get; set; }
        public int? CustomerId { get; set; }

        //Navigation property
        public virtual CustomerEntity? Customer { get; set; }

        public virtual ProductEntity? Product { get; set; }

    }
}
