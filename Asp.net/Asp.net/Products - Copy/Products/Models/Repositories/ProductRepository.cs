using Microsoft.EntityFrameworkCore;
using Products.Data;
using System;

namespace Products.Models.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        public ApplicationDbContext Db { get; }
        public ProductRepository(ApplicationDbContext _db)
        {
            Db = _db;
        }

        public void Add(Product entity)
        {
            Db.Product.Add(entity);
            Db.SaveChanges();
        }

        public void Delete(int Id, Product entity)
        {
            var data = Find(Id);
            Db.Product.Remove(data);
            Db.SaveChanges();
        }

        public Product Find(int Id)
        {
            var data = Db.Product.SingleOrDefault(x => x.ProductId == Id);
            return data;
        }

        public void Update(int Id, Product entity)
        {
            Db.Product.Update(entity);
            Db.SaveChanges();
        }

        public List<Product> View()
        {
            return Db.Product.Include(x => x.Category).ToList();

        }
    }
}
