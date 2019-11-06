using System;
using System.Collections.Generic;
using System.Text;

namespace GridLibrary.Interfaces
{
     public interface IRightTriangle
     {
          ICoordinate GetBottomRightOfTriangle(int numericalRow, int column);
          Tuple<ICoordinate, ICoordinate, ICoordinate> GetRightTriangle(int numericalRow, int column);
          ICoordinate GetTopLeftOfTriangle(int numericalRow, int column);
          ICoordinate GetTopRightOfTriangle(int numericalRow, int column);
     }
}
