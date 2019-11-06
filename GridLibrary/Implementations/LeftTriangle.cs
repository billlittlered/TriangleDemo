using GridLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GridLibrary.Implementations
{
     public class LeftTriangle : ILeftTriangle
     {
          public ICoordinate GetTopLeftOfTriangle(int numericalRow, int column)
          {
               var tmpColumn = column - 1;

               int x, y;

               x = (tmpColumn / 2) * Constants.TriangleWidth;

               y = ((numericalRow * 10) - 10) * -1;

               return new Coordinate(x, y);
          }

          public Tuple<ICoordinate, ICoordinate, ICoordinate> GetLeftTriangle(int numericalRow, int column)
          {
               var topLeft = GetTopLeftOfTriangle(numericalRow, column);
               var bottomRight = GetBottomRightOfTriangle(numericalRow, column);
               var bottomLeft = GetBottomLeftOfTriangle(numericalRow, column);

               return new Tuple<ICoordinate, ICoordinate, ICoordinate>(topLeft, bottomRight, bottomLeft);
          }

          public ICoordinate GetBottomLeftOfTriangle(int rowNumber, int column)
          {
               int x, y;

               x = ((column - 1) / 2) * 10;
               y = (rowNumber * -10);

               return new Coordinate(x, y);
          }

          public ICoordinate GetBottomRightOfTriangle(int rowNumber, int column)
          {
               int x, y;

               x = (((column - 1) / 2) * 10) + 10;
               y = (rowNumber * -10);

               return new Coordinate(x, y);
          }

     }
}
