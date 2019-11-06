using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GridLibrary;
using GridLibrary.Implementations;
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


          [HttpGet("GetCoordinates/{row}/{column}")]
          public ActionResult<string> GetCoordinates(string row, int column)
          {
               var results = _grid.GetTriangle(row, column);
               if (results == null)
                    return Constants.GetCoordinates_BadInput;

               var coord1 = $"({results.Item1.X},{results.Item1.Y})";
               var coord2 = $"({results.Item2.X},{results.Item2.Y})";
               var coord3 = $"({results.Item3.X},{results.Item3.Y})";
               var outString = $"{coord1} - {coord2} - {coord3}";
               return outString;
          }

          [HttpGet("GetTriangle/{coordinates}")]
          public ActionResult<string> GetTriangle(string coordinates)
          {
               try
               {
                    var groups = coordinates.Split('=');
                    var topLeftX = groups[0].Split(',')[0];
                    var topLeftY = groups[0].Split(',')[1];
                    var bottomRightX = groups[1].Split(',')[0];
                    var bottomRightY = groups[1].Split(',')[1];
                    var bottomLeftX = groups[2].Split(',')[0];
                    var bottomLeftY = groups[2].Split(',')[1];

                    var topLeft = new Coordinate(Convert.ToInt32(topLeftX), Convert.ToInt32(topLeftY));
                    var bottomRight = new Coordinate(Convert.ToInt32(bottomRightX), Convert.ToInt32(bottomRightY));
                    var bottomLeft = new Coordinate(Convert.ToInt32(bottomLeftX), Convert.ToInt32(bottomLeftY));

                    var triangleLocation = _grid.GetTriangleFromCoordinates(topLeft, bottomRight, bottomLeft);
                    return triangleLocation == null ? Constants.GetTriangle_InvalidInput : (ActionResult<string>)triangleLocation;
               }
               catch (Exception ex)
               {
                    return Constants.GetTriangle_BadlyFormattedInputed;
               }
               
          }

     }
}
