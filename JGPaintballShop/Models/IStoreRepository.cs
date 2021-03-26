using System.Linq;

namespace JGPaintballShop.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
