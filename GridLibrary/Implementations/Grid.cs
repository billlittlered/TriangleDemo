using GridLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GridLibrary.Implementations
{
     public class Grid : IGrid
     {
          public Tuple<ICoordinate, ICoordinate, ICoordinate> GetTriangle(string row, int column)
          {
               var numericalRow = GetRowNumber(row);

               if (IsOdd(column))
               {
                    LeftTriangle lt = new LeftTriangle();
                    var topLeft = lt.GetTopLeftOfTriangle(numericalRow, column);
                    var bottomRight = lt.GetBottomRightOfTriangle(numericalRow, column);
                    var bottomLeft = lt.GetBottomLeftOfTriangle(numericalRow, column);

                    return new Tuple<ICoordinate, ICoordinate, ICoordinate>(topLeft, bottomRight, bottomLeft);

               }
               else
               {
                    IRightTriangle rt = new RightTriangle();
                    var topLeft = rt.GetTopLeftOfTriangle(numericalRow, column);
                    var topRight = rt.GetTopRightOfTriangle(numericalRow, column);
                    var bottomRight = rt.GetBottomRightOfTriangle(numericalRow, column);

                    return new Tuple<ICoordinate, ICoordinate, ICoordinate>(topLeft, topRight, bottomRight);
               }
          }

          public int GetRowNumber(string input)
          {
               switch (input.ToUpper())
               {
                    case "A": return (int)GridColumn.A;
                    case "B": return (int)GridColumn.B;
                    case "C": return (int)GridColumn.C;
                    case "D": return (int)GridColumn.D;
                    case "E": return (int)GridColumn.E;
                    case "F": return (int)GridColumn.F;
                    default: throw new Exception("Unknown column!");
               }
          }

          public bool IsOdd(int value)
          {
               return value % 2 != 0;
          }
     }
}
