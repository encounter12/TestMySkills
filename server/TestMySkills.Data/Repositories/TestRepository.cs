namespace TestMySkills.Data.Repositories
{
    using TestMySkills.Data.Repositories.Abstractions;
    using TestMySkills.Models;

    public class TestRepository : DeletableEntityRepository<Test>, ITestRepository
    {
        private readonly IApplicationDbContext context;

        public TestRepository(IApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
