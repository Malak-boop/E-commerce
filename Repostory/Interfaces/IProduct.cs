using E_commerce.Models;

namespace E_commerce.Repostory.Interfaces
{
    public interface IProduct
    {
        public Task <IEnumerable<Product>>GetAllProducts();
        public Task Addprouct(Product product);
        public Task UpdateProducts(Product product,int id);
        public Task DeleteProduct(Product product);
        public Task<Product> GetProductById(int id);


    }
}
