using System.ComponentModel.DataAnnotations;

namespace E_commerce.Models
{
    /*ProductID (int): The unique identifier for the product.
 Name (string): The name of the product.
 Price (decimal): The price of the product.
 Description (string): A short description of the product.
 StockQuantity (int):*/
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}
