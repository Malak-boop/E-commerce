using E_commerce.Models;
using E_commerce.Repostory.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;

namespace E_commerce.Repostory
{
    public class ProductRepo : IProduct
    {
        private readonly My_Context context;

        public ProductRepo(My_Context context)
        {
            this.context = context;
        }

        public async Task Addprouct(Product product)
        {
           await context.products.AddAsync(product);
            await context.SaveChangesAsync();
        }

        public async Task DeleteProduct(Product product)
        {
            context.products.Remove(product);
            await context.SaveChangesAsync();
        }

        public async  Task<IEnumerable<Product>> GetAllProducts()
        {
            var products = await context.products.ToListAsync();
            return products;
        }

        public async Task<Product> GetProductById(int id)
        {
            var nh=await context.products.FirstOrDefaultAsync(o=>o.ProductID==id);
            return nh;
        }

        public async Task UpdateProducts(Product product, int id)
        {
          var pd=await context.products.FirstOrDefaultAsync(o=>o.ProductID==id);
            pd.ProductName=product.ProductName;
            pd.Price=product.Price;
            pd.Description=product.Description;
            pd.StockQuantity=product.StockQuantity;
           context.products.Update(pd);
            await context.SaveChangesAsync();
        }
    }
}
