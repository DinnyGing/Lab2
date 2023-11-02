using Lab2.Db;
using Lab2.DTO;
using Lab2.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Lab2.Services
{
    public class CategoryRepository
    {
        public List<Category> GetAll()
        {
            List<Category> categories;
            using (ApplicationContext db = new ApplicationContext())
            {
                categories = db.Categories.ToList();
            }
            return categories;
        }
        public List<CategotyDTO> GetAllWithOutList()
        {
            List<CategotyDTO> categories;
            using (ApplicationContext db = new ApplicationContext())
            {
                var query = from category in db.Categories
                            select new CategotyDTO()
                            {
                                CategoryId = category.CategoryId,
                                Name = category.Name
                            };
                categories = query.ToList();
            }
            return categories;
        }
        public Category GetById(int id)
        {
            Category category;
            using (ApplicationContext db = new ApplicationContext())
            {
                category = db.Categories.FirstOrDefault(p => p.CategoryId == id);
            }
            return category;
        }
        public Category GetByName(string name)
        {
            Category category;
            using (ApplicationContext db = new ApplicationContext())
            {
                category = (from c in db.Categories 
                            where c.Name == name 
                            select c).FirstOrDefault();
            }
            return category;
        }
        public void Create(Category category)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (category != null)
                {
                    db.Categories.Add(category);
                    db.SaveChanges();
                }
            }
        }
        public void Update(Category category)
        {
            using (ApplicationContext db = new ApplicationContext())
            {                
                if (category != null)
                {
                    db.Categories.Update(category);
                    db.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var category = db.Categories.Find(id);
                if(category != null)
                {
                    db.Categories.Remove(category);
                    db.SaveChanges();
                }
            }
        }
    }
}
