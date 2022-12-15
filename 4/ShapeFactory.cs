using static System.Console;
//I can pass in the type of style into the shape factory and go from here
public class ShapeFactory
{
    public void generateShape(User user, Canvas canvas, string typeOfShape, string userStyle)
    {
        if (typeOfShape == "rectangle")                                                                     //^   RECTANGLE
        {
            if (userStyle == "R")
            {
                user.Action(new AddShapeCommand(new Rectangle(RandomNumber(0, 400), RandomNumber(0, 400), RandomNumber(0, 400), RandomNumber(0, 400), RandomColour(), RandomColour(), RandomNumber(0, 5), RandomDouble(0, 1), RandomDouble(0, 1)), canvas));
            }
            else
            {
                ForegroundColor = ConsoleColor.Blue; WriteLine("\nSet the height:"); ResetColor();
                string? userHeight = ReadLine();
                ForegroundColor = ConsoleColor.Blue; WriteLine("Set the width:"); ResetColor();
                string? userWitdh = ReadLine();
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
                    user.Action(new AddShapeCommand(new Rectangle(userRecX, userRecY, userHeight, userWitdh, userFill, userRecStrokeColour, userRecStrokeWidth, userRecFillOpacity, userRecStrokeOpacity), canvas));
                }
                else if (userStyle == "1")
                {
                    string? userFill = "blue";
                    string? userRecStrokeColour = "pink";
                    string? userRecStrokeWidth = "5";
                    string? userRecFillOpacity = "0.1";
                    string? userRecStrokeOpacity = "0.9";
                    user.Action(new AddShapeCommand(new Rectangle(userRecX, userRecY, userHeight, userWitdh, userFill, userRecStrokeColour, userRecStrokeWidth, userRecFillOpacity, userRecStrokeOpacity), canvas));
                }
                else if (userStyle == "2")
                {
                    string? userFill = "red";
                    string? userRecStrokeColour = "black";
                    string? userRecStrokeWidth = "5";
                    string? userRecFillOpacity = "1";
                    string? userRecStrokeOpacity = "0.5";
                    user.Action(new AddShapeCommand(new Rectangle(userRecX, userRecY, userHeight, userWitdh, userFill, userRecStrokeColour, userRecStrokeWidth, userRecFillOpacity, userRecStrokeOpacity), canvas));
                }
                else if (userStyle == "3")
                {
                    string? userFill = "lime";
                    string? userRecStrokeColour = "black";
                    string? userRecStrokeWidth = "5";
                    string? userRecFillOpacity = "1";
                    string? userRecStrokeOpacity = "0.9";
                    user.Action(new AddShapeCommand(new Rectangle(userRecX, userRecY, userHeight, userWitdh, userFill, userRecStrokeColour, userRecStrokeWidth, userRecFillOpacity, userRecStrokeOpacity), canvas));
                }
            }
        }
        else if (typeOfShape == "circle")                                                           //^   CIRCLE
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
                ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Witdh:"); ResetColor();
                string? userCircleStrokeWidth = ReadLine();
                ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Fill Colour:"); ResetColor();
                string? userCircleFill = ReadLine();
                user.Action(new AddShapeCommand(new Circle(userCr, userCx, userCy, userCircleStroke, userCircleStrokeWidth, userCircleFill), canvas));
            }
            else if (userStyle == "1")
            {
                string? userCircleStroke = "black";
                string? userCircleStrokeWidth = "5";
                string? userCircleFill = "red";
                user.Action(new AddShapeCommand(new Circle(userCr, userCx, userCy, userCircleStroke, userCircleStrokeWidth, userCircleFill), canvas));
            }
            else if (userStyle == "2")
            {
                string? userCircleStroke = "lime";
                string? userCircleStrokeWidth = "5";
                string? userCircleFill = "black";
                user.Action(new AddShapeCommand(new Circle(userCr, userCx, userCy, userCircleStroke, userCircleStrokeWidth, userCircleFill), canvas));
            }
            else if (userStyle == "3")
            {
                string? userCircleStroke = "red";
                string? userCircleStrokeWidth = "5";
                string? userCircleFill = "black";
                user.Action(new AddShapeCommand(new Circle(userCr, userCx, userCy, userCircleStroke, userCircleStrokeWidth, userCircleFill), canvas));
            }
        }
        else if (typeOfShape == "ellipse")                                                          //^   ELLIPSE
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
                user.Action(new AddShapeCommand(new Ellipse(userEx, userEy, userEr1, userEr2, userEllipseFill, userEllipseStroke, userEllipseStrokeWidth), canvas));
            }
            else if (userStyle == "1")
            {
                string? userEllipseFill = "yellow";
                string? userEllipseStroke = "purple";
                string? userEllipseStrokeWidth = "2";
                user.Action(new AddShapeCommand(new Ellipse(userEx, userEy, userEr1, userEr2, userEllipseFill, userEllipseStroke, userEllipseStrokeWidth), canvas));
            }
            else if (userStyle == "2")
            {
                string? userEllipseFill = "purple";
                string? userEllipseStroke = "yellow";
                string? userEllipseStrokeWidth = "2";
                user.Action(new AddShapeCommand(new Ellipse(userEx, userEy, userEr1, userEr2, userEllipseFill, userEllipseStroke, userEllipseStrokeWidth), canvas));
            }
            else if (userStyle == "3")
            {
                string? userEllipseFill = "lime";
                string? userEllipseStroke = "red";
                string? userEllipseStrokeWidth = "2";
                user.Action(new AddShapeCommand(new Ellipse(userEx, userEy, userEr1, userEr2, userEllipseFill, userEllipseStroke, userEllipseStrokeWidth), canvas));
            }

        }
        else if (typeOfShape == "line")                                                          //^   LINE
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
                user.Action(new AddShapeCommand(new Line(userLineX1, userLineY1, userLineX2, userLineY2, userLineStroke, userLineStrokeWidth), canvas));
            }
            else if (userStyle == "1")
            {
                string? userLineStroke = "red";
                string? userLineStrokeWidth = "2";
                user.Action(new AddShapeCommand(new Line(userLineX1, userLineY1, userLineX2, userLineY2, userLineStroke, userLineStrokeWidth), canvas));
            }
            else if (userStyle == "2")
            {
                string? userLineStroke = "lime";
                string? userLineStrokeWidth = "5";
                user.Action(new AddShapeCommand(new Line(userLineX1, userLineY1, userLineX2, userLineY2, userLineStroke, userLineStrokeWidth), canvas));
            }
            else if (userStyle == "3")
            {
                string? userLineStroke = "black";
                string? userLineStrokeWidth = "2";
                user.Action(new AddShapeCommand(new Line(userLineX1, userLineY1, userLineX2, userLineY2, userLineStroke, userLineStrokeWidth), canvas));
            }
        }
        else if (typeOfShape == "path")                                                          //^   PATH
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
                user.Action(new AddShapeCommand(new Path(userPath, userPathStroke, userPathStrokeWidth, userPathFill), canvas));
            }
            else if (userStyle == "1")
            {
                string? userPathStroke = "red";
                string? userPathStrokeWidth = "2";
                string? userPathFill = "black";
                user.Action(new AddShapeCommand(new Path(userPath, userPathStroke, userPathStrokeWidth, userPathFill), canvas));
            }
            else if (userStyle == "2")
            {
                string? userPathStroke = "green";
                string? userPathStrokeWidth = "5";
                string? userPathFill = "red";
                user.Action(new AddShapeCommand(new Path(userPath, userPathStroke, userPathStrokeWidth, userPathFill), canvas));
            }
            else if (userStyle == "3")
            {
                string? userPathStroke = "black";
                string? userPathStrokeWidth = "3";
                string? userPathFill = "lime";
                user.Action(new AddShapeCommand(new Path(userPath, userPathStroke, userPathStrokeWidth, userPathFill), canvas));
            }
        }
        else if (typeOfShape == "polygon")                                                          //^   POLYGON
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
                user.Action(new AddShapeCommand(new Polygon(userPointGon, userPolygonFill, userPolygonStroke, userPolygonStrokeWidth), canvas));
            }
            else if (userStyle == "1")
            {
                string? userPolygonFill = "lime";
                string? userPolygonStroke = "purple";
                string? userPolygonStrokeWidth = "1";
                user.Action(new AddShapeCommand(new Polygon(userPointGon, userPolygonFill, userPolygonStroke, userPolygonStrokeWidth), canvas));
            }
            else if (userStyle == "2")
            {
                string? userPolygonFill = "purple";
                string? userPolygonStroke = "lime";
                string? userPolygonStrokeWidth = "1";
                user.Action(new AddShapeCommand(new Polygon(userPointGon, userPolygonFill, userPolygonStroke, userPolygonStrokeWidth), canvas));
            }
            else if (userStyle == "3")
            {
                string? userPolygonFill = "black";
                string? userPolygonStroke = "red";
                string? userPolygonStrokeWidth = "1";
                user.Action(new AddShapeCommand(new Polygon(userPointGon, userPolygonFill, userPolygonStroke, userPolygonStrokeWidth), canvas));
            }
        }
        else if (typeOfShape == "polyline")                                                          //^   POLYLINE
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
                user.Action(new AddShapeCommand(new Polyline(userPoint, userPolylineFill, userPolylineStroke, userPolylineStrokeWidth), canvas));
            }
            else if (userStyle == "1")
            {
                string? userPolylineFill = "none";
                string? userPolylineStroke = "black";
                string? userPolylineStrokeWidth = "3";
                user.Action(new AddShapeCommand(new Polyline(userPoint, userPolylineFill, userPolylineStroke, userPolylineStrokeWidth), canvas));
            }
            else if (userStyle == "2")
            {
                string? userPolylineFill = "lime";
                string? userPolylineStroke = "black";
                string? userPolylineStrokeWidth = "2";
                user.Action(new AddShapeCommand(new Polyline(userPoint, userPolylineFill, userPolylineStroke, userPolylineStrokeWidth), canvas));
            }
            else if (userStyle == "3")
            {
                string? userPolylineFill = "red";
                string? userPolylineStroke = "black";
                string? userPolylineStrokeWidth = "3";
                user.Action(new AddShapeCommand(new Polyline(userPoint, userPolylineFill, userPolylineStroke, userPolylineStrokeWidth), canvas));
            }
        }
        else // ^ ERROR
        {
            ForegroundColor = ConsoleColor.Red; WriteLine("\nERROR: Invalid Shape Command!\n"); ResetColor();
        }
    }

    public string RandomNumber(int min, int max)
    {
        Random r = new Random();
        int randomInt = r.Next(min, max);
        string randomString = randomInt.ToString();
        return randomString;
    }

    public string RandomColour()
    {
        Random r = new Random();
        var options = new List<string> { "red", "lime", "blue", "purple", "black" };
        int index = r.Next(options.Count);
        var fill = options[index];
        options.RemoveAt(index);
        return fill;
    }

    public string RandomDouble(double min, double max)
    {
        Random random = new Random();
        double randomDouble = random.NextDouble() * (max - min) + min;
        string randomString = randomDouble.ToString("0.#"); //this gets rid of extra decimals at the end and makes it go to 1 decimal point
        return randomString;
    }
}