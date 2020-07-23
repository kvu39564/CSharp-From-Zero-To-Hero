using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            string firstName;
            string lastName;
            int age;
            float weight;
            float height;
            float bmi;

            firstName = PromptString("Enter your first name: ");
            lastName = PromptString("Enter your last name: ");

            age = PromptInt("Enter your age: ");

            weight = PromptFloat("Enter your weight (kg): ");
            height = PromptFloat("Enter your height (m): ");

            bmi = CaculateBmi(weight, height);

            Console.WriteLine("\n" + firstName + " " + lastName + " is " + age + " years old, " +
                              "his weight is " + weight + " kg " +
                              "and his height is " + (height * 100) + " cm.\n");
            Console.WriteLine(firstName + "'s BMI is " + bmi);
        }

        //Calculating BMI (weight comes in kg, height comes in meters),
        public static float CaculateBmi(float weight, float height)
        {
            if(weight <= 0 || height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");

                if (weight <= 0)
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                }

                if (height <= 0)
                {
                    Console.Write("Height cannot be ");

                    if (height <= 0 && weight > 0)
                    {
                        Console.Write("equal or ");
                    }

                    if (height <= 0)
                    {
                        Console.Write("less than zero, ");
                    }

                    Console.WriteLine($"but was {height}.");
                }

                return -1;
            }

            return weight / (float)Math.Pow((height), 2);
        }

        //Prompt for input and converting it to int (print message for request, 
        //read console input and return converted input to int),
        public static int PromptInt(string message)
        {
            string input = "";
            int number = 0;

            Console.WriteLine(message);

            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) return 0;

            bool isNumber = int.TryParse(input, out number);

            if(!isNumber)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }

            return number;
        }

        //Prompt for input and converting it to string (print message for request, 
        //read console input and return input),
        public static string PromptString(string message)
        {
            string input = "";

            Console.WriteLine(message);

            input = Console.ReadLine();
            bool isString = string.IsNullOrEmpty(input);

            if (!isString)
            {
                return input;
            }

            Console.Write("Name cannot be empty.");
            return "-";
        }

        //Prompt for input and converting it to float (print message for request, 
        //read console input and return converted input to float).
        public static float PromptFloat(string message)
        {
            string input = "";
            float number = 0.0f;

            Console.WriteLine(message);

            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) return 0;

            bool isNumber = float.TryParse(input, out number);

            if (!isNumber)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }

            return number;
        }
    }
}