using DTownsBlog.Model;

namespace DTownsBlog.Repository.CategoryRepository
{
    public interface ICategoryRepository
    {
        bool CategoryExistByName(string Name);
        bool CategoryExists(int id);
        List<Category> GetAll();
        bool Create(Category category);
        bool Update(Category category);
        Category GetCategoryById(int id);
        bool Delete(Category category);
        bool Save();
    }
}
