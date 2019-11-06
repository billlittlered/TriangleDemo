using GridLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GridLibrary.Implementations
{
     public class Coordinate : ICoordinate
     {
          public Coordinate(int x, int y)
          {
               X = x;
               Y = y;
          }
          public int X { get; set; }
          public int Y { get; set; }
     }
}
