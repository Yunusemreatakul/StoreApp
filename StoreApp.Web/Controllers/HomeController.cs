using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreApp.Data.Abstract;
using StoreApp.Web.Models;

namespace StoreApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public int PageSize = 3; 

        private IStoreRepository _storeRepository;
        public HomeController(IStoreRepository storeRepository)
        {
            _storeRepository=storeRepository;
        }
        public IActionResult Index(int Page = 1)
        {
            var product = _storeRepository
                .Products
                .Skip((Page-1)*PageSize)
                .Select(p=> new ProductViewModel {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                Category = p.Category
            }).Take(PageSize);
            return View(new ProductViewListModel {
                products = product,
                PageInfo = new PageInfo {
                    TotalItems = _storeRepository.Products.Count(),
                    ItemsInPage = PageSize
                }
            }
             );
        }
    }
}