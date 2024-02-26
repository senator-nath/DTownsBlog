using DTownsBlog.Data;
using DTownsBlog.Model;

namespace DTownsBlog.Repository.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _Db;

        public CategoryRepository(ApplicationDbContext Db)
        {
            _Db = Db;
        }

        public bool Create(Category category)
        {
            _Db.Categories.Add(category);
            return Save();
        }

        public bool Delete(Category category)
        {
            _Db.Categories.Remove(category);
            return Save();
        }

        public List<Category> GetAll()
        {
            return _Db.Categories.ToList();

        }

        public Category GetCategoryById(int id)
        {
            return _Db.Categories.FirstOrDefault(p => p.Id == id);
        }

        public bool CategoryExists(int id)
        {
            return _Db.Categories.Any(a => a.Id == id);
        }

        public bool Save()
        {
            return _Db.SaveChanges() >= 0 ? true : false;

        }

        public bool Update(Category category)
        {
            _Db.Categories.Update(category);
            return Save();

        }

        bool ICategoryRepository.CategoryExistByName(string name)
        {
            var value = _Db.Categories.Any(category => category.Name.ToLower().Trim() == name.Trim());
            return value;
        }
    }
}
