using Microsoft.EntityFrameworkCore;
using StoreApp.Data.Abstract;

namespace StoreApp.Data.Concrete
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext _context;
        public EFStoreRepository(StoreDbContext context)
        {
            _context = context;
        }
        public IQueryable<Product> Products => _context.products;

        public IQueryable<Category> Categories => _context.Categories;

        public void CreateProduct(Product entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductByCategory(string category, int Page, int PageSize)
        {
            var list = Products;
            if(!string.IsNullOrEmpty(category))
            {
                list = list.Include(p =>p.Categories).Where(p =>p.Categories.Any(c =>c.Url ==category));
            }
            return list.Skip((Page-1)*PageSize).Take(PageSize);
        }

        public int GetProductCount(string category)
        {
            if(string.IsNullOrEmpty(category))
            {
                return  Products.Count() ;
            } 
            else
            {
                return Products.Include(p => p.Categories).Where(p => p.Categories.Any(c =>c.Url == category)).Count();
            }
        }
    }
}