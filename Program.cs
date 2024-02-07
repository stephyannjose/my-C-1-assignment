using System;

// Define a class named MathOperations
class MathOperations
{
    // Define a void method named PerformOperation that takes two integers as parameters
    public void PerformOperation(int num1, int num2)
    {
        // Perform a math operation on the first integer (num1)
        // For demonstration, let's simply add 10 to num1
        int result = num1 + 10;

        // Display the second integer (num2) to the console
        Console.WriteLine($"Second Integer: {num2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the MathOperations class
        MathOperations mathObj = new MathOperations();

        // Call the PerformOperation method in the class, passing in two numbers (5 and 20)
        mathObj.PerformOperation(5, 20);

        // Call the PerformOperation method in the class, specifying the parameters by name
        // This provides clarity and allows specifying the parameters in any order
        mathObj.PerformOperation(num2: 30, num1: 8);
    }
}
