using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sbsfinal01.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            // 필요한 DB 작업

            return new string[] { "valueSBS", "valueMBC" };
        }

        // GET api/values/5
        public string Get(string id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            //Swrite 쓰기 작업 수행

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
