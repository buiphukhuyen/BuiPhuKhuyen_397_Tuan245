namespace BuiPhuKhuyen_397_Tuan2.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
