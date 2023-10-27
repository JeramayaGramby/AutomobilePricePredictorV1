﻿
// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.VisualBasic;
using MLTrained_AutomobilePricePredictor;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

// Create single instance of sample data from first line of dataset for model input
// The "F" stays after the numeric value
// Make the user input equal the values inside the struct
// Change the variables to equal the input variables
// Put everything into a class with two separate functions
// One for handling user input
// One for displaying user input


public class ModelConsumption
{
    static void main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the model year of the vehicle:");
            Single year = Convert.ToSingle(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("Enter the mileage of the vehicle:");
            Single mileage = Convert.ToSingle(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("Enter the vehicle manufacturer");
            string make = Convert.ToString(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("Enter the vehicle model:");
            string model = Convert.ToString(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("Enter the city where the vehicle is located:");
            string city = Convert.ToString(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("Enter the state of where the vehicle is located (Example: TX, PA):");
            string state = Convert.ToString(Console.ReadLine());
            Console.ReadKey();
            // Put something in here that constructs an object for Model.predict()
            // Log that to the console

        }
        
        // The two most likely exceptions to be thrown are NullReferenceException and ArgumentException 

        catch (NullReferenceException e)
        {
            Console.WriteLine("Something went wrong. Please restart the predictor.");
            Console.WriteLine(e);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("Something went wrong. Please restart the predictor.");
            Console.WriteLine(e);
        }

    }
}
        

    
