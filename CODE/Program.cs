/*
https://github.com/e-adzg/Shape-SVG-CLI-V2

This is my SVG Maker. I am using NET 6.0. 
Tested on Windows 11 Pro in VSCode 1.73.0

HOW TO USE:
to run programme, type 'dotnet run' in  for example, if you want to make a rectangle, you would type 'A rectangle' then, input all of the co-ordinates and CSS styles you wish to add. you have the option to use pre made styles with options 1, 2 or 3 that i made or type R to add random values to it. all inputs take in string, so to add colour, you can type 'lime'. inputs accepts decimals where appropriate.

TO EXPORT:
after adding shapes, you can type 'E' to make a SVG file. Enter the name of the SVG file and then the program will terminate and a new SVG file will be made in the same folder here.

CODE CONTEXT:
Command Pattern. Shapes will be pushed into canvas stack. There are undo and redo stacks. They will be pushing and removing shapes when they are called. The user class is the invoker class. The command class is the interface for commands. The deleteshapecommand and addshapecommand classes are classes that injerit from the command class. 

PATTERN:
Abstract Factory Pattern is used to generate a shape. Check ShapeFactory.cs to see more.
Style objects are implemented with the shape facotry also. It saves having the fact to completely seperate them.

PLANT UML:
for pdf/png of diagram see out/plantuml/include folder
for plantuml code see plantuml folder
*/

using static System.Console;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args) //main program
        {
            Clear();

            bool programRun = true; //used to end the program
            bool userInput = true;  //used to stop user input

            string? svgHeight = "400"; //default value
            string? svgWidth = "400"; //default value

            string svgOpening = String.Format(@"<svg height=""{0}"" width=""{1}"" xmlns=""http://www.w3.org/2000/svg"">", svgHeight, svgWidth);

            string svgOpen = svgOpening + Environment.NewLine;
            string svgClose = @"</svg>";

            while (programRun == true) //keeps program on
            {
                ForegroundColor = ConsoleColor.Red; WriteLine("Shape SVG CLI V2"); WriteLine("By: e-adzg"); ResetColor();
                ForegroundColor = ConsoleColor.Blue; WriteLine("===================================="); ResetColor();

                Canvas canvas = new Canvas(); //creates canvas
                User user = new User(); //creates user
                ShapeFactory factory = new ShapeFactory();

                while (userInput == true) //this will let the user keep entering as many inputs while this is true
                {
                    string? userRead = ReadLine();

                    if (userRead != null) // checks if null for the split to work
                    {
                        string[] parts = userRead.Split(' '); //splits the shape and A
                        if (parts[0] == "A") //if this is A, then the user wants to add a shape
                        {
                            ForegroundColor = ConsoleColor.Blue; WriteLine("\nWould you like to style the " + parts[1] + " manually or apply style 1, 2 or 3, or randomly generate?"); ResetColor();
                            ForegroundColor = ConsoleColor.Blue; WriteLine("TYPE: M, 1, 2, 3 or R:"); ResetColor();
                            string? userStyle = ReadLine();

                            while (userStyle != "M" && userStyle != "1" && userStyle != "2" && userStyle != "3" && userStyle != "R") //keep asking for input if none of the options are inputted
                            {
                                ForegroundColor = ConsoleColor.Red; WriteLine("\nInvalid Input!\n"); ResetColor();
                                ForegroundColor = ConsoleColor.Blue; WriteLine("TYPE: M, 1, 2, 3 or R:"); ResetColor();
                                userStyle = ReadLine();
                            }
                            factory.generateShape(user, canvas, parts[1], userStyle); //send the info to the factory to make the shape 
                        }
                        else if (parts[0] == "R") //add a shape randomly
                        {
                            factory.generateShape(user, canvas, parts[1], parts[0]); //send the info to the factory to make the shape! 
                        }
                        else
                        {
                            switch (userRead) //this is a long switch case for every input possible that the user can enter
                            {   //these shapes are using methods in which the user and canvas are being sent
                                case "V": //change canvas size
                                    svgHeight = ChangeCanvasHeight(svgHeight);
                                    svgWidth = ChangeCanvasWidth(svgWidth);
                                    svgOpening = String.Format(@"<svg height=""{0}"" width=""{1}"" xmlns=""http://www.w3.org/2000/svg"">", svgHeight, svgWidth);
                                    svgOpen = svgOpening + Environment.NewLine;
                                    ForegroundColor = ConsoleColor.Green; WriteLine("\nCanvas Updated!\n"); ResetColor();
                                    break;

                                case "E": //export
                                    userInput = false;
                                    Export(svgOpen, svgClose, canvas);
                                    break;

                                case "exit": //exit
                                    userInput = false;
                                    ForegroundColor = ConsoleColor.Green; WriteLine("\nGoodbye!\n"); ResetColor();
                                    break;

                                case "Q": //exit
                                    userInput = false;
                                    ForegroundColor = ConsoleColor.Green; WriteLine("\nGoodbye!\n"); ResetColor();
                                    break;

                                case "H": //display help
                                    ForegroundColor = ConsoleColor.Green; WriteLine("\nCommands:"); ResetColor();
                                    WriteLine("H               Help - displays this message\nA <shape>       Add <shape> to canvas\nR <shape>       Add <shape> with random values to canvas\nS               See list of shapes\nT               Delete Last Shape\nU               Undo last operation\nR               Redo last operation\nV               Change Canvas Size\nD               Display canvas to console\nE               Export canvas\nO               Clear Console\nQ               Quit application\n");
                                    break;

                                case "S": //display list of shapes you can add
                                    ForegroundColor = ConsoleColor.Green; WriteLine("\nList of Shapes:"); ResetColor();
                                    WriteLine("A rectangle\nA circle\nA ellipse\nA line\nA path\nA polygon\nA polyline\n");
                                    break;

                                case "D": //display the svg to console
                                    ForegroundColor = ConsoleColor.Green; WriteLine("\nDisplaying SVG To Console:\n"); ResetColor();
                                    WriteLine(svgOpen);
                                    WriteLine(canvas);
                                    WriteLine(svgClose + "\n");
                                    break;

                                case "T": //delete command
                                    try
                                    {
                                        user.Action(new DeleteShapeCommand(canvas));
                                    }
                                    catch
                                    {
                                        ForegroundColor = ConsoleColor.Red; WriteLine("\nERROR: Shape could not be deleted!\n"); ResetColor();
                                    }
                                    break;

                                case "U": //undo command
                                    user.Undo();
                                    break;

                                case "R": //redo command
                                    user.Redo();
                                    break;

                                case "O": //clear console command
                                    Clear();
                                    break;

                                case "hello": //hello
                                    ForegroundColor = ConsoleColor.DarkMagenta; WriteLine("\nHello!\n"); ResetColor();
                                    break;

                                default: //default case if user does not enter any other case
                                    ForegroundColor = ConsoleColor.Red; WriteLine("\nInvalid Input! - Type 'H' for commands!\n"); ResetColor();
                                    break;
                            }
                        }
                    }
                }
                programRun = false;
            }
        }
        public static void Export(string? svgOpen, string? svgClose, Canvas canvas) //~ EXPORT
        {
            ForegroundColor = ConsoleColor.Blue; WriteLine("\nEnter File Name:"); ResetColor();
            string? svgName = ReadLine();
            File.WriteAllText(@"./" + svgName + ".svg", svgOpen + Environment.NewLine + canvas.ToString() + Environment.NewLine + svgClose);
            ForegroundColor = ConsoleColor.Green; WriteLine("\nSVG Exported!\n"); ResetColor();
        }
        public static string? ChangeCanvasHeight(string? svgHeight) //~ CHANGE CANVAS HEIGHT
        {
            ForegroundColor = ConsoleColor.Blue; WriteLine("\nEnter Canvas Height:"); ResetColor();
            string? userSvgHeight = ReadLine();
            return userSvgHeight;
        }
        public static string? ChangeCanvasWidth(string? svgWidth) //~ CHANGE CANVAS WIDTH
        {
            ForegroundColor = ConsoleColor.Blue; WriteLine("Enter Canvas Width:"); ResetColor();
            string? userSvgWidth = ReadLine();
            return userSvgWidth;
        }
    }
}