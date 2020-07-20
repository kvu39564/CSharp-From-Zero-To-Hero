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
                              "and his height is " + height + " cm.\n");
            Console.WriteLine(firstName + "'s BMI is " + bmi);
        }

        //Calculating BMI (weight comes in kg, height comes in meters),
        static public float CaculateBmi(float weight, float height)
        {
            return weight / (float) Math.Pow((height), 2);
        }

        //Prompt for input and converting it to int (print message for request, 
        //read console input and return converted input to int),
        static public int PromptInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        //Prompt for input and converting it to string (print message for request, 
        //read console input and return input),
        static public string PromptString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        //Prompt for input and converting it to float (print message for request, 
        //read console input and return converted input to float).
        static public float PromptFloat(string message)
        {
            Console.Write(message);
            return float.Parse(Console.ReadLine());
        }
    }
}
