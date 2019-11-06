using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using GridLibrary;
using GridLibrary.Implementations;
using GridLibrary.Interfaces;

namespace UnitTestProject1
{
     [TestClass]
     public class TriangleTests
     {
          Dictionary<Tuple<int, int, int, int, int, int>, Tuple<string, int>> dic =
                    new Dictionary<Tuple<int, int, int, int, int, int>, Tuple<string, int>>();

          [TestInitialize]
          public void Init()
          {
               List<string> rows = new List<string>() { "A", "B", "C", "D", "E", "F" };
               List<int> columns = new List<int> { 1, 3, 5, 7, 9, 11 };
               LeftTriangle lt = new LeftTriangle();
               IGrid grid = new Grid();
               foreach (var r in rows)
               {
                    foreach (var c in columns)
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
          }


          [TestMethod]
          public void GetTriangleForCoordinates_ShouldResultIn_A1()
          {
               var testTopLeft1 = new Coordinate(0, 0);
               var testBottomRight1 = new Coordinate(10, -10);
               var testBottomLeft1 = new Coordinate(0, -10);
               var testInput1 = new Tuple<int, int, int, int, int, int>(testTopLeft1.X, testTopLeft1.Y, testBottomRight1.X,
                    testBottomRight1.Y, testBottomLeft1.X, testBottomLeft1.Y);
               var triangleCoordinates = dic.GetValueOrDefault(testInput1);
               var resultingRow = triangleCoordinates?.Item1;
               var resultingColumn = triangleCoordinates?.Item2;


               Assert.AreEqual("A", resultingRow);
               Assert.AreEqual(1, resultingColumn);
          }

          [TestMethod]
          public void GetTriangleForCoordinates_ShouldResultIn_F9()
          {
               var testTopLeft1 = new Coordinate(40, -50);
               var testBottomRight1 = new Coordinate(50, -60);
               var testBottomLeft1 = new Coordinate(40, -60);
               var testInput1 = new Tuple<int, int, int, int, int, int>(testTopLeft1.X, testTopLeft1.Y, testBottomRight1.X,
                    testBottomRight1.Y, testBottomLeft1.X, testBottomLeft1.Y);
               var triangleCoordinates = dic.GetValueOrDefault(testInput1);
               var resultingRow = triangleCoordinates?.Item1;
               var resultingColumn = triangleCoordinates?.Item2;


               Assert.AreEqual("F", resultingRow);
               Assert.AreEqual(9, resultingColumn);
          }

          [TestMethod]
          public void GetTriangleForCoordinates_ShouldResultIn_NULL()
          {
               var testTopLeft1 = new Coordinate(90, -50); //This coordinate intentionally does not exist.
               var testBottomRight1 = new Coordinate(50, -60);
               var testBottomLeft1 = new Coordinate(40, -60);
               var testInput1 = new Tuple<int, int, int, int, int, int>(testTopLeft1.X, testTopLeft1.Y, testBottomRight1.X,
                    testBottomRight1.Y, testBottomLeft1.X, testBottomLeft1.Y);
               var triangleCoordinates = dic.GetValueOrDefault(testInput1);
               var resultingRow = triangleCoordinates?.Item1;
               var resultingColumn = triangleCoordinates?.Item2;

               Assert.AreEqual(resultingRow, null);
               Assert.AreEqual(resultingColumn, null);
          }
     }
}
