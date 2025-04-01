using Back_End.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xx1.Entities_Models_
{
    public class InventoryEntity
    {
        [Key]
        public int Id { get; set; }
        public int? OrderCheckId {  get; set; }
        [Required]
        public int OrderId { get; set; }
        public string? ProductName { get; set; }
        public int? Quantity { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? PricePaid { get; set; }
        public string? CustomerNames {  get; set; }
        public string? Status { get; set; }
        public int? CustomerId { get; set; }
        public virtual OrderCheckEntity? OrderCheck { get; set; }
        public virtual OrderEntity? Order { get; set; }
        public virtual CustomerEntity? Customer { get; set; }
    }
}
