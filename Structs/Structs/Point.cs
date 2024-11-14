// Import the System namespace for basic input/output functions
using System;

// Define a namespace called Structs.Structs to organize the code logically
namespace Structs.Structs
{
    // Define a public struct named Point
    public struct Point
    {
        // Create two properties
        //public int X { get; set; }
        //public int Y { get; set; } 

        // Fields to store the x and y coordinates of the point
        // (Previously declared as properties with get and set methods, but changed to fields for simplicity)
        public int X;
        public int Y;

        // Constructor for the Point struct
        // Initializes the fields X and Y with the values provided as parameters
        public Point(int x, int y)
        {
            X = x; // Assign the value of the x parameter to the X field
            Y = y; // Assign the value of the y parameter to the Y field
        }

        // Method to display the coordinates of the point
        public void Display()
        {
            // Print the X and Y coordinates in the format: Point: (X, Y)
            Console.WriteLine($"Point: ({X}, {Y})");
        }
    }
}
