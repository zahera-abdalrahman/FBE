namespace Products.Models.Repositories
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity entity);
        void Update(int Id, TEntity entity);
        void Delete(int Id, TEntity entity);
        TEntity Find(int Id);
        List<TEntity> View();
    }
}
