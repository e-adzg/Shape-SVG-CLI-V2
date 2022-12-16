/*
Student Name: Erikas Adzgauskas
Student Number: 20415984

This is my SVG Maker. I am using NET 6.0. 
Tested on Windows 11 in VSCode 1.72.2

HOW TO USE:
to run programme, type 'dotnet run' in  
a list of instructions are printed to the 
for example, if you want to make a rectangle, you would type 'rectangle'
then, input all of the co-ordinates and CSS styles you wish to add.
all inputs take in string, so to add colour, you can type 'lime'
inputs accepts decimals where appropriate.

TO EXPORT:
after adding shapes, you can type 'export' to make a SVG file
and the programme will terminate and a new SVG file will
be made in the same folder here.

CODE CONTEXT:
a list holds all shapes. the interface shape extends to all
other shapes. after creating a new shape, it will be added 
to the shapes list. at the end, when the user wants to export,
it will loop through the list and add each SVG method to the
SVG file.

*/


using System;
using System.Drawing;
using static System.Console;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programRun = true; //checks if the programme is still running
            bool userInput = true;  //used to keep the while loop looping so that the user can keep entering shapes

            var shapes = new List<Shape>(); //this is the list that holds all shapes
            ShapeFactory factory = new ShapeFactory(); // make the factory to generate shapes

            string svgHeight = "400"; //default values for canvas
            string svgWidth = "400";

            string svgOpening = String.Format(@"<svg height=""{0}"" width=""{1}"" xmlns=""http://www.w3.org/2000/svg"">", svgHeight, svgWidth); //this is the first line for the SVG file which lets the user change the canvas

            string svgOpen = svgOpening + Environment.NewLine;
            string svgClose = Environment.NewLine + @"</svg>"; //last line for the SVG file

            while (programRun == true)
            {
                Clear(); //this is all console printing. I added colour because i thought it looked cool

                ForegroundColor = ConsoleColor.Red; WriteLine("Shape SVG CLI"); WriteLine("By: Erikas Adzgauskas 20415984"); ResetColor();
                ForegroundColor = ConsoleColor.Blue; WriteLine("===================================="); ResetColor();

                WriteLine("Type Shape To Add: rectangle, circle, ellipse, line, polyline, polygon, path");
                WriteLine("To Change Canvas Size, Type: canvas");
                WriteLine("To Export, Type: export");
                WriteLine("To Exit, Type: exit");
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("====================================");
                ResetColor();
                WriteLine();

                while (userInput == true) //this will let the user keep entering as many inputs while this is true
                {
                    string userRead = ReadLine();

                    switch (userRead) //this is a long switch case for every input possible that the user can enter
                    {
                        case "rectangle": //if the user enters rectangle, it will let the user input all variables about the shape
                            WriteLine("Set the height:");
                            string userHeight = ReadLine();
                            WriteLine("Set the width:");
                            string userWitdh = ReadLine();
                            WriteLine("Set the X:");
                            string userRecX = ReadLine();
                            WriteLine("Set the Y:");
                            string userRecY = ReadLine();
                            WriteLine("Enter Fill Colour:");
                            string userFill = ReadLine();
                            WriteLine("Enter Stroke Colour:");
                            string userRecStrokeColour = ReadLine();
                            WriteLine("Enter Stroke Width:");
                            string valRecStrokeWidth = ReadLine();
                            WriteLine("Enter Fill Opacity:");
                            string userRecFillOpacity = ReadLine();
                            WriteLine("Enter Stroke Opacity:");
                            string userRecStrokeOpacity = ReadLine();

                            shapes.Add(new Rectangle(userRecX, userRecY, userHeight, userWitdh, userFill, userRecStrokeColour, valRecStrokeWidth, userRecFillOpacity, userRecStrokeOpacity)); //this will add all the variables to the list

                            WriteLine("\nRectangle Added!\n");

                            break;

                        case "circle": //all these shape cases are the same as rectangle except to their own unique shape
                            WriteLine("Set the radius:");
                            string userCr = ReadLine();
                            WriteLine("Set the circle X:");
                            string userCx = ReadLine();
                            WriteLine("Set the circle Y:");
                            string userCy = ReadLine();
                            WriteLine("Enter Stroke Colour:");
                            string userCircleStroke = ReadLine();
                            WriteLine("Enter Stroke Witdh:");
                            string userCircleStrokeWidth = ReadLine();
                            WriteLine("Enter Fill Colour:");
                            string userCircleFill = ReadLine();

                            shapes.Add(new Circle(userCr, userCx, userCy, userCircleStroke, userCircleStrokeWidth, userCircleFill));

                            WriteLine("\nCircle Added!\n");

                            break;

                        case "ellipse":
                            WriteLine("Set the position X:");
                            string userEx = ReadLine();
                            WriteLine("Set the position Y:");
                            string userEy = ReadLine();
                            WriteLine("Set the radius X:");
                            string userEr1 = ReadLine();
                            WriteLine("Set the radius Y:");
                            string userEr2 = ReadLine();
                            WriteLine("Enter Fill Colour:");
                            string userEllipseFill = ReadLine();
                            WriteLine("Enter Stroke Colour:");
                            string userEllipseStroke = ReadLine();
                            WriteLine("Enter Stroke Width:");
                            string userEllipseStrokeWidth = ReadLine();

                            shapes.Add(new Ellipse(userEx, userEy, userEr1, userEr2, userEllipseFill, userEllipseStroke, userEllipseStrokeWidth));

                            WriteLine("\nEllipse Added!\n");

                            break;

                        case "line":
                            WriteLine("Set the X1:");
                            string userLineX1 = ReadLine();
                            WriteLine("Set the Y1:");
                            string userLineY1 = ReadLine();
                            WriteLine("Set the X2:");
                            string userLineX2 = ReadLine();
                            WriteLine("Set the Y2:");
                            string userLineY2 = ReadLine();
                            WriteLine("Enter Stroke Colour: (string)");
                            string userLineStroke = ReadLine();
                            WriteLine("Enter Stroke Width: (string)");
                            string userLineStrokeWidth = ReadLine();

                            shapes.Add(new Line(userLineX1, userLineY1, userLineX2, userLineY2, userLineStroke, userLineStrokeWidth));

                            WriteLine("\nLine Added!\n");

                            break;

                        case "polyline":
                            WriteLine("Enter the polyline points: (E.g. 20,20 40,25 60,40 80,120 120,140 200,180)");
                            string userPoint = ReadLine();
                            WriteLine("Enter Fill Colour: (string) (can enter: none)");
                            string userPolylineFill = ReadLine();
                            WriteLine("Enter Stroke Colour: (string)");
                            string userPolylineStroke = ReadLine();
                            WriteLine("Enter Stroke Width: (string)");
                            string userPolylineStrokeWidth = ReadLine();


                            shapes.Add(new Polyline(userPoint, userPolylineFill, userPolylineStroke, userPolylineStrokeWidth));

                            WriteLine("\nPolyline Added!\n");

                            break;

                        case "polygon":
                            WriteLine("Enter the polygon points: (E.g. 200,10 250,190 160,210)");
                            string userPointGon = ReadLine();
                            WriteLine("Enter Fill Colour: (string)");
                            string userPolygonFill = ReadLine();
                            WriteLine("Enter Stroke Colour: (string)");
                            string userPolygonStroke = ReadLine();
                            WriteLine("Enter Stroke Width: (string)");
                            string userPolygonStrokeWidth = ReadLine();

                            shapes.Add(new Polygon(userPointGon, userPolygonFill, userPolygonStroke, userPolygonStrokeWidth));

                            WriteLine("\nPolygon Added!\n");

                            break;

                        case "path":
                            WriteLine("Enter the path points: (E.g. M 175 200 l 150 0)");
                            string userPath = ReadLine();
                            WriteLine("Enter Stroke Colour: (string)");
                            string userPathStroke = ReadLine();
                            WriteLine("Enter Stroke Width: (string)");
                            string userPathStrokeWidth = ReadLine();
                            WriteLine("Enter Fill Colour: (string)");
                            string userPathFill = ReadLine();

                            shapes.Add(new Path(userPath, userPathStroke, userPathStrokeWidth, userPathFill));

                            WriteLine("\nPath Added!\n");

                            break;

                        case "canvas": //this lets the user enter the canvas height and width
                            WriteLine("\nEnter Canvas Height:");
                            string userSvgHeight = ReadLine();
                            WriteLine("Enter Canvas Width:");
                            string userSvgWidth = ReadLine();

                            svgHeight = userSvgHeight; //this overwrites the current canvas height and width
                            svgWidth = userSvgWidth;
                            svgOpening = String.Format(@"<svg height=""{0}"" width=""{1}"" xmlns=""http://www.w3.org/2000/svg"">", svgHeight, svgWidth);
                            svgOpen = svgOpening + Environment.NewLine;

                            WriteLine("\nCanvas Has Been Modified!\n");

                            break;

                        case "export":
                            userInput = false; //ends the user input

                            string allshapes = "";
                            int length = shapes.Count; //gets the length of the list of shapes

                            for (int i = 0; i < length; i++) //while it goes through the list of shapes, it will add each ToString from every shape
                            {
                                allshapes = allshapes + Convert.ToString(shapes[i]);
                            }

                            File.WriteAllText(@"./newSVG.svg", svgOpen + "".PadLeft(3, ' ') + allshapes + Environment.NewLine + svgClose); //file creation here

                            WriteLine("\nSVG Exported!\n");

                            break;

                        case "exit":
                            userInput = false; //ends the user input so that the programme can close
                            break;

                        case "hello":
                            WriteLine("\nHello!\n"); //hello :)
                            break;
                    }
                }
                programRun = false;
            }
        }
    }
}






// case "export":
//     userInput = false; //ends the user input

//     string allshapes = "";
//     int length = shapes.Count; //gets the length of the list of shapes

//     for (int i = 0; i < length; i++) //while it goes through the list of shapes, it will add each ToString from every shape
//     {
//         allshapes = allshapes + Convert.ToString(shapes[i]);
//     }

//     File.WriteAllText(@"./newSVG.svg", svgOpen + "".PadLeft(3, ' ') + allshapes + Environment.NewLine + svgClose); //file creation here

//     WriteLine("\nSVG Exported!\n");

//     break;