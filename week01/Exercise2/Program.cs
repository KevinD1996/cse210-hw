using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("What is your grade degree?");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);
        string letter = "";

        if (grade >= 90)
         {
            letter = "A";
            }
                
        else if (80 >= grade)
        {
            letter = "B";
            }
            
        else if (70 >= grade)
        {
            letter = "C";
            }
               
        else if (60 >= grade)
        {
            letter = "D";
            }
               
        else  
        {
            letter = "F";
            }
        int TheLastDigit = grade % 10;

        string sign = "";

        if (TheLastDigit >= 5)
        {
            sign = "+";

        } 
        else if (TheLastDigit < 3)
        {
            sign = "-";

        }
        if (grade >= 93)
        {
            sign = ""; 
        }
        if (letter == "F")
        {
            sign = "";
        }
        

         Console.WriteLine($"Your grade is {sign}{letter}");
        

          if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }   
    }
}

