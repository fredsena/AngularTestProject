﻿using System;
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
