namespace TestMySkills.Data.Repositories
{
    using TestMySkills.Data.Repositories.Abstractions;
    using TestMySkills.Models;

    public class ApplicationUserRepository : DeletableEntityRepository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly IApplicationDbContext context;

        public ApplicationUserRepository(IApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public ApplicationDbContext Context
        {
            get
            {
                return (ApplicationDbContext)this.context;
            }
        }
    }
}
