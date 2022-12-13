using static System.Console;

public class ShapeFactory
{
    public void generateShape(User user, Canvas canvas, string typeOfShape)
    {
        if (typeOfShape == "rectangle")
        {
            ForegroundColor = ConsoleColor.Blue; WriteLine("\nSet the height:"); ResetColor();
            string? userHeight = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Set the width:"); ResetColor();
            string? userWitdh = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Set the X:"); ResetColor();
            string? userRecX = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Set the Y:"); ResetColor();
            string? userRecY = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Fill Colour:"); ResetColor();
            string? userFill = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Colour:"); ResetColor();
            string? userRecStrokeColour = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Width:"); ResetColor();
            string? valRecStrokeWidth = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Fill Opacity:"); ResetColor();
            string? userRecFillOpacity = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Opacity:"); ResetColor();
            string? userRecStrokeOpacity = ReadLine();

            user.Action(new AddShapeCommand(new Rectangle(userRecX, userRecY, userHeight, userWitdh, userFill, userRecStrokeColour, valRecStrokeWidth, userRecFillOpacity, userRecStrokeOpacity), canvas));
        }
        else if (typeOfShape == "circle")
        {
            ForegroundColor = ConsoleColor.Blue; WriteLine("\nSet the radius:"); ResetColor();
            string? userCr = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Set the circle X:"); ResetColor();
            string? userCx = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Set the circle Y:"); ResetColor();
            string? userCy = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Colour:"); ResetColor();
            string? userCircleStroke = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Witdh:"); ResetColor();
            string? userCircleStrokeWidth = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Fill Colour:"); ResetColor();
            string? userCircleFill = ReadLine();

            user.Action(new AddShapeCommand(new Circle(userCr, userCx, userCy, userCircleStroke, userCircleStrokeWidth, userCircleFill), canvas));
        }
        else if (typeOfShape == "ellipse")
        {
            ForegroundColor = ConsoleColor.Blue; WriteLine("\nSet the position X:"); ResetColor();
            string? userEx = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Set the position Y:"); ResetColor();
            string? userEy = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Set the radius X:"); ResetColor();
            string? userEr1 = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Set the radius Y:"); ResetColor();
            string? userEr2 = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Fill Colour:"); ResetColor();
            string? userEllipseFill = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Colour:"); ResetColor();
            string? userEllipseStroke = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Width:"); ResetColor();
            string? userEllipseStrokeWidth = ReadLine();

            user.Action(new AddShapeCommand(new Ellipse(userEx, userEy, userEr1, userEr2, userEllipseFill, userEllipseStroke, userEllipseStrokeWidth), canvas));
        }
        else if (typeOfShape == "line")
        {
            ForegroundColor = ConsoleColor.Blue; WriteLine("\nSet the X1:"); ResetColor();
            string? userLineX1 = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Set the Y1:"); ResetColor();
            string? userLineY1 = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Set the X2:"); ResetColor();
            string? userLineX2 = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Set the Y2:"); ResetColor();
            string? userLineY2 = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Colour:"); ResetColor();
            string? userLineStroke = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Width:"); ResetColor();
            string? userLineStrokeWidth = ReadLine();

            user.Action(new AddShapeCommand(new Line(userLineX1, userLineY1, userLineX2, userLineY2, userLineStroke, userLineStrokeWidth), canvas));
        }
        else if (typeOfShape == "path")
        {
            ForegroundColor = ConsoleColor.Blue; WriteLine("\nEnter the path points: (E.g. M 175 200 l 150 0)"); ResetColor();
            string? userPath = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Colour:"); ResetColor();
            string? userPathStroke = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Width:"); ResetColor();
            string? userPathStrokeWidth = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Fill Colour:"); ResetColor();
            string? userPathFill = ReadLine();

            user.Action(new AddShapeCommand(new Path(userPath, userPathStroke, userPathStrokeWidth, userPathFill), canvas));
        }
        else if (typeOfShape == "polygon")
        {
            ForegroundColor = ConsoleColor.Blue; WriteLine("\nEnter the polygon points: (E.g. 200,10 250,190 160,210)"); ResetColor();
            string? userPointGon = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Fill Colour:"); ResetColor();
            string? userPolygonFill = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Colour:"); ResetColor();
            string? userPolygonStroke = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Width:"); ResetColor();
            string? userPolygonStrokeWidth = ReadLine();

            user.Action(new AddShapeCommand(new Polygon(userPointGon, userPolygonFill, userPolygonStroke, userPolygonStrokeWidth), canvas));
        }
        else if (typeOfShape == "polyline")
        {
            ForegroundColor = ConsoleColor.Blue; WriteLine("\nEnter the polyline points: (E.g. 20,20 40,25 60,40 80,120 120,140 200,180)"); ResetColor();
            string? userPoint = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Fill Colour:"); ResetColor();
            string? userPolylineFill = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Colour:"); ResetColor();
            string? userPolylineStroke = ReadLine();
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Stroke Width:"); ResetColor();
            string? userPolylineStrokeWidth = ReadLine();

            user.Action(new AddShapeCommand(new Polyline(userPoint, userPolylineFill, userPolylineStroke, userPolylineStrokeWidth), canvas));
        }
        else
        {
            ForegroundColor = ConsoleColor.Red; WriteLine("\nERROR: Invalid Shape Command!\n"); ResetColor();
        }
    }
}