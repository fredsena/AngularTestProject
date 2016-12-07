using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FredApp.Service;

using FredApp.Common.Models;

namespace FredApp.Api
{
    public class GenreController : ApiController
    {

        GenreService service = new GenreService();

        [HttpGet]
        public IEnumerable<Genre> GetList()
        {
            return service.GetList();
        }


        [HttpPut]
        public IHttpActionResult Update([FromBody] Genre model)
        {
            var result = service.Update(model);

            if (result.Status)
            {
                return Content(HttpStatusCode.Accepted, "Success");
            }

            return Content(HttpStatusCode.NotFound, result.Message);
        }



        [HttpPost]
        public IHttpActionResult Insert([FromBody] Genre model)
        {
            var result = service.Insert(model);

            if (result.Status)
            {
                return Content(HttpStatusCode.OK, "Success");
            }

            return Content(HttpStatusCode.NotFound,  result.Message);
        }




        //// GET: api/Genre
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Genre/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Genre
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Genre/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Genre/5
        //public void Delete(int id)
        //{
        //}
    }
}
