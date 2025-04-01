using Back_End.Models;
using System.ComponentModel.DataAnnotations;

namespace xx1.Entities_Models_
{
    public class OrderCheckEntity
    {
        [Key]
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        [Required]
        public string Status { get; set; }
        public string? ProductName { get; set; }
        public int ProductQuantity { get; set; }

        public virtual ProductEntity? Product { get; set; }
        public virtual OrderEntity? Order { get; set; }
    }
}
