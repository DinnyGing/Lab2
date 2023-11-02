using Lab2.Db;
using Lab2.DTO;
using Lab2.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2.Repositories
{
    public class MasterRepository
    {
        public List<Master> GetAll()
        {
            List<Master> masters;
            using (ApplicationContext db = new ApplicationContext())
            {
                masters = db.Masters.ToList();
            }
            return masters;
        }
        public List<MasterDTO> GetFilteredMasters(Func<MasterDTO, bool>[] filters)
        {
            var masters = GetAllWithCategoryName();

            foreach (var filter in filters)
            {
                masters = masters.Where(filter).ToList();
            }

            return masters;
        }
        public string GetCategoryNameByMasterId(int id)
        {
            string name;
            using (ApplicationContext db = new ApplicationContext())
            {
                var master = db.Masters.Include(p => p.Category).FirstOrDefault(p => p.MasterId == id);
                name = master.Category.Name;
            }
            return name;
        }
        public List<MasterDTO> GetAllWithCategoryName()
        {
            List<MasterDTO> masters;
            using (ApplicationContext db = new ApplicationContext())
            {
                var query = from master in db.Masters
                          select new MasterDTO()
                          {
                              MasterId = master.MasterId,
                              FirstName = master.FirstName,
                              LastName = master.LastName,
                              Gender = master.Gender,
                              Age = master.Age,
                              Phone = master.Phone,
                              Level = master.Level,
                              AgeInCategory = master.AgeInCategory,
                              CategoryName = master.Category.Name
                          };
                masters = query.ToList();
            }
            return masters;
        }
        public Master GetById(int id)
        {
            Master master;
            using (ApplicationContext db = new ApplicationContext())
            {
                master = db.Masters.FirstOrDefault(p => p.MasterId == id);
            }
            return master;
        }
        public void Create(Master master, Category category)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (master != null)
                {
                    db.Categories.Attach(category);
                    db.Masters.Add(master);
                    db.SaveChanges();
                }
            }
        }
        public void Update(Master master, Category category)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (master != null)
                {
                    db.Categories.Attach(category);
                    db.Masters.Update(master);
                    db.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var master = db.Masters.Find(id);
                if (master != null)
                {
                    db.Masters.Remove(master);
                    db.SaveChanges();
                }
            }
        }
    }
}
