using BuiPhuKhuyen_397_Tuan2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BuiPhuKhuyen_397_Tuan2.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        //Danh sách các sản phẩm
        public IActionResult Index()
        {
            var products = _productRepository.GetAll();

            return View(products);
        }

        //Tạo mới sản phẩm
        public IActionResult Add()
        {
            var categories = _categoryRepository.GetAllCategories();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.Add(product);
                return RedirectToAction("Index"); // Chuyển hướng tới trang danh sách sản phẩm
            }
            return View(product);
        }


    }
}
