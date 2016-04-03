namespace TestMySkills.Tests.App_Start.AutoMapperConfig
{
    using System;
    using System.Linq;
    using AutoMapper;
    using StructureMap.Configuration.DSL;
    using TestMySkills.Models;
    using TestMySkills.WebAPI.Models;

    public class AutoMapperRegistry : Registry
    {
        public AutoMapperRegistry()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Test, TestListViewModel>();
            });

            For<MapperConfiguration>().Use(config);
            For<IMapper>().Use(ctx => ctx.GetInstance<MapperConfiguration>().CreateMapper(ctx.GetInstance));
        }
    }
}
