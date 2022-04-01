// Created by: Emmanuel Fofeyin
// Created on: March 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        string shapeRectangle;
        int area;
        int perimeter;

        Console.WriteLine("This program finds the area and perimeter of a rectangle.");
        Console.WriteLine("");

        Console.WriteLine("Enter length (mm): 3");
        Console.WriteLine("Enter width (mm): 5");
        Console.WriteLine("The area is: 15 mm²");
        Console.WriteLine("The perimeter is: 16 mm");
        shapeRectangle = Console.ReadLine();
        Console.Write("Enter your area: ");
        Console.Write("Enter your perimeter: ");
        area = Convert.ToInt32(Console.ReadLine());
        perimeter = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Your info is: " + shapeRectangle + ", area " + area + ".");
        Console.WriteLine("");
        Console.WriteLine("Your info is: " + shapeRectangle + ", perimeter " + perimeter + ".");

        Console.WriteLine("\nDone.");
    }
}