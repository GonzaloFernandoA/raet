using System.Collections.Generic;
using NUnit.Framework;

namespace RefactoringGeometricalShapes
{
  [TestFixture]
  public class ShapeTest
  {

    [Test]
    public void testReportForEmptyListOfShapes()
    {
      Assert.AreEqual("<h1>Lege lijst van vormen!</h1>", Shape.prettyPrint(new List<Shape>(), 0));
    }

    [Test]
    public void testReportForEmptyListOfShapesAndEnglishLanguage()
    {
      Assert.AreEqual("<h1>Empty list of shapes!</h1>", Shape.prettyPrint(new List<Shape>(), 1));
    }

    [Test]
    public void testReportForOneSquare()
    {
      List<Shape> shapes = new List<Shape>();
      shapes.Add(new Shape(Shape.SQUARE, 1));
      Assert.AreEqual("<h1>Samenvatting vormen</h1><br/>1 Vierkant Oppervlakte 1 Omtrek 4<br/>TOTAL:<br/>1 vormen Omtrek 4 Oppervlakte 1", Shape.prettyPrint(shapes, 0));
    }

    [Test]
    public void testReportForMoreSquares()
    {
      List<Shape> shapes = new List<Shape>();
      shapes.Add(new Shape(Shape.SQUARE, 1));
      shapes.Add(new Shape(Shape.SQUARE, 2));
      Assert.AreEqual("<h1>Samenvatting vormen</h1><br/>2 Vierkanten Oppervlakte 5 Omtrek 12<br/>TOTAL:<br/>2 vormen Omtrek 12 Oppervlakte 5", Shape.prettyPrint(shapes, 0));
    }

    [Test]
    public void testReportForMoreShapes()
    {
      List<Shape> shapes = new List<Shape>();
      shapes.Add(new Shape(Shape.CIRCLE, 1));
      shapes.Add(new Shape(Shape.SQUARE, 1));
      shapes.Add(new Shape(Shape.EQUILATERAL_TRIANGLE, 2));
      shapes.Add(new Shape(Shape.SQUARE, 2));
      shapes.Add(new Shape(Shape.SQUARE, 3));
      shapes.Add(new Shape(Shape.CIRCLE, 2));
      Assert.AreEqual("<h1>Samenvatting vormen</h1><br/>3 Vierkanten Oppervlakte 14 Omtrek 24<br/>2 Cirkels Oppervlakte 3,93 Omtrek 9,42<br/>1 Driehoek Oppervlakte 1,73 Omtrek 6<br/>TOTAL:<br/>6 vormen Omtrek 39,42 Oppervlakte 19,66", Shape.prettyPrint(shapes, 0));
    }

    [Test]
    public void testReportForMoreShapesAndEnglishLanguage()
    {
      List<Shape> shapes = new List<Shape>();
      shapes.Add(new Shape(Shape.CIRCLE, 1));
      shapes.Add(new Shape(Shape.SQUARE, 1));
      shapes.Add(new Shape(Shape.EQUILATERAL_TRIANGLE, 2));
      shapes.Add(new Shape(Shape.SQUARE, 2));
      shapes.Add(new Shape(Shape.SQUARE, 3));
      shapes.Add(new Shape(Shape.CIRCLE, 2));
      Assert.AreEqual("<h1>Shapes report</h1><br/>3 Squares Area 14 Perimeter 24<br/>2 Circles Area 3,93 Perimeter 9,42<br/>1 Triangle Area 1,73 Perimeter 6<br/>TOTAL:<br/>6 shapes Perimeter 39,42 Area 19,66", Shape.prettyPrint(shapes, 1));
    }
  }
}
