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
               try
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
               catch(Exception ex)
               {
                    return null;
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

          public string GetTriangleFromCoordinates(ICoordinate topLeft, ICoordinate bottomRight, ICoordinate bottomLeft)
          {
               try
               {
                    // First, load all of the possible combinations that exists for "left" triangles.
                    Dictionary<Tuple<int, int, int, int, int, int>, Tuple<string, int>> dic =
                         new Dictionary<Tuple<int, int, int, int, int, int>, Tuple<string, int>>();

                    List<string> rows = new List<string>() { "A", "B", "C", "D", "E", "F" };
                    List<int> columns = new List<int> { 1, 3, 5, 7, 9, 11 };
                    IGrid grid = new Grid();
                    foreach (var r in rows)
                    {
                         foreach (var c in columns)
                         {
                              var results = grid.GetTriangle(r, c);

                              var rcTuple = new Tuple<string, int>(r, c);
                              var topLeftCoordinate = new Coordinate(results.Item1.X, results.Item1.Y);
                              var bottomRightCoordinate = new Coordinate(results.Item2.X, results.Item2.Y);
                              var bottomLeftCoordinate = new Coordinate(results.Item3.X, results.Item3.Y);
                              var coordinateTuple =
                                   new Tuple<Coordinate, Coordinate, Coordinate>(topLeftCoordinate, bottomRightCoordinate, bottomLeftCoordinate);

                              var tmpTuple = new Tuple<int, int, int, int, int, int>(topLeftCoordinate.X, topLeftCoordinate.Y,
                                   bottomRightCoordinate.X, bottomRightCoordinate.Y, bottomLeftCoordinate.X, bottomLeftCoordinate.Y);
                              dic.Add(tmpTuple, rcTuple);
                         }
                    }

                    // Now, actually see if we have one.
                    var userInput = new Tuple<int, int, int, int, int, int>(topLeft.X, topLeft.Y, bottomRight.X, bottomRight.Y,
                         bottomLeft.X, bottomLeft.Y);
                    var triangleCoordinates = dic.GetValueOrDefault(userInput);

                    return (triangleCoordinates == default(Tuple<string, int>))
                         ? "Invalid coordinates. Please try again."
                         : $"{triangleCoordinates.Item1}{triangleCoordinates.Item2}";
               }
               catch(Exception ex)
               {
                    return null;
               }      
          }
     }
}
