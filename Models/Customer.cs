using System.ComponentModel.DataAnnotations;

namespace E_commerce.Models
{
    /*CustomerID (int): The unique identifier for the customer.
 Name (string): The customer’s name.
 Email (string):*/
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
