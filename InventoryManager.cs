public class InventoryManager
{
    public List<Product> SortProducts(List<Product> products, string sortKey, bool ascending)
    {
        switch (sortKey.ToLower())
        {
            case "name":
                return ascending ? products.OrderBy(p => p.Name).ToList() : products.OrderByDescending(p => p.Name).ToList();
            case "price":
                return ascending ? products.OrderBy(p => p.Price).ToList() : products.OrderByDescending(p => p.Price).ToList();
            case "stock":
                return ascending ? products.OrderBy(p => p.Stock).ToList() : products.OrderByDescending(p => p.Stock).ToList();
            default:
                throw new ArgumentException("Invalid sort key. Supported keys: name, price, stock");
        }
    }
}