namespace TestMySkills.WebAPI.App_Start.AutoMapperConfig
{
    using AutoMapper;
    using TestMySkills.Models;
    using TestMySkills.WebAPI.Models;

    public class OrganizationProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Test, TestListViewModel>();
        }
    }
}