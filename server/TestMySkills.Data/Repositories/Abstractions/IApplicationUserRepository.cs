namespace TestMySkills.Data.Repositories.Abstractions
{
    using TestMySkills.Models;

    public interface IApplicationUserRepository : IDeletableEntityRepository<ApplicationUser>
    {
        ApplicationDbContext Context { get; }
    }
}
