using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce.Models
{
    /*OrderItemID (int): The unique identifier for the order item.
 OrderID (int): The ID of the associated order.
 ProductID (int): The ID of the associated product.
 Quantity (int): The quantity of the product in the order.
 UnitPrice (decimal): The*/
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        public Order Order { get; set; }
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
