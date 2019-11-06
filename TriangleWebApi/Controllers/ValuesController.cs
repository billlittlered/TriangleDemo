using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GridLibrary.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace TriangleWebApi.Controllers
{
     [Route("api/[controller]")]
     [ApiController]
     public class ValuesController : ControllerBase
     {
          private readonly IGrid _grid;
          public ValuesController(IGrid grid)
          {
               _grid = grid;
               
          }
          // GET api/values
          [HttpGet]
          public ActionResult<IEnumerable<string>> Get()
          {

               return new string[] { "value1", "value2" };
          }

          // GET api/values/5
          [HttpGet("{id}")]
          public ActionResult<string> Get(int id)
          {
               return "value";
          }

        
     }
}
