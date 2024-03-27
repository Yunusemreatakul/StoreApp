using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StoreApp.Data.Abstract;
using StoreApp.Web.Models;

namespace StoreApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public int PageSize = 3; 

        private readonly IStoreRepository _storeRepository;
        private readonly IMapper _Imapper;
        public HomeController(IStoreRepository storeRepository,IMapper Imapper)
        {
            _storeRepository=storeRepository;
            _Imapper=Imapper;
        }
        public IActionResult Index(string? category,int Page = 1)
        {   
           
            var product = _storeRepository.GetProductByCategory(category,Page,PageSize)
                .Select(p=> _Imapper.Map<ProductViewModel>(p)).Take(PageSize);
            return View(new ProductViewListModel {
                products = product,
                PageInfo = new PageInfo {
                    ItemsInPage = PageSize,
                    CurrentPage = Page,
                     TotalItems = _storeRepository.GetProductCount(category),
                }
            }
             );
        }
    }
}