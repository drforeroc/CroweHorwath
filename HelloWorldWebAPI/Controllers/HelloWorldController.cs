using HelloWorldAPI.Entities;
using HelloWorldAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldWebAPI.Controllers
{
    public class HelloWorldController : ApiController
    {
        ReadService readService;
        MessageDto message;

        public HelloWorldController()
        {
            readService = new ReadService();            
            message = readService.Read();
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { message.Message };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return message.Message;
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
