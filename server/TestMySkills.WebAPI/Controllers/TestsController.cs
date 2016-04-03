using AutoMapper.QueryableExtensions;
using TestMySkills.WebAPI.Models;

namespace TestMySkills.WebAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Web;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using System.Web.Http.Description;
    using AutoMapper;
    using TestMySkills.Data.Repositories;
    using TestMySkills.Data.Repositories.Abstractions;
    using TestMySkills.Models;

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TestsController : ApiController
    {
        private readonly ITestRepository testRepository;

        private readonly MapperConfiguration config;

        private readonly IMapper mapper;

        public TestsController(ITestRepository testRepository, MapperConfiguration config, IMapper mapper)
        {
            this.testRepository = testRepository;
            this.config = config;
            this.mapper = mapper;
        }

        [ResponseType(typeof(Test))]
        public IHttpActionResult Get()
        {
            try
            {
                var tests = testRepository.All().ProjectTo<TestListViewModel>(config);

                return Ok(tests);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        //public HttpResponseMessage Get()
        //{
        //    string filePath = HttpContext.Current.Server.MapPath(@"~/App_Data/tests.json");

        //    string tests = File.ReadAllText(filePath);

        //    return new HttpResponseMessage()
        //    {
        //        Content = new StringContent(tests)
        //    };
        //}

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
