namespace TestMySkills.Data.Repositories.Abstractions
{
    using System.Linq;

    public interface IDeletableEntityRepository<T> : IGenericRepository<T> where T : class
    {
        IQueryable<T> AllWithDeleted();

        void HardDelete(T entity);
    }
}
