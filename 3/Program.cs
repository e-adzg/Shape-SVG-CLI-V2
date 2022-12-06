/*
Student Name: Erikas Adzgauskas
Student Number: 20415984

This is my SVG Maker. I am using NET 6.0. 
Tested on Windows 11 in VSCode 1.72.2

HOW TO USE:
to run programme, type 'dotnet run' in console. 
for example, if you want to make a rectangle, you would type 'A rectangle'
then, input all of the co-ordinates and CSS styles you wish to add.
all inputs take in string, so to add colour, you can type 'lime'
inputs accepts decimals where appropriate.

TO EXPORT:
after adding shapes, you can type 'E' to make a SVG file
and the programme will terminate and a new SVG file will
be made in the same folder here.

CODE CONTEXT:
a string holds all shapes. the interface shape extends to all
other shapes. after creating a new shape, it will be added 
to the shapes string. at the end, when the user wants to export,
it will print out the string and add each SVG method to the
SVG file.

Undo Redo is implemented using memento pattern.
To try this you can for example:
A rectangle
(input all numbers)
A circle
(input all numbers)
D (to display)
U (to undo)
D (to display)
R (to redo)
D (to display and you should see the changes being made)

Shapes you can add are:
A rectangle
A circle
A ellipse
A line
A polyline
A polygon
A path
*/


using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Assignment3
{
    //have 2 stacks, undo and redo, when redo-ing, take states from the redo stack and bring it back

    class Program
    {
        static void Main(string[] args)
        {
            bool programRun = true; //checks if the programme is still running
            bool userInput = true;  //used to keep the while loop looping so that the user can keep entering shapes

            var shapes = new List<Shape>(); //this is the list that holds all shapes
            string? allShapesString = "";
            Originator originator = new Originator(allShapesString);
            Caretaker caretaker = new Caretaker(originator);
            Caretaker allShapesList = new Caretaker(originator);
            caretaker.Backup();

            string? svgHeight = "400"; //default values for canvas
            string? svgWidth = "400";

            string svgOpening = String.Format(@"<svg height=""{0}"" width=""{1}"" xmlns=""http://www.w3.org/2000/svg"">", svgHeight, svgWidth); //this is the first line for the SVG file which lets the user change the canvas

            string svgOpen = svgOpening + Environment.NewLine;
            string svgClose = Environment.NewLine + @"</svg>"; //last line for the SVG file

            while (programRun == true)
            {
                Console.Clear(); //this is all console printing. I added colour because i thought it looked cool

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Assignment 3");
                Console.WriteLine("By Erikas Adzgauskas 20415984");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("====================================");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nCanvas Created - use commands to add shapes to the canvas!\n");
                Console.ResetColor();

                while (userInput == true) //this will let the user keep entering as many inputs while this is true
                {
                    string? userRead = Console.ReadLine();

                    switch (userRead) //this is a long switch case for every input possible that the user can enter
                    {
                        case "A rectangle": //if the user enters rectangle, it will let the user input all variables about the shape
                            caretaker.Backup();
                            Console.WriteLine("Set the height:");
                            string? userHeight = Console.ReadLine();
                            Console.WriteLine("Set the width:");
                            string? userWitdh = Console.ReadLine();
                            Console.WriteLine("Set the X:");
                            string? userRecX = Console.ReadLine();
                            Console.WriteLine("Set the Y:");
                            string? userRecY = Console.ReadLine();
                            Console.WriteLine("Enter Fill Colour:");
                            string? userFill = Console.ReadLine();
                            Console.WriteLine("Enter Stroke Colour:");
                            string? userRecStrokeColour = Console.ReadLine();
                            Console.WriteLine("Enter Stroke Width:");
                            string? valRecStrokeWidth = Console.ReadLine();
                            Console.WriteLine("Enter Fill Opacity:");
                            string? userRecFillOpacity = Console.ReadLine();
                            Console.WriteLine("Enter Stroke Opacity:");
                            string? userRecStrokeOpacity = Console.ReadLine();

                            allShapesString = allShapesString + "\n" + Convert.ToString(new Rectangle(userRecX, userRecY, userHeight, userWitdh, userFill, userRecStrokeColour, valRecStrokeWidth, userRecFillOpacity, userRecStrokeOpacity));
                            originator.DoSomething(allShapesString);

                            caretaker.resetRedo();

                            Console.WriteLine("\nRectangle Added!\n");
                            break;

                        case "A circle": //all these shape cases are the same as rectangle except to their own unique shape
                            caretaker.Backup();
                            Console.WriteLine("Set the radius:");
                            string? userCr = Console.ReadLine();
                            Console.WriteLine("Set the circle X:");
                            string? userCx = Console.ReadLine();
                            Console.WriteLine("Set the circle Y:");
                            string? userCy = Console.ReadLine();
                            Console.WriteLine("Enter Stroke Colour:");
                            string? userCircleStroke = Console.ReadLine();
                            Console.WriteLine("Enter Stroke Witdh:");
                            string? userCircleStrokeWidth = Console.ReadLine();
                            Console.WriteLine("Enter Fill Colour:");
                            string? userCircleFill = Console.ReadLine();

                            allShapesString = allShapesString + "\n" + Convert.ToString(new Circle(userCr, userCx, userCy, userCircleStroke, userCircleStrokeWidth, userCircleFill));
                            originator.DoSomething(allShapesString);

                            caretaker.resetRedo();

                            Console.WriteLine("\nCircle Added!\n");
                            break;

                        case "A ellipse":
                            caretaker.Backup();
                            Console.WriteLine("Set the position X:");
                            string? userEx = Console.ReadLine();
                            Console.WriteLine("Set the position Y:");
                            string? userEy = Console.ReadLine();
                            Console.WriteLine("Set the radius X:");
                            string? userEr1 = Console.ReadLine();
                            Console.WriteLine("Set the radius Y:");
                            string? userEr2 = Console.ReadLine();
                            Console.WriteLine("Enter Fill Colour:");
                            string? userEllipseFill = Console.ReadLine();
                            Console.WriteLine("Enter Stroke Colour:");
                            string? userEllipseStroke = Console.ReadLine();
                            Console.WriteLine("Enter Stroke Width:");
                            string? userEllipseStrokeWidth = Console.ReadLine();

                            allShapesString = allShapesString + "\n" + Convert.ToString(new Ellipse(userEx, userEy, userEr1, userEr2, userEllipseFill, userEllipseStroke, userEllipseStrokeWidth));
                            originator.DoSomething(allShapesString);

                            caretaker.resetRedo();

                            Console.WriteLine("\nEllipse Added!\n");
                            break;

                        case "A line":
                            caretaker.Backup();
                            Console.WriteLine("Set the X1:");
                            string? userLineX1 = Console.ReadLine();
                            Console.WriteLine("Set the Y1:");
                            string? userLineY1 = Console.ReadLine();
                            Console.WriteLine("Set the X2:");
                            string? userLineX2 = Console.ReadLine();
                            Console.WriteLine("Set the Y2:");
                            string? userLineY2 = Console.ReadLine();
                            Console.WriteLine("Enter Stroke Colour:");
                            string? userLineStroke = Console.ReadLine();
                            Console.WriteLine("Enter Stroke Width:");
                            string? userLineStrokeWidth = Console.ReadLine();

                            allShapesString = allShapesString + "\n" + Convert.ToString(new Line(userLineX1, userLineY1, userLineX2, userLineY2, userLineStroke, userLineStrokeWidth));
                            originator.DoSomething(allShapesString);

                            caretaker.resetRedo();

                            Console.WriteLine("\nLine Added!\n");
                            break;

                        case "A polyline":
                            caretaker.Backup();
                            Console.WriteLine("Enter the polyline points: (E.g. 20,20 40,25 60,40 80,120 120,140 200,180)");
                            string? userPoint = Console.ReadLine();
                            Console.WriteLine("Enter Fill Colour:");
                            string? userPolylineFill = Console.ReadLine();
                            Console.WriteLine("Enter Stroke Colour:");
                            string? userPolylineStroke = Console.ReadLine();
                            Console.WriteLine("Enter Stroke Width:");
                            string? userPolylineStrokeWidth = Console.ReadLine();

                            allShapesString = allShapesString + "\n" + Convert.ToString(new Polyline(userPoint, userPolylineFill, userPolylineStroke, userPolylineStrokeWidth));
                            originator.DoSomething(allShapesString);

                            caretaker.resetRedo();

                            Console.WriteLine("\nPolyline Added!\n");
                            break;

                        case "A polygon":
                            caretaker.Backup();
                            Console.WriteLine("Enter the polygon points: (E.g. 200,10 250,190 160,210)");
                            string? userPointGon = Console.ReadLine();
                            Console.WriteLine("Enter Fill Colour:");
                            string? userPolygonFill = Console.ReadLine();
                            Console.WriteLine("Enter Stroke Colour:");
                            string? userPolygonStroke = Console.ReadLine();
                            Console.WriteLine("Enter Stroke Width:");
                            string? userPolygonStrokeWidth = Console.ReadLine();

                            allShapesString = allShapesString + "\n" + Convert.ToString(new Polygon(userPointGon, userPolygonFill, userPolygonStroke, userPolygonStrokeWidth));
                            originator.DoSomething(allShapesString);

                            caretaker.resetRedo();

                            Console.WriteLine("\nPolygon Added!\n");
                            break;

                        case "A path":
                            caretaker.Backup();
                            Console.WriteLine("Enter the path points: (E.g. M 175 200 l 150 0)");
                            string? userPath = Console.ReadLine();
                            Console.WriteLine("Enter Stroke Colour:");
                            string? userPathStroke = Console.ReadLine();
                            Console.WriteLine("Enter Stroke Width:");
                            string? userPathStrokeWidth = Console.ReadLine();
                            Console.WriteLine("Enter Fill Colour:");
                            string? userPathFill = Console.ReadLine();

                            allShapesString = allShapesString + "\n" + Convert.ToString(new Path(userPath, userPathStroke, userPathStrokeWidth, userPathFill));
                            originator.DoSomething(allShapesString);

                            caretaker.resetRedo();

                            Console.WriteLine("\nPath Added!\n");
                            break;

                        case "A canvas": //this lets the user enter the canvas height and width
                            Console.WriteLine("\nEnter Canvas Height:");
                            string? userSvgHeight = Console.ReadLine();
                            Console.WriteLine("Enter Canvas Width:");
                            string? userSvgWidth = Console.ReadLine();

                            svgHeight = userSvgHeight; //this overwrites the current canvas height and width
                            svgWidth = userSvgWidth;
                            svgOpening = String.Format(@"<svg height=""{0}"" width=""{1}"" xmlns=""http://www.w3.org/2000/svg"">", svgHeight, svgWidth);
                            svgOpen = svgOpening + Environment.NewLine;

                            Console.WriteLine("\nCanvas Has Been Modified!\n");
                            break;

                        case "export":
                            userInput = false; //ends the user input

                            File.WriteAllText(@"./An_SVG.svg", svgOpen + "".PadLeft(3, ' ') + allShapesString + Environment.NewLine + svgClose); //file creation here

                            Console.WriteLine("\nSVG Exported!\n");
                            break;

                        case "E":
                            userInput = false; //ends the user input

                            File.WriteAllText(@"./An_SVG.svg", svgOpen + "".PadLeft(3, ' ') + allShapesString + Environment.NewLine + svgClose); //file creation here

                            Console.WriteLine("\nSVG Exported!\n");
                            break;

                        case "exit":
                            userInput = false; //ends the user input so that the programme can close
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nGoodbye!\n");
                            Console.ResetColor();
                            break;

                        case "Q":
                            userInput = false; //ends the user input so that the programme can close
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nGoodbye!\n");
                            Console.ResetColor();
                            break;

                        case "H":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nCommands:");
                            Console.ResetColor();
                            Console.WriteLine("H               Help - displays this message\nA <shape>       Add <shape> to canvas\nU               Undo last operation\nR               Redo last operation\nC               Clear canvas\nD               Display canvas to console\nE               Export canvas\nQ               Quit application\n");
                            break;

                        case "D":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nDisplaying SVG To Console:\n");
                            Console.ResetColor();

                            Console.WriteLine(svgOpen);

                            Console.WriteLine(allShapesString);

                            Console.WriteLine(svgClose + "\n");
                            break;

                        case "U":
                            caretaker.Backup();
                            allShapesString = caretaker.Undo();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nUndo Done!\n");
                            Console.ResetColor();

                            break;

                        case "R":
                            allShapesString = caretaker.Redo();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nRedo Done!\n");
                            Console.ResetColor();

                            break;

                        case "checkundo":
                            string checkundo = caretaker.checkMementoState();
                            Console.WriteLine(checkundo);
                            break;

                        case "checkredo":
                            string checkredo = caretaker.checkRedoState();
                            Console.WriteLine(checkredo);
                            break;


                        case "printundo":
                            caretaker.printUndoList();
                            break;

                        case "printredo":
                            caretaker.printRedoList();
                            break;

                        case "hello":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nHello!\n"); //hello :)
                            Console.ResetColor();
                            break;
                    }
                }
                programRun = false;
            }
        }
    }
}