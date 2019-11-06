using System;
using System.Collections.Generic;
using System.Text;

namespace GridLibrary.Interfaces
{
     public interface ILeftTriangle
     {
          ICoordinate GetBottomLeftOfTriangle(int rowNumber, int column);
          ICoordinate GetBottomRightOfTriangle(int rowNumber, int column);
          Tuple<ICoordinate, ICoordinate, ICoordinate> GetLeftTriangle(int numericalRow, int column);
          ICoordinate GetTopLeftOfTriangle(int numericalRow, int column);
     }
}
