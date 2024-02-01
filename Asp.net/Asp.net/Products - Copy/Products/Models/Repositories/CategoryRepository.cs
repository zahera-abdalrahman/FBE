using Products.Data;
using System;

namespace Products.Models.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        public ApplicationDbContext Db { get; }

        public CategoryRepository(ApplicationDbContext _db)
        {
            Db = _db;
        }

        public void Add(Category entity)
        {
            Db.Category.Add(entity);
            Db.SaveChanges();
        }

        public void Delete(int Id, Category entity)
        {
            var data = Find(Id);
            Db.Category.Remove(data);
            Db.SaveChanges();
        }

        public Category Find(int Id)
        {
            var data = Db.Category.SingleOrDefault(x => x.CategoryId == Id);
            return data;
        }

        public void Update(int Id, Category entity)
        {
            Db.Category.Update(entity);
            Db.SaveChanges();
        }

        public List<Category> View()
        {
            return Db.Category.ToList();
        }
    }
}
