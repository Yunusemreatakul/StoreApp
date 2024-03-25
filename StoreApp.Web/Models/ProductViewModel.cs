using StoreApp.Web.Models;

namespace StoreApp.Web.Models
{
    public class ProductViewModel{
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Category { get; set; }= string.Empty;
    }
}
public class ProductViewListModel
{
    public IEnumerable<ProductViewModel> products {get; set;}= Enumerable.Empty<ProductViewModel>();
    public PageInfo? PageInfo { get; set; }
}
public class PageInfo
{
    public int TotalItems { get; set; }
    public int ItemsInPage { get; set; }
    public int TotalPage => (int)Math.Ceiling((decimal)TotalItems / ItemsInPage);

}