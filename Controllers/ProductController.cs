using E_commerce.Models;
using E_commerce.Repostory.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.Controllers
{
    public class ProductController : Controller
    {
       public readonly IProduct repo;
        public ProductController(IProduct repo)
        {
            this.repo = repo;
        }
        public async Task <IActionResult>GetById(int id)
        {
           return View(await repo.GetProductById(id));
        }
        public async  Task<IActionResult> GetAll()
        {
            var s = await repo.GetAllProducts();
            return View(s);
        }
        [HttpGet]
        public async Task<IActionResult>Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            await repo.Addprouct(product);
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
           
            return View(await repo.GetProductById(id));
        }
        [HttpPost]
        public async Task<IActionResult>Update(Product product,int id)
        {
            await repo.UpdateProducts(product,id);
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public async Task<IActionResult>Delete(int id)
        {
            var cf = await repo.GetProductById(id);
            return View(cf);
        }
        [HttpPost]
        public async Task<IActionResult>Delete(Product product)
        {
            await repo.DeleteProduct(product);
            return RedirectToAction("GetAll");
        }
    }
}
