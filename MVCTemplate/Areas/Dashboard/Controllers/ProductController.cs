using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCTemplate.Areas.Dashboard.Models;

namespace MVCTemplate.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class ProductController : Controller
    {
        private List<ProductViewModel> products;
        private List<CategoryViewModel> categories;
        public ProductController()
        {
            products = new List<ProductViewModel>();
            categories = new List<CategoryViewModel>();
        }

        // GET: ProductController
        public ActionResult Index()
        {
            //Index CRUD işlemlerinde genellikle model listesini göüntüler.
            return View(products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View(products.FirstOrDefault(x => x.Id == id));
        }

        // GET: Product ve Category formları için Gateway yapsıı oluştu.
        public ActionResult Create()
        {
            return View(new Tuple<ProductViewModel,CategoryViewModel>(new ProductViewModel(),new CategoryViewModel()));
        }

        public ActionResult CreateProduct()
        {
            return View();
        }

        public ActionResult CreateCategory()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProduct(ProductViewModel model)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCategory(CategoryViewModel model)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }


        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(products.FirstOrDefault(x => x.Id == id));
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductViewModel model)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(products.FirstOrDefault(x => x.Id == id));
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProductViewModel model)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
}
