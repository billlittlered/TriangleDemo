using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
     [TestClass]
     public class UnitTest1
     {
          private Grid _grid;

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
               var grid = new Grid();
               var input = "A";
               var result = grid.GetRowNumber(input);
               var expected = 1;
               Assert.AreEqual(expected, result);
          }

          [TestMethod]
          public void Test_ColumnD()
          {
               var grid = new Grid();
               var input = "d";
               var result = grid.GetRowNumber(input);
               var expected = 4;
               Assert.AreEqual(expected, result);
          }



          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_A1()
          {
               var row = "A";
               var column = 1;

               var resultsTuple = GetCoordinates(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(1, 1);
               var expectedBottomRight = new Coordinate(10, 10);
               var expectedBottomLeft = new Coordinate(1, 10);

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

               var resultsTuple = GetCoordinates(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(11, 1);
               var expectedBottomRight = new Coordinate(20, 10);
               var expectedBottomLeft = new Coordinate(11, 10);

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

               var resultsTuple = GetCoordinates(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(1, 11);
               var expectedBottomRight = new Coordinate(10, 20);
               var expectedBottomLeft = new Coordinate(1, 20);

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

               var resultsTuple = GetCoordinates(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(11, 11);
               var expectedBottomRight = new Coordinate(20, 20);
               var expectedBottomLeft = new Coordinate(11, 20);

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
               
               var rowNumber = _grid.GetRowNumber(row);

               var expectedResult = _grid.GetTopLeftOfTriangle(rowNumber, column);
               Assert.AreEqual(expectedResult.X, 1);

               column = 3;
               expectedResult = _grid.GetTopLeftOfTriangle(rowNumber, column);
               Assert.AreEqual(expectedResult.X, 11);
          }

          [TestMethod]
          public void Test_LeftTriangle_BottomLeft_XCoordinate()
          {
               var row = "A";
               var column = 1;
               var rowNumber = _grid.GetRowNumber(row);
               var expectedResult = _grid.GetBottomLeftOfTriangle(rowNumber, column);
               Assert.AreEqual(expectedResult.X, 1);

               row = "B";
               rowNumber = _grid.GetRowNumber(row);
               expectedResult = _grid.GetBottomLeftOfTriangle(rowNumber, column);
               Assert.AreEqual(expectedResult.X, 1);
          }

          [TestMethod]
          public void Test_LeftTriangle_BottomLeft_YCoordinate()
          {
               var row = "A";
               var column = 1;
               var rowNumber = _grid.GetRowNumber(row);
               var expectedResult = _grid.GetBottomLeftOfTriangle(rowNumber, column);
               Assert.AreEqual(expectedResult.Y, 10);

               row = "B";
               rowNumber = _grid.GetRowNumber(row);
               expectedResult = _grid.GetBottomLeftOfTriangle(rowNumber, column);
               Assert.AreEqual(expectedResult.Y, 20);
          }

          [TestMethod]
          public void Test_LeftTriangle_BottomRightYCoordinate()
          {
               var row = "A";
               var column = 1;
               var rowNumber = _grid.GetRowNumber(row);
               var expectedResult = _grid.GetBottomRightOfTriangle(rowNumber, column);

               Assert.AreEqual(expectedResult.Y, 10);

               row = "A";
               column = 3;
               rowNumber = _grid.GetRowNumber(row);
               expectedResult = _grid.GetBottomRightOfTriangle(rowNumber, column);
               Assert.AreEqual(expectedResult.Y, 10);

               row = "B";
               column = 1;
               rowNumber = _grid.GetRowNumber(row);
               expectedResult = _grid.GetBottomRightOfTriangle(rowNumber, column);
               Assert.AreEqual(expectedResult.Y, 20);

               row = "B";
               column = 3;
               rowNumber = _grid.GetRowNumber(row);
               expectedResult = _grid.GetBottomRightOfTriangle(rowNumber, column);
               Assert.AreEqual(expectedResult.Y, 20);
          }

          [TestMethod]
          public void Test_LeftTriangle_BottomRightXCoordinate()
          {
               var row = "A";
               var column = 1;
               var rowNumber = _grid.GetRowNumber(row);
               var expectedResult = _grid.GetBottomRightOfTriangle(rowNumber, column);

               Assert.AreEqual(expectedResult.X, 10);

               row = "A";
               column = 3;
               rowNumber = _grid.GetRowNumber(row);
               expectedResult = _grid.GetBottomRightOfTriangle(rowNumber, column);
               Assert.AreEqual(expectedResult.X, 20);

               row = "B";
               column = 1;
               rowNumber = _grid.GetRowNumber(row);
               expectedResult = _grid.GetBottomRightOfTriangle(rowNumber, column);
               Assert.AreEqual(expectedResult.X, 10);

               row = "B";
               column = 3;
               rowNumber = _grid.GetRowNumber(row);
               expectedResult = _grid.GetBottomRightOfTriangle(rowNumber, column);
               Assert.AreEqual(expectedResult.X, 20);
          }

        


          [TestMethod]
          public void Test_LeftTriangle_TopLeftYCoordinate()
          {
               var row = "A";
               var column = 1;
               var rowNumber = _grid.GetRowNumber(row);

               var expectedResult = _grid.GetTopLeftOfTriangle(rowNumber, column);
               Assert.AreEqual(expectedResult.Y, 1);

               row = "B";
               rowNumber = _grid.GetRowNumber(row);
               expectedResult = _grid.GetTopLeftOfTriangle(rowNumber, column);
               Assert.AreEqual(expectedResult.Y, 11);

               row = "D";
               rowNumber = _grid.GetRowNumber(row);
               expectedResult = _grid.GetTopLeftOfTriangle(rowNumber, column);
               Assert.AreEqual(expectedResult.Y, 31);
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

          public Tuple<Coordinate, Coordinate, Coordinate> GetCoordinates(string row, int column)
          {
               var numericalRow = _grid.GetRowNumber(row);
               var remainderResult = column % 2;
               if (remainderResult == 0)
               {
                    //even column
                    throw  new NotImplementedException();
               }
               else
               {
                    //odd column
                    var leftTriangleCoordinates = _grid.GetLeftTriangle(numericalRow, column);
                    return leftTriangleCoordinates;
               }  
          }
     }

     public class Coordinate
     {
          public Coordinate(int x, int y)
          {
               X = x;
               Y = y;
          }
          public int X { get; set; }
          public int Y { get; set; }
     }

     public class Grid
     {
          public Coordinate StartingPoint = new Coordinate(0, 0);
          public int TriangleHeight = 10;
          public int TriangleWidth = 10;

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

          public Coordinate GetTopLeftOfTriangle(int numericalRow, int column)
          {
               var tmpRow = numericalRow - 1;
               var tmpColumn = column - 1;
               // 1 ,1
               // 11,1
               // 21,1
               // 31,1
               // 41,1
               // 51,1

               var x = 0;
               var y = 0;

               if (tmpColumn == 0)
                    x = 1;
               else
               {
                    x = ((tmpColumn / 2) * TriangleWidth) + 1;
               }

               y = (tmpRow * TriangleHeight) + 1;

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
               var tmpColumn = column - 1;
               // 1,10
               // 1,20
               // 1,30
               // 1,40
               // 1,50
               // 1,60

               var x = 0;
               var y = 0;
               x = ((tmpColumn / 2) * TriangleWidth) + 1;
               y = rowNumber * TriangleHeight;

               return new Coordinate(x, y);
          }

          public Coordinate GetBottomRightOfTriangle(int rowNumber, int column)
          {
               var tmpColumn = 0;
               if (IsOdd(column))
               {
                    tmpColumn = (column + 1) / 2;
               }
               // 10,10
               // 20,10

               // 20, 20

               // 10, 20
               // 10, 30

               int x = 0;
               int y = 0;

               while (tmpColumn > 0)
               {
                    x += 10;
                    tmpColumn--;
               }

               while (rowNumber > 0)
               {
                    y += 10;
                    rowNumber--;
               }

               return new Coordinate(x, y);
          }

          public bool IsOdd(int value)
          {
               return value % 2 != 0;
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
