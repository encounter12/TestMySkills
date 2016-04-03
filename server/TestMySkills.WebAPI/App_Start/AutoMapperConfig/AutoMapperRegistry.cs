namespace TestMySkills.WebAPI.App_Start.AutoMapperConfig
{
    using System;
    using System.Linq;
    using AutoMapper;
    using StructureMap.Configuration.DSL;

    public class AutoMapperRegistry : Registry
    {
        public AutoMapperRegistry()
        {
            var profiles = from t in typeof (AutoMapperRegistry).Assembly.GetTypes()
                           where typeof (Profile).IsAssignableFrom(t)
                           select (Profile)Activator.CreateInstance(t);

            var config = new MapperConfiguration(cfg =>
            {
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(profile);
                }
            });


            For<MapperConfiguration>().Use(config);
            For<IMapper>().Use(ctx => ctx.GetInstance<MapperConfiguration>().CreateMapper(ctx.GetInstance));
        }
    }
}