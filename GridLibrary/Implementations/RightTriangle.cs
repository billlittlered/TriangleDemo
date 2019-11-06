using GridLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GridLibrary.Implementations
{
     public class RightTriangle : IRightTriangle
     {
          public Tuple<ICoordinate, ICoordinate, ICoordinate> GetRightTriangle(int numericalRow, int column)
          {
               var topLeft = GetTopLeftOfTriangle(numericalRow, column);
               var topRight = GetTopRightOfTriangle(numericalRow, column);
               var bottomRight = GetBottomRightOfTriangle(numericalRow, column);


               return new Tuple<ICoordinate, ICoordinate, ICoordinate>(topLeft, topRight, bottomRight);
          }

          public ICoordinate GetBottomRightOfTriangle(int numericalRow, int column)
          {
               int x;
               int y;

               x = (((column - 1) / 2) * 10) + 10;
               y = (numericalRow * -10);

               return new Coordinate(x, y);
          }

          public ICoordinate GetTopRightOfTriangle(int numericalRow, int column)
          {
               int x;
               int y;

               x = (column / 2) * 10;
               y = (numericalRow - 1) * -10;
               return new Coordinate(x, y);
          }

          public ICoordinate GetTopLeftOfTriangle(int numericalRow, int column)
          {
               var tmpColumn = column - 1;

               int x, y;

               x = (tmpColumn / 2) * Constants.TriangleWidth;

               y = ((numericalRow * 10) - 10) * -1;

               return new Coordinate(x, y);
          }
     }
}
