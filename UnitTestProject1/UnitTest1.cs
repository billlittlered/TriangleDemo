using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
     [TestClass]
     public class UnitTests_LeftTriangle
     {
          private IGrid _grid;

          [TestInitialize]
          public void Init()
          {
               _grid = new Grid();
          }
          [TestMethod]
          public void Test_EnumA()
          {
               var column = (int)GridColumn.A;
               var expectedColumnNumber = 1;
               Assert.AreEqual(column, expectedColumnNumber);
          }

          [TestMethod]
          public void Test_EnumB()
          {
               var column = (int)GridColumn.B;
               var expectedColumnNumber = 2;
               Assert.AreEqual(column, expectedColumnNumber);
          }

          [TestMethod]
          public void Test_ColumnA()
          {
               var input = "A";
               var result = _grid.GetRowNumber(input);
               var expected = 1;
               Assert.AreEqual(expected, result);
          }

          [TestMethod]
          public void Test_ColumnD()
          {
               var input = "d";
               var result = _grid.GetRowNumber(input);
               var expected = 4;
               Assert.AreEqual(expected, result);
          }



          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_A1()
          {
               var row = "A";
               var column = 1;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(0, 0);
               var expectedBottomRight = new Coordinate(10, -10);
               var expectedBottomLeft = new Coordinate(0, -10);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedBottomRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedBottomRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_A3()
          {
               var row = "A";
               var column = 3;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(10, 0);
               var expectedBottomRight = new Coordinate(20, -10);
               var expectedBottomLeft = new Coordinate(10, -10);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedBottomRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedBottomRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_B1()
          {
               var row = "B";
               var column = 1;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(0, -10);
               var expectedBottomRight = new Coordinate(10, -20);
               var expectedBottomLeft = new Coordinate(0, -20);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedBottomRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedBottomRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_B3()
          {
               var row = "B";
               var column = 3;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(10, -10);
               var expectedBottomRight = new Coordinate(20, -20);
               var expectedBottomLeft = new Coordinate(10, -20);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedBottomRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedBottomRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_F11()
          {
               var row = "F";
               var column = 11;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(50, -50);
               var expectedBottomRight = new Coordinate(60, -60);
               var expectedBottomLeft = new Coordinate(50, -60);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedBottomRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedBottomRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_LeftTriangle_TopLeftXCoordinate()
          {
               var row = "A";
               var column = 1;

               var expectedResult = _grid.GetTriangle(row, column).Item1;
               Assert.AreEqual(expectedResult.X, 0);

               column = 3;
               expectedResult = _grid.GetTriangle(row, column).Item1;
               Assert.AreEqual(expectedResult.X, 10);
          }

          [TestMethod]
          public void Test_LeftTriangle_BottomLeft_XCoordinate()
          {
               var row = "A";
               var column = 1;
               var expectedResult = _grid.GetTriangle(row, column).Item3;
               Assert.AreEqual(expectedResult.X, 0);

               row = "B";
               expectedResult = _grid.GetTriangle(row, column).Item3;
               Assert.AreEqual(expectedResult.X, 0);
          }

          [TestMethod]
          public void Test_LeftTriangle_BottomLeft_YCoordinate()
          {
               var row = "A";
               var column = 1;
               var expectedResult = _grid.GetTriangle(row, column).Item3;
               Assert.AreEqual(expectedResult.Y, -10);

               row = "B";
               expectedResult = _grid.GetTriangle(row, column).Item3;
               Assert.AreEqual(expectedResult.Y, -20);
          }

          [TestMethod]
          public void Test_LeftTriangle_BottomRightYCoordinate()
          {
               var row = "A";
               var column = 1;
               var expectedResult = _grid.GetTriangle(row, column).Item2;

               Assert.AreEqual(expectedResult.Y, -10);

               row = "A";
               column = 3;
               expectedResult = _grid.GetTriangle(row, column).Item2;
               Assert.AreEqual(expectedResult.Y, -10);

               row = "B";
               column = 1;
               expectedResult = _grid.GetTriangle(row, column).Item2;
               Assert.AreEqual(expectedResult.Y, -20);

               row = "B";
               column = 3;
               expectedResult = _grid.GetTriangle(row, column).Item2;
               Assert.AreEqual(expectedResult.Y, -20);
          }

          [TestMethod]
          public void Test_LeftTriangle_BottomRightXCoordinate()
          {
               var row = "A";
               var column = 1;
               var expectedResult = _grid.GetTriangle(row, column).Item2;

               Assert.AreEqual(expectedResult.X, 10);

               row = "A";
               column = 3;
               expectedResult = _grid.GetTriangle(row, column).Item2;
               Assert.AreEqual(expectedResult.X, 20);

               row = "B";
               column = 1;
               expectedResult = _grid.GetTriangle(row, column).Item2;
               Assert.AreEqual(expectedResult.X, 10);

               row = "B";
               column = 3;
               expectedResult = _grid.GetTriangle(row, column).Item2;
               Assert.AreEqual(expectedResult.X, 20);
          }

          [TestMethod]
          public void Test_LeftTriangle_TopLeftYCoordinate()
          {
               var row = "A";
               var column = 1;

               var expectedResult = _grid.GetTriangle(row, column).Item1;
               Assert.AreEqual(expectedResult.Y, 0);

               row = "B";
               expectedResult = _grid.GetTriangle(row, column).Item1;
               Assert.AreEqual(expectedResult.Y, -10);

               row = "D";
               expectedResult = _grid.GetTriangle(row, column).Item1;
               Assert.AreEqual(expectedResult.Y, -30);
          }

          [TestMethod]
          public void TestRemainder()
          {
               var input = 3;
               var expectedRemainder = 1;
               var result = input % 2;

               var evenInput = 4;
               var expectedRemainderEven = 0;
               var evenResult = evenInput % 2;

               var edge1 = 1;
               var expectedEdgeRemainder = 1;
               var edgeResult = edge1 % 2;

               Assert.AreEqual(result, expectedRemainder);
               Assert.AreEqual(evenResult, expectedRemainderEven);
               Assert.AreEqual(edgeResult, expectedEdgeRemainder);
          }

     }

     [TestClass]
     public class UnitTests_RightTriangle
     {
          private IGrid _grid;

          [TestInitialize]
          public void Init()
          {
               _grid = new Grid();
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_A2()
          {
               var row = "A";
               var column = 2;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(0, 0);
               var expectedTopRight = new Coordinate(10, 0);
               var expectedBottomLeft = new Coordinate(10, -10);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedTopRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedTopRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_A4()
          {
               var row = "A";
               var column = 4;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(10, 0);
               var expectedTopRight = new Coordinate(20, 0);
               var expectedBottomLeft = new Coordinate(20, -10);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedTopRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedTopRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_B2()
          {
               var row = "B";
               var column = 2;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(0, -10);
               var expectedTopRight = new Coordinate(10, -10);
               var expectedBottomLeft = new Coordinate(10, -20);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedTopRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedTopRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_C2()
          {
               var row = "C";
               var column = 2;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(0, -20);
               var expectedTopRight = new Coordinate(10, -20);
               var expectedBottomLeft = new Coordinate(10, -30);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedTopRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedTopRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_B4()
          {
               var row = "B";
               var column = 4;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(10, -10);
               var expectedTopRight = new Coordinate(20, -10);
               var expectedBottomLeft = new Coordinate(20, -20);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedTopRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedTopRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_F12()
          {
               var row = "F";
               var column = 12;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(50, -50);
               var expectedTopRight = new Coordinate(60, -50);
               var expectedBottomLeft = new Coordinate(60, -60);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedTopRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedTopRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

     }

     public interface ICoordinate
     {
          int X { get; set; }
          int Y { get; set; }
     }

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

     public interface IGrid
     {
          int GetRowNumber(string input);
          Tuple<Coordinate, Coordinate, Coordinate> GetTriangle(string row, int column);
          bool IsOdd(int value);
     }

     public class Grid : IGrid
     {
          public Tuple<Coordinate, Coordinate, Coordinate> GetTriangle(string row, int column)
          {
               var numericalRow = GetRowNumber(row);

               if (IsOdd(column))
               {
                    LeftTriangle lt = new LeftTriangle();
                    var topLeft = lt.GetTopLeftOfTriangle(numericalRow, column);
                    var bottomRight = lt.GetBottomRightOfTriangle(numericalRow, column);
                    var bottomLeft = lt.GetBottomLeftOfTriangle(numericalRow, column);

                    return new Tuple<Coordinate, Coordinate, Coordinate>(topLeft, bottomRight, bottomLeft);

               }
               else
               {
                    RightTriangle rt = new RightTriangle();
                    var topLeft = rt.GetTopLeftOfTriangle(numericalRow, column);
                    var topRight = rt.GetTopRightOfTriangle(numericalRow, column);
                    var bottomRight = rt.GetBottomRightOfTriangle(numericalRow, column);

                    return new Tuple<Coordinate, Coordinate, Coordinate>(topLeft, topRight, bottomRight);
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

     public static class Constants
     {
          public static int TriangleHeight = 10;
          public static int TriangleWidth = 10;
     }
     public class LeftTriangle
     {
          public Coordinate GetTopLeftOfTriangle(int numericalRow, int column)
          {
               var tmpColumn = column - 1;

               int x, y;

               x = (tmpColumn / 2) * Constants.TriangleWidth;

               y = ((numericalRow * 10) - 10) * -1;

               return new Coordinate(x, y);
          }

          public Tuple<Coordinate, Coordinate, Coordinate> GetLeftTriangle(int numericalRow, int column)
          {
               var topLeft = GetTopLeftOfTriangle(numericalRow, column);
               var bottomRight = GetBottomRightOfTriangle(numericalRow, column);
               var bottomLeft = GetBottomLeftOfTriangle(numericalRow, column);

               return new Tuple<Coordinate, Coordinate, Coordinate>(topLeft, bottomRight, bottomLeft);
          }

          public  Coordinate GetBottomLeftOfTriangle(int rowNumber, int column)
          {
               int x, y;

               x = ((column - 1) / 2) * 10;
               y = (rowNumber * -10);

               return new Coordinate(x, y);
          }

          public Coordinate GetBottomRightOfTriangle(int rowNumber, int column)
          {
               int x, y;

               x = (((column - 1) / 2) * 10) + 10;
               y = (rowNumber * -10);

               return new Coordinate(x, y);
          }

     }

     public class RightTriangle
     {
          public Tuple<Coordinate, Coordinate, Coordinate> GetRightTriangle(int numericalRow, int column)
          {
               var topLeft = GetTopLeftOfTriangle(numericalRow, column);
               var topRight = GetTopRightOfTriangle(numericalRow, column);
               var bottomRight = GetBottomRightOfTriangle(numericalRow, column);
               

               return new Tuple<Coordinate, Coordinate, Coordinate>(topLeft, topRight, bottomRight);
          }

          public Coordinate GetBottomRightOfTriangle(int numericalRow, int column)
          {
               int x;
               int y;

               x = (((column - 1) / 2) * 10) + 10;
               y = (numericalRow * -10);

               return new Coordinate(x, y);
          }

          public Coordinate GetTopRightOfTriangle(int numericalRow, int column)
          {
               int x;
               int y;

               x = (column / 2)  * 10;
               y = (numericalRow - 1) * -10;
               return new Coordinate(x, y);
          }

          public Coordinate GetTopLeftOfTriangle(int numericalRow, int column)
          {
               var tmpColumn = column - 1;

               int x, y;

               x = (tmpColumn / 2) * Constants.TriangleWidth;

               y = ((numericalRow * 10) - 10) * -1;

               return new Coordinate(x, y);
          }
     }

     [TestClass]
     public class UnitTests_Triangle
     {
          [TestMethod]
          public void GetTriangleForCoordinates()
          {
               Dictionary<Tuple<int, int, int, int, int, int>, Tuple<string, int>> dic =
                    new Dictionary<Tuple<int, int, int, int, int, int>, Tuple<string, int>>();

               List<string> rows = new List<string>() { "A", "B", "C", "D", "E", "F" };
               List<int> columns = new List<int> { 1, 3,  5, 7, 9, 11};
               LeftTriangle lt = new LeftTriangle();
               IGrid grid = new Grid();
               foreach(var r in rows)
               {
                    foreach(var c in columns)
                    {
                         var results = grid.GetTriangle(r, c);

                         //create tuple here and add results along with R & C to that
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

               var testTopLeft1 = new Coordinate(0, 0);
               var testBottomRight1 = new Coordinate(10, -10);
               var testBottomLeft1 = new Coordinate(0, -10);
               var testInput1 = new Tuple<int, int, int, int, int, int>(testTopLeft1.X, testTopLeft1.Y, testBottomRight1.X,
                    testBottomRight1.Y, testBottomLeft1.X, testBottomLeft1.Y);
               var triangleCoordinates = dic.GetValueOrDefault(testInput1);
               var resultingRow = triangleCoordinates.Item1;
               var resultingColumn = triangleCoordinates.Item2;


               Assert.AreEqual("A", resultingRow);
               Assert.AreEqual(1, resultingColumn);





               testTopLeft1 = new Coordinate(40, -50);
               testBottomRight1 = new Coordinate(50, -60);
               testBottomLeft1 = new Coordinate(40, -60);
               testInput1 = new Tuple<int, int, int, int, int, int>(testTopLeft1.X, testTopLeft1.Y, testBottomRight1.X,
                    testBottomRight1.Y, testBottomLeft1.X, testBottomLeft1.Y);
               triangleCoordinates = dic.GetValueOrDefault(testInput1);
               resultingRow = triangleCoordinates.Item1;
               resultingColumn = triangleCoordinates.Item2;


               Assert.AreEqual("F", resultingRow);
               Assert.AreEqual(9, resultingColumn);

          }
     }


     public enum GridColumn
     {
          A = 1,
          B = 2,
          C = 3,
          D = 4,
          E = 5,
          F = 6
     }
}
