/**
* Refactor the Shape class to respect object orientation principles. What happens if a new language needs to be supported
* such as French, or if we need to support more shapes?
*
* You can make any change you see fit, in code or tests.
*/

using System;
using System.Collections.Generic;

namespace RefactoringGeometricalShapes
{
  public class Shape
  {
    //TODO add more shapes if needed
    public const int SQUARE = 1;
    public const int CIRCLE = 2;
    public const int EQUILATERAL_TRIANGLE = 3;
    public static int EN = 1;
    /**
   * The shape's immutable width.
   */
    private readonly double width;
    public int type = -1;

    /**
   * Constructs a new Shape with the specified width
   *
   * @param type the type of the shape (SQUARE/CIRCLE/EQUILATERAL_TRIANGLE).
   * @param width the width of the shape
   */

    public Shape(int type, double width)
    {
      this.type = type;
      this.width = width;
    }

    /**
   * This method generates a HTML string used to be displayed as a web page
   * The generated string depends on the language of the user
   *
   * @param shapes
   * @param userLanguage
   * @return html
   *
   */

    public static String prettyPrint(List<Shape> shapes, int userLanguage)
    {
      String returnString = "";

      // test list is empty
      if (shapes.Count == 0)
      {
        if (userLanguage == EN)
        {
          returnString = "<h1>Empty list of shapes!</h1>";
        }
        else
        {
          // default is dutch
            returnString = "<h1>Lege lijst van vormen!</h1>";
        }
      }
      else
      {
        //we have shapes
        //header
        if (userLanguage == EN)
        {
          returnString += "<h1>Shapes report</h1><br/>";
        }
        else
        {
          // default is dutch
            returnString += "<h1>Samenvatting vormen</h1><br/>";
        }

        int numberSquares = 0;
        int numberCircles = 0;
        int numberTriangles = 0;

        double areaSquares = 0;
        double areaCircles = 0;
        double areaTriangles = 0;

        double perimeterSquares = 0;
        double perimeterCircles = 0;
        double perimeterTriangles = 0;

        //compute numbers
        for (int i = 0; i < shapes.Count; i++)
        {
          if (shapes[i].type == SQUARE)
          {
            numberSquares++;
            areaSquares += shapes[i].getArea();
            perimeterSquares += shapes[i].getPerimeter();
          }
          if (shapes[i].type == CIRCLE)
          {
            numberCircles++;
            areaCircles += shapes[i].getArea();
            perimeterCircles += shapes[i].getPerimeter();
          }
          if (shapes[i].type == EQUILATERAL_TRIANGLE)
          {
            numberTriangles++;
            areaTriangles += shapes[i].getArea();
            perimeterTriangles += shapes[i].getPerimeter();
          }
        }

        //let`s print this
        returnString += getLine(numberSquares, areaSquares, perimeterSquares, SQUARE, userLanguage);
        returnString += getLine(numberCircles, areaCircles, perimeterCircles, CIRCLE, userLanguage);
        returnString += getLine(numberTriangles, areaTriangles, perimeterTriangles, EQUILATERAL_TRIANGLE, userLanguage);

        //footer
        returnString += "TOTAL:<br/>";
        returnString += (numberCircles + numberSquares + numberTriangles) + " " +
                        (userLanguage == EN ? "shapes" : "vormen") + " ";
        returnString += (userLanguage == EN ? "Perimeter " : "Omtrek ") +
                        (perimeterCircles + perimeterSquares + perimeterTriangles).ToString("#.##") + " ";
        returnString += (userLanguage == EN ? "Area " : "Oppervlakte ") +
                        (areaCircles + areaSquares + areaTriangles).ToString("#.##");
      }


      return returnString;
    }

    private static String getLine(int numberShapes, double area, double perimeter, int type, int userLanguage)
    {
      if (numberShapes > 0)
      {
        if (userLanguage == EN)
        {
          return numberShapes + " " + translateShape(type, numberShapes, userLanguage) + " Area " + area.ToString("#.##") +
                 " Perimeter " + perimeter.ToString("#.##") + "<br/>";
        }
        return numberShapes + " " + translateShape(type, numberShapes, userLanguage) + " Oppervlakte " + area.ToString("#.##") +
               " Omtrek " + perimeter.ToString("#.##") + "<br/>";
      }
      return "";
    }

    private static String translateShape(int type, int numberShapes, int userLanguage)
    {
      switch (type)
      {
        case SQUARE:
          if (userLanguage == EN)
          {
            return numberShapes == 1 ? "Square" : "Squares";
          }
          else
          {
            return numberShapes == 1 ? "Vierkant" : "Vierkanten";
          }
        case CIRCLE:
          if (userLanguage == EN)
          {
            return numberShapes == 1 ? "Circle" : "Circles";
          }
          else
          {
            return numberShapes == 1 ? "Cirkel" : "Cirkels";
          }
        case EQUILATERAL_TRIANGLE:
          if (userLanguage == EN)
          {
            return numberShapes == 1 ? "Triangle" : "Triangles";
          }
          else
          {
            return numberShapes == 1 ? "Driehoek" : "Driehoeken";
          }
      }
      return "";
    }

    /**
   * Returns the width of this Shape in double precision.
   *
   * @return the width of this Shape.
   */

    public double getWidth()
    {
      return width;
    }

    /**
   * Returns the area of this Shape in double precision.
   *
   * @return the area of this Shape.
   */

    public double getArea()
    {
      switch (type)
      {
        case SQUARE:
          return width * width;
        case CIRCLE:
          return Math.PI * (width / 2) * (width / 2);
        case EQUILATERAL_TRIANGLE:
          return (Math.Sqrt(3) / 4) * width * width;
      }
      throw new SystemException("Can`t compute area of unknown shape");
    }

    /**
   * Returns the perimeter of this Shape in double precision.
   *
   * @return the perimeter of this Shape.
   */

    public double getPerimeter()
    {
      switch (type)
      {
        case SQUARE:
          return 4 * width;
        case CIRCLE:
          return Math.PI * width;
        case EQUILATERAL_TRIANGLE:
          return 3 * width;
      }
      throw new SystemException("Can`t compute area of unknown shape");
    }
  }
}