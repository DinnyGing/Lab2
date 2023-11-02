using Lab2.Db;
using Lab2.DTO;
using Lab2.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2.Repositories
{
    public class ProcedureRepository
    {
        public List<Procedure> GetAll()
        {
            List<Procedure> procedures;
            using (ApplicationContext db = new ApplicationContext())
            {
                procedures = db.Procedures.ToList();
            }
            return procedures;
        }
        public string GetCategoryNameByProcedureId(int id)
        {
            string name;
            using (ApplicationContext db = new ApplicationContext())
            {
                var procedure = db.Procedures.Include(p => p.Category).FirstOrDefault(p => p.ProcedureId == id);
                name = procedure.Category.Name;
            }
            return name;
        }
        public List<ProcedureDTO> GetFilteredProcedures(Func<ProcedureDTO, bool>[] filters)
        {
            var procedures = GetAllWithCategoryName();

            foreach (var filter in filters)
            {
                procedures = procedures.Where(filter).ToList();
            }

            return procedures;
        }
        public List<ProcedureDTO> GetAllWithCategoryName()
        {
            List<ProcedureDTO> procedures;
            using (ApplicationContext db = new ApplicationContext())
            {
                var query = from procedure in db.Procedures
                            select new ProcedureDTO()
                            {
                                ProcedureId = procedure.ProcedureId,
                                Name = procedure.Name,
                                Description = procedure.Description,
                                Price = procedure.Price,
                                CategoryName = procedure.Category.Name
                            };
                procedures = query.ToList();
            }
            return procedures;
        }
        public Procedure GetById(int id)
        {
            Procedure procedure;
            using (ApplicationContext db = new ApplicationContext())
            {
                procedure = db.Procedures.FirstOrDefault(p => p.ProcedureId == id);
            }
            return procedure;
        }
        public void Create(Procedure procedure, Category category)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (procedure != null)
                {
                    db.Categories.Attach(category);
                    db.Procedures.Add(procedure);
                    db.SaveChanges();
                }
            }
        }
        public void Update(Procedure procedure, Category category)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (procedure != null)
                {
                    db.Categories.Attach(category);
                    db.Procedures.Update(procedure);
                    db.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var procedure = db.Procedures.Find(id);
                if (procedure != null)
                {
                    db.Procedures.Remove(procedure);
                    db.SaveChanges();
                }
            }
        }
    }
}
