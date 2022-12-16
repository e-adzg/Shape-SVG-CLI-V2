using static System.Console;
//I can pass in the type of style into the shape factory and go from here
public class ShapeFactory
{
    public List<Shape> generateShape(string typeOfShape, string userStyle, List<Shape> shapes)
    {
        if (typeOfShape == "rectangle")                                                                     //^   RECTANGLE
        {
            if (userStyle == "R")
            {
                shapes.Add(new Rectangle(RandomNumber(0, 400), RandomNumber(0, 400), RandomNumber(0, 400), RandomNumber(0, 400), RandomColour(), RandomColour(), RandomNumber(0, 5), RandomDouble(0, 1), RandomDouble(0, 1))); //this will add all the variables to the list
                return shapes;
            }
            else
            {
                ForegroundColor = ConsoleColor.Blue; WriteLine("\nSet the height:"); ResetColor();
                string? userHeight = ReadLine();
                ForegroundColor = ConsoleColor.Blue; WriteLine("Set the width:"); ResetColor();
                string? userWidth = ReadLine();
                ForegroundColor = ConsoleColor.Blue; WriteLine("Set the X:"); ResetColor();
                string? userRecX = ReadLine();
                ForegroundColor = ConsoleColor.Blue; WriteLine("Set the Y:"); ResetColor();
                string? userRecY = ReadLine();

                if (userStyle == "M")
                {
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Fill Colour:"); ResetColor();
                    string? userFill = ReadLine();
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Colour:"); ResetColor();
                    string? userRecStrokeColour = ReadLine();
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Width:"); ResetColor();
                    string? userRecStrokeWidth = ReadLine();
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Fill Opacity:"); ResetColor();
                    string? userRecFillOpacity = ReadLine();
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Opacity:"); ResetColor();
                    string? userRecStrokeOpacity = ReadLine();
                    shapes.Add(new Rectangle(userRecX, userRecY, userHeight, userWidth, userFill, userRecStrokeColour, userRecStrokeWidth, userRecFillOpacity, userRecStrokeOpacity)); //this will add all the variables to the list
                    return shapes;
                }
                else if (userStyle == "1")
                {
                    string? userFill = "blue";
                    string? userRecStrokeColour = "pink";
                    string? userRecStrokeWidth = "5";
                    string? userRecFillOpacity = "0.1";
                    string? userRecStrokeOpacity = "0.9";
                    shapes.Add(new Rectangle(userRecX, userRecY, userHeight, userWidth, userFill, userRecStrokeColour, userRecStrokeWidth, userRecFillOpacity, userRecStrokeOpacity)); //this will add all the variables to the list
                    return shapes;
                }
                else if (userStyle == "2")
                {
                    string? userFill = "red";
                    string? userRecStrokeColour = "black";
                    string? userRecStrokeWidth = "5";
                    string? userRecFillOpacity = "1";
                    string? userRecStrokeOpacity = "0.5";
                    shapes.Add(new Rectangle(userRecX, userRecY, userHeight, userWidth, userFill, userRecStrokeColour, userRecStrokeWidth, userRecFillOpacity, userRecStrokeOpacity)); //this will add all the variables to the list
                    return shapes;
                }
                else if (userStyle == "3")
                {
                    string? userFill = "lime";
                    string? userRecStrokeColour = "black";
                    string? userRecStrokeWidth = "5";
                    string? userRecFillOpacity = "1";
                    string? userRecStrokeOpacity = "0.9";
                    shapes.Add(new Rectangle(userRecX, userRecY, userHeight, userWidth, userFill, userRecStrokeColour, userRecStrokeWidth, userRecFillOpacity, userRecStrokeOpacity)); //this will add all the variables to the list
                    return shapes;
                }
            }
        }
        else if (typeOfShape == "circle")                                                           //^   CIRCLE
        {
            if (userStyle == "R")
            {
                shapes.Add(new Circle(RandomNumber(0, 400), RandomNumber(0, 400), RandomNumber(0, 400), RandomColour(), RandomDouble(0, 1), RandomColour()));
                return shapes;
            }
            else
            {
                ForegroundColor = ConsoleColor.Blue; WriteLine("\nSet the radius:"); ResetColor();
                string? userCr = ReadLine();
                ForegroundColor = ConsoleColor.Blue; WriteLine("Set the circle X:"); ResetColor();
                string? userCx = ReadLine();
                ForegroundColor = ConsoleColor.Blue; WriteLine("Set the circle Y:"); ResetColor();
                string? userCy = ReadLine();

                if (userStyle == "M")
                {
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Colour:"); ResetColor();
                    string? userCircleStroke = ReadLine();
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Width:"); ResetColor();
                    string? userCircleStrokeWidth = ReadLine();
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Fill Colour:"); ResetColor();
                    string? userCircleFill = ReadLine();
                    shapes.Add(new Circle(userCr, userCx, userCy, userCircleStroke, userCircleStrokeWidth, userCircleFill));
                    return shapes;
                }
                else if (userStyle == "1")
                {
                    string? userCircleStroke = "black";
                    string? userCircleStrokeWidth = "5";
                    string? userCircleFill = "red";
                    shapes.Add(new Circle(userCr, userCx, userCy, userCircleStroke, userCircleStrokeWidth, userCircleFill));
                    return shapes;
                }
                else if (userStyle == "2")
                {
                    string? userCircleStroke = "lime";
                    string? userCircleStrokeWidth = "5";
                    string? userCircleFill = "black";
                    shapes.Add(new Circle(userCr, userCx, userCy, userCircleStroke, userCircleStrokeWidth, userCircleFill));
                    return shapes;
                }
                else if (userStyle == "3")
                {
                    string? userCircleStroke = "red";
                    string? userCircleStrokeWidth = "5";
                    string? userCircleFill = "black";
                    shapes.Add(new Circle(userCr, userCx, userCy, userCircleStroke, userCircleStrokeWidth, userCircleFill));
                    return shapes;
                }
            }
        }
        else if (typeOfShape == "ellipse")                                                          //^   ELLIPSE
        {
            if (userStyle == "R")
            {
                shapes.Add(new Ellipse(RandomNumber(0, 400), RandomNumber(0, 400), RandomNumber(0, 400), RandomNumber(0, 400), RandomColour(), RandomColour(), RandomDouble(0, 1)));
                return shapes;
            }
            else
            {
                ForegroundColor = ConsoleColor.Blue; WriteLine("\nSet the position X:"); ResetColor();
                string? userEx = ReadLine();
                ForegroundColor = ConsoleColor.Blue; WriteLine("Set the position Y:"); ResetColor();
                string? userEy = ReadLine();
                ForegroundColor = ConsoleColor.Blue; WriteLine("Set the radius X:"); ResetColor();
                string? userEr1 = ReadLine();
                ForegroundColor = ConsoleColor.Blue; WriteLine("Set the radius Y:"); ResetColor();
                string? userEr2 = ReadLine();

                if (userStyle == "M")
                {
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Fill Colour:"); ResetColor();
                    string? userEllipseFill = ReadLine();
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Colour:"); ResetColor();
                    string? userEllipseStroke = ReadLine();
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Width:"); ResetColor();
                    string? userEllipseStrokeWidth = ReadLine();
                    shapes.Add(new Ellipse(userEx, userEy, userEr1, userEr2, userEllipseFill, userEllipseStroke, userEllipseStrokeWidth));
                    return shapes;
                }
                else if (userStyle == "1")
                {
                    string? userEllipseFill = "yellow";
                    string? userEllipseStroke = "purple";
                    string? userEllipseStrokeWidth = "2";
                    shapes.Add(new Ellipse(userEx, userEy, userEr1, userEr2, userEllipseFill, userEllipseStroke, userEllipseStrokeWidth));
                    return shapes;
                }
                else if (userStyle == "2")
                {
                    string? userEllipseFill = "purple";
                    string? userEllipseStroke = "yellow";
                    string? userEllipseStrokeWidth = "2";
                    shapes.Add(new Ellipse(userEx, userEy, userEr1, userEr2, userEllipseFill, userEllipseStroke, userEllipseStrokeWidth));
                    return shapes;
                }
                else if (userStyle == "3")
                {
                    string? userEllipseFill = "lime";
                    string? userEllipseStroke = "red";
                    string? userEllipseStrokeWidth = "2";
                    shapes.Add(new Ellipse(userEx, userEy, userEr1, userEr2, userEllipseFill, userEllipseStroke, userEllipseStrokeWidth));
                    return shapes;
                }
            }
        }
        else if (typeOfShape == "line")                                                          //^   LINE
        {
            if (userStyle == "R")
            {
                shapes.Add(new Line(RandomNumber(0, 400), RandomNumber(0, 400), RandomNumber(0, 400), RandomNumber(0, 400), RandomColour(), RandomNumber(1, 10)));
                return shapes;
            }
            else
            {
                ForegroundColor = ConsoleColor.Blue; WriteLine("\nSet the X1:"); ResetColor();
                string? userLineX1 = ReadLine();
                ForegroundColor = ConsoleColor.Blue; WriteLine("Set the Y1:"); ResetColor();
                string? userLineY1 = ReadLine();
                ForegroundColor = ConsoleColor.Blue; WriteLine("Set the X2:"); ResetColor();
                string? userLineX2 = ReadLine();
                ForegroundColor = ConsoleColor.Blue; WriteLine("Set the Y2:"); ResetColor();
                string? userLineY2 = ReadLine();

                if (userStyle == "M")
                {
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Colour:"); ResetColor();
                    string? userLineStroke = ReadLine();
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Width:"); ResetColor();
                    string? userLineStrokeWidth = ReadLine();
                    shapes.Add(new Line(userLineX1, userLineY1, userLineX2, userLineY2, userLineStroke, userLineStrokeWidth));
                    return shapes;
                }
                else if (userStyle == "1")
                {
                    string? userLineStroke = "red";
                    string? userLineStrokeWidth = "2";
                    shapes.Add(new Line(userLineX1, userLineY1, userLineX2, userLineY2, userLineStroke, userLineStrokeWidth));
                    return shapes;
                }
                else if (userStyle == "2")
                {
                    string? userLineStroke = "lime";
                    string? userLineStrokeWidth = "5";
                    shapes.Add(new Line(userLineX1, userLineY1, userLineX2, userLineY2, userLineStroke, userLineStrokeWidth));
                    return shapes;
                }
                else if (userStyle == "3")
                {
                    string? userLineStroke = "black";
                    string? userLineStrokeWidth = "2";
                    shapes.Add(new Line(userLineX1, userLineY1, userLineX2, userLineY2, userLineStroke, userLineStrokeWidth));
                    return shapes;
                }
            }
        }
        else if (typeOfShape == "path")                                                          //^   PATH
        {
            if (userStyle == "R")
            {
                shapes.Add(new Path("M " + RandomNumber(0, 175) + " " + RandomNumber(0, 200) + " l " + RandomNumber(0, 150) + " " + RandomNumber(0, 150), RandomColour(), RandomNumber(1, 10), RandomColour()));
                return shapes;
            }
            else
            {
                ForegroundColor = ConsoleColor.Blue; WriteLine("\nEnter the path points: (E.g. M 175 200 l 150 0)"); ResetColor();
                string? userPath = ReadLine();

                if (userStyle == "M")
                {
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Colour:"); ResetColor();
                    string? userPathStroke = ReadLine();
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Width:"); ResetColor();
                    string? userPathStrokeWidth = ReadLine();
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Fill Colour:"); ResetColor();
                    string? userPathFill = ReadLine();
                    shapes.Add(new Path(userPath, userPathStroke, userPathStrokeWidth, userPathFill));
                    return shapes;
                }
                else if (userStyle == "1")
                {
                    string? userPathStroke = "red";
                    string? userPathStrokeWidth = "2";
                    string? userPathFill = "black";
                    shapes.Add(new Path(userPath, userPathStroke, userPathStrokeWidth, userPathFill));
                    return shapes;
                }
                else if (userStyle == "2")
                {
                    string? userPathStroke = "green";
                    string? userPathStrokeWidth = "5";
                    string? userPathFill = "red";
                    shapes.Add(new Path(userPath, userPathStroke, userPathStrokeWidth, userPathFill));
                    return shapes;
                }
                else if (userStyle == "3")
                {
                    string? userPathStroke = "black";
                    string? userPathStrokeWidth = "3";
                    string? userPathFill = "lime";
                    shapes.Add(new Path(userPath, userPathStroke, userPathStrokeWidth, userPathFill));
                    return shapes;
                }
            }
        }
        else if (typeOfShape == "polygon")                                                          //^   POLYGON
        {
            if (userStyle == "R")
            {
                shapes.Add(new Polygon(RandomNumber(0, 200) + "," + RandomNumber(0, 200) + " " + RandomNumber(0, 200) + "," + RandomNumber(0, 200) + " " + RandomNumber(0, 200) + "," + RandomNumber(0, 200), RandomColour(), RandomColour(), RandomNumber(1, 10)));
                return shapes;
            }
            else
            {
                ForegroundColor = ConsoleColor.Blue; WriteLine("\nEnter the polygon points: (E.g. 200,10 250,190 160,210)"); ResetColor();
                string? userPointGon = ReadLine();

                if (userStyle == "M")
                {
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Fill Colour:"); ResetColor();
                    string? userPolygonFill = ReadLine();
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Colour:"); ResetColor();
                    string? userPolygonStroke = ReadLine();
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Width:"); ResetColor();
                    string? userPolygonStrokeWidth = ReadLine();
                    shapes.Add(new Polygon(userPointGon, userPolygonFill, userPolygonStroke, userPolygonStrokeWidth));
                    return shapes;
                }
                else if (userStyle == "1")
                {
                    string? userPolygonFill = "lime";
                    string? userPolygonStroke = "purple";
                    string? userPolygonStrokeWidth = "1";
                    shapes.Add(new Polygon(userPointGon, userPolygonFill, userPolygonStroke, userPolygonStrokeWidth));
                    return shapes;

                }
                else if (userStyle == "2")
                {
                    string? userPolygonFill = "purple";
                    string? userPolygonStroke = "lime";
                    string? userPolygonStrokeWidth = "1";
                    shapes.Add(new Polygon(userPointGon, userPolygonFill, userPolygonStroke, userPolygonStrokeWidth));
                    return shapes;
                }
                else if (userStyle == "3")
                {
                    string? userPolygonFill = "black";
                    string? userPolygonStroke = "red";
                    string? userPolygonStrokeWidth = "1";
                    shapes.Add(new Polygon(userPointGon, userPolygonFill, userPolygonStroke, userPolygonStrokeWidth));
                    return shapes;
                }
            }
        }
        else if (typeOfShape == "polyline")                                                          //^   POLYLINE
        {
            if (userStyle == "R")
            {
                shapes.Add(new Polyline(RandomNumber(0, 200) + "," + RandomNumber(0, 200) + " " + RandomNumber(0, 200) + "," + RandomNumber(0, 200) + " " + RandomNumber(0, 200) + "," + RandomNumber(0, 200) + " " + RandomNumber(0, 200) + "," + RandomNumber(0, 200) + " " + RandomNumber(0, 200) + "," + RandomNumber(0, 200) + " " + RandomNumber(0, 200) + "," + RandomNumber(0, 200), RandomColour(), RandomColour(), RandomNumber(1, 10)));
                return shapes;
            }
            else
            {
                ForegroundColor = ConsoleColor.Blue; WriteLine("\nEnter the polyline points: (E.g. 20,20 40,25 60,40 80,120 120,140 200,180)"); ResetColor();
                string? userPoint = ReadLine();

                if (userStyle == "M")
                {
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Fill Colour:"); ResetColor();
                    string? userPolylineFill = ReadLine();
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Colour:"); ResetColor();
                    string? userPolylineStroke = ReadLine();
                    ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Width:"); ResetColor();
                    string? userPolylineStrokeWidth = ReadLine();
                    shapes.Add(new Polyline(userPoint, userPolylineFill, userPolylineStroke, userPolylineStrokeWidth));
                    return shapes;
                }
                else if (userStyle == "1")
                {
                    string? userPolylineFill = "none";
                    string? userPolylineStroke = "black";
                    string? userPolylineStrokeWidth = "3";
                    shapes.Add(new Polyline(userPoint, userPolylineFill, userPolylineStroke, userPolylineStrokeWidth));
                    return shapes;
                }
                else if (userStyle == "2")
                {
                    string? userPolylineFill = "lime";
                    string? userPolylineStroke = "black";
                    string? userPolylineStrokeWidth = "2";
                    shapes.Add(new Polyline(userPoint, userPolylineFill, userPolylineStroke, userPolylineStrokeWidth));
                    return shapes;
                }
                else if (userStyle == "3")
                {
                    string? userPolylineFill = "red";
                    string? userPolylineStroke = "black";
                    string? userPolylineStrokeWidth = "3";
                    shapes.Add(new Polyline(userPoint, userPolylineFill, userPolylineStroke, userPolylineStrokeWidth));
                    return shapes;
                }
            }
        }
        else // ^ ERROR
        {
            ForegroundColor = ConsoleColor.Red; WriteLine("\nERROR: Invalid Shape Command!\n"); ResetColor();
            return shapes;
        }
        return shapes;
    }

    public string RandomNumber(int min, int max) //~ GENERATE RANDOM NUMBER
    {
        Random r = new Random();
        int randomInt = r.Next(min, max);
        string randomString = randomInt.ToString();
        return randomString;
    }

    public string RandomColour() //~ GENERATE RANDOM COLOUR
    {
        Random r = new Random();
        var options = new List<string> { "red", "lime", "blue", "purple", "black" };
        int index = r.Next(options.Count);
        var fill = options[index];
        options.RemoveAt(index);
        return fill;
    }

    public string RandomDouble(double min, double max) //~ GENERATE RANDOM DOUBLE
    {
        Random random = new Random();
        double randomDouble = random.NextDouble() * (max - min) + min;
        string randomString = randomDouble.ToString("0.#"); //this gets rid of extra decimals at the end and makes it go to 1 decimal point
        return randomString;
    }
}