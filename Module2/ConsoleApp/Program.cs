// Caleb Frye 
// 12/9/24
// PA2


using System;

class Program
{
    static void Main()
    {

        // task2.1
        #region Task2 Part 1 
        // Declare an int variable and set it to the max value
        int maxValue = int.MaxValue;

        // Print the value both as a normal int and in its Hex format as shown below
        Console.WriteLine($"INT Max Value: {maxValue}");
        Console.WriteLine($"Int Max Value (HEX): {maxValue:X}");

        // Increment the variable by one
        maxValue++;
        Console.WriteLine($"\nAfter Incrementing by 1:");
        Console.WriteLine($"Int Value: {maxValue}");
        Console.WriteLine($"Int Max Value (HEX): {maxValue:X}");

        // Set the variable to 0 and print its value
        maxValue = 0;
        Console.WriteLine($"\nSet to 0:");
        Console.WriteLine($"Int Value: {maxValue}");
        Console.WriteLine($"Int Value (HEX): {maxValue:X}");

        // Decrement the variable by one and print its value.
        maxValue--;
        Console.WriteLine($"\nAfter Decrementing by 1:");
        Console.WriteLine($"Int Value: {maxValue}");
        Console.WriteLine($"Int Value (HEX): {maxValue:X}");
        #endregion

        // Create a new region named "Casting" for this section
        #region Casting 

        // Assign the max value to your int variable.
        int intValue = int.MaxValue;

        // Declare a short variable initialize its value to the int variable
        short shortValue = (short)intValue;

        // Print the int variable as a number and in the hexadecimal format.
        Console.WriteLine($"\nCasting Section");
        Console.WriteLine($"Int Max Value: {intValue:X}");
        Console.WriteLine($"Int Value (HEX): {intValue:X}");

        // Print the short variable as a number and in the hexadecimal format.
        Console.WriteLine($"Short Value after casting: {shortValue}");
        Console.WriteLine($"Short Value (HEX): {shortValue:X}");
        #endregion

        // Create a new region named "Loops".
        #region Loops 

        // Declare an array of ints of size 5.
        int[] numbers = new int[5];

        // Use a for loop to initialize the values in the range of 1 to 5
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }

        // Use a foreach loop to print the array values on a single line. 
        Console.WriteLine("\nArray values:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number + " ");
        }
        Console.WriteLine();
        #endregion

        // Create a new region named "Loop bonus".
        #region Loop bonus 

        // Create and print a multiplication table.
        Console.WriteLine("\nMultiplication table (1 to 5):");
        for (int i = 0; i <= 5; i++)
        { 
            for (int j = 1; j <= 5; j++)
            {
                Console.WriteLine($"{i * j}\t");
            }
            Console.WriteLine();
        }
        #endregion

        // Create a region named "Printer troubleshooter"
        #region Printer troubleshooter 

        // Create a region named "Printer troubleshooter"
        string condition = "";

        // Ask the first question and based on the answer update the condition variable (i.e. concatenate a 'Y' or a 'N' to the string)
        Console.WriteLine("\nIs the printer on? (Y/N)");
        string answer1 = Console.ReadLine();
        condition += answer1.ToUpper() == "Y" ? "Y" : "N";

        // Ask the next question 
        Console.WriteLine("Does the printer have paper? (Y/N)");
        string answer2 = Console.ReadLine();
        condition += answer2.ToUpper() == "Y" ? "Y" : "N";

        // Ask the last question
        Console.WriteLine("Is there a paper jam? (Y/N)");
        string answer3 = Console.ReadLine();
        condition += answer3.ToUpper() == "Y" ? "Y" : "N";

        // Test to see if you code works by printing out the value of the condition variable. If your code is working you can comment out this statement.
        // Console.WriteLine($"\nCondition String: {condition}");

        // Create the switch statement with all 8 possibilities.
        switch (condition)
        {
            case "YYY":
                Console.WriteLine("No problems detected.");
                break;
            case "YYN":
                Console.WriteLine("Check for other issues. Printer seems fine. ");
                break;
            case "YNY":
                Console.WriteLine("Check for a paper jam. ");
                break;
            case "YNN":
                Console.WriteLine("Load paper into the printer.");
                break;
            case "NYY":
                Console.WriteLine("Turn on the printer.");
                break;
            case "NYN":
                Console.WriteLine("Turn on the printer and load paper.");
                break;
            case "NNY":
                Console.WriteLine("Turn on the printer and check for papare jam.");
                break;
            case "NNN":
                Console.WriteLine("Turn on the printer and load paper.");
                break;
            default:
                Console.WriteLine("Invalid input. Please answer with 'Y' or 'N'.");
                break;
        }
        #endregion

    }

}
