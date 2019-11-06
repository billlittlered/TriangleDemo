using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GridLibrary.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TriangleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriangleController : ControllerBase
    {

          private readonly IGrid _grid;
          public TriangleController(IGrid grid)
          {
               _grid = grid;

          }

          // GET: api/Triangle
          [HttpGet]
          public IEnumerable<string> Get()
          {
               return new string[] { "value1", "value2" };
          }

          // GET: api/Triangle/5
          [HttpGet("{id}", Name = "Get")]
          public string Get(int id)
          {
               return "value";
          }

          [HttpGet("GetCoordinates/{row}/{column}")]
          public ActionResult<string> GetCoordinates(string row, int column)
          {
               var results = _grid.GetTriangle(row, column);
               var coord1 = $"({results.Item1.X},{results.Item1.Y})";
               var coord2 = $"({results.Item2.X},{results.Item2.Y})";
               var coord3 = $"({results.Item3.X},{results.Item3.Y})";
               var outString = $"{coord1} - {coord2} - {coord3}";
               return outString;
          }

     }
}
