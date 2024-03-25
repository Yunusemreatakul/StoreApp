using Microsoft.AspNetCore.Mvc;
using StoreApp.Data.Abstract;
using StoreApp.Data.Concrete;
using StoreApp.Web.Models;

namespace StoreApp.Web.Components
{
    public class CategoriesListViewComponent: ViewComponent
    {
        private readonly IStoreRepository _IStoreRepository;
        public CategoriesListViewComponent(IStoreRepository istoreRepository)
        {
            _IStoreRepository= istoreRepository;
        }
        public IViewComponentResult Invoke()
        {
            return View(_IStoreRepository.Categories.Select(c => new CategoryViewModel{
                Id= c.Id,
                Name = c.Name,
                Url = c.Url
            }));
        }
    }
}