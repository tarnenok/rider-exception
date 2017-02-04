using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace RiderWebException.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            throw new Exception();
            return new string[] {"value1", "value2"};
        }
    }
}