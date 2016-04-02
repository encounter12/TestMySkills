namespace TestMySkills.WebAPI.Controllers
{
    using System.IO;
    using System.Net.Http;
    using System.Web;
    using System.Web.Http;
    using System.Web.Http.Cors;

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TestsController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get()
        {
            string filePath = HttpContext.Current.Server.MapPath(@"~/App_Data/tests.json");

            string tests = File.ReadAllText(filePath);

            return new HttpResponseMessage()
            {
                Content = new StringContent(tests)
            };
        }

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
