using System;
using System.Collections.Generic;
using System.Text;

namespace GridLibrary.Interfaces
{
     public interface IGrid
     {
          int GetRowNumber(string input);
          Tuple<ICoordinate, ICoordinate, ICoordinate> GetTriangle(string row, int column);
          bool IsOdd(int value);
     }
}
