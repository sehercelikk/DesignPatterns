using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository.Business.Abstract;
using Repository.Entity.Concrete;
using Repository.WebUI.Models;
using System.Diagnostics;

namespace Repository.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public HomeController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetListCategory()
        {
            var values = _categoryService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCategory() => View();

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.TInsert(category);
            return RedirectToAction("GetListCategory");
        }

        [HttpGet]
        public IActionResult DeleteCategory(int id)
        {
            var values= _categoryService.TGetById(id);
            _categoryService.TDelete(values);
            return RedirectToAction("GetListCategory");
        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var values = _categoryService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.TUpdate(category);
            return RedirectToAction("GetListCategory");
        }


        public IActionResult GetListProduct()
        {
            var result = _productService.TGetList();
            return View(result);
        }

        public IActionResult AddProduct()
        {
            List<SelectListItem> values = (from c in _categoryService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = c.Name,
                                               Value = c.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v=values;
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productService.TInsert(product);
            return RedirectToAction("GetListProduct");
        }

        public IActionResult UpdateProduct(int id)
        {
            List<SelectListItem> category = (from c in _categoryService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = c.Name,
                                               Value = c.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v = category;
            var value = _productService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.TUpdate(product);
            return RedirectToAction("GetListProduct");
        }
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            return RedirectToAction("GetListProduct");
        }

        public IActionResult GetProductWithCategory()
        {
            var result = _productService.TGetCategoryProduct();
            return View(result);
        }
    }
}
