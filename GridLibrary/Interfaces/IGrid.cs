using System;
using System.Collections.Generic;
using System.Text;

namespace GridLibrary.Interfaces
{
     public interface IGrid
     {
          int GetRowNumber(string input);
          Tuple<ICoordinate, ICoordinate, ICoordinate> GetTriangle(string row, int column);
          string GetTriangleFromCoordinates(ICoordinate topLeft, ICoordinate bottomRight, ICoordinate bottomLeft);
          bool IsOdd(int value);
     }
}
