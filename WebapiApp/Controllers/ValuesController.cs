using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebapiApp.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public List<Model> Get()
        {

            return new List<Model>
           {
               new Model{Text="", Value="0"},
               new Model{Text="Y", Value="1"},
               new Model{Text="N", Value="2"}
           };
        }
        public class Model {
            public string Value { get; set; }
            public string Text { get; set; }

        }

        // GET api/values/5
        public object Get(int id)
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
