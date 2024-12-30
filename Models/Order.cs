using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce.Models
{
    /*OrderID (int): The unique identifier for the order.
 CustomerID (int): The ID of the customer who placed the order.
 OrderDate (DateTime): The date when the order was placed.
 TotalAmount (decimal):*/
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }

    }
}
