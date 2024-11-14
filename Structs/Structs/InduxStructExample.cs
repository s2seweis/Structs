// Import necessary namespaces for basic functionality and collections
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define a namespace called Structs.Structs to logically group related classes
namespace Structs.Structs
{
    // Define an internal class named InduxStructExample
    // Internal means it is accessible only within the same assembly
    internal class InduxStructExample
    {
        // Constructor for the InduxStructExample class
        // This constructor is called when an instance of InduxStructExample is created
        public InduxStructExample()
        {
            // Call the private method InduxStructExampleMethod

            InduxStructExampleMethod();
        }

        // Private method that demonstrates the usage of the Point struct
        private void InduxStructExampleMethod()
        {
            // Create an instance of Point using the constructor

            Point p1 = new Point(10, 20);

            // Uncomment the line below to display the coordinates of p1
            // p1.Display();

            // Create another instance of Point without using the constructor
            // Instead, initialize the fields directly

            Point p2;
            p2.X = 10; // Assign a value to the X field of p2
            p2.Y = 20; // Assign a value to the Y field of p2

            // Display the coordinates of p2

            p2.Display();

            Point p3 = p1;
            p3.X = 50;
            p1.Display();
            p3.Display();

            //We only passed on the values from P1 to P3
        }
    }
}

/*
Key Differences Between Structs and Classes:
Value Type vs Reference Type:

Structs are value types, meaning that when you create a struct or pass it to a method, a copy of the data is created. Each struct is independent of the original.
Classes are reference types, meaning that when you create a class instance or pass it to a method, you are working with a reference to the object, not a copy of the data. This means that changes to the object affect all references to that object.
Memory Allocation:

Structs are allocated on the stack (if local), and their data is stored directly. This can lead to better performance for small, lightweight objects because there is no need for heap allocation or garbage collection.
Classes are allocated on the heap, and a reference to the class object is stored on the stack. This involves additional overhead for memory allocation and garbage collection.
Default Constructor:

Structs cannot have an explicit default constructor. They always have an implicit default constructor that initializes all fields to their default values (e.g., 0 for numbers).
Classes can have explicit constructors and can have more complex initialization.
Inheritance:

Structs do not support inheritance, meaning they cannot inherit from another struct or class (except from interfaces).
Classes support inheritance, so you can derive one class from another, allowing for more flexible object-oriented design.
Immutability:

Structs are often used for immutable types (e.g., Point, DateTime), where the values are set once and not modified afterward.
Classes can be either mutable or immutable depending on how they are designed, offering more flexibility.

 */