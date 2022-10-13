// A simple computer quiz game that uses if-else and increement
using System;
class Program
{
    static void Main(string[] args)
    {
        int score = 0;
        Console.WriteLine("Welcome to my Computer Quiz Game");
        Console.WriteLine("---------------------------------");
        Console.Write("1.What does CPU stand for? ");
        string question1 = Console.ReadLine();
        if (question1 == "central processing unit")
        {
            Console.WriteLine("-----------");
            Console.WriteLine("| Correct |");
            Console.WriteLine("-----------");
            question1 += score++;
        }
        else
        {
            Console.WriteLine("-----------");
            Console.WriteLine("| Wrong |");
            Console.WriteLine("-----------");
        }
        Console.Write("2.What does RAM stand for? ");
        string question2 = Console.ReadLine();
        if (question2 == "random access memory")
        {
            Console.WriteLine("-----------");
            Console.WriteLine("| Correct |");
            Console.WriteLine("-----------");
            question2 += score++;
        }
        else
        {
            Console.WriteLine("-----------");
            Console.WriteLine("| Wrong |");
            Console.WriteLine("-----------");
        }
        Console.Write("3.What does HDD stand for? ");
        string question3 = Console.ReadLine();
        if (question3 == "hard disk drive")
        {
            Console.WriteLine("-----------");
            Console.WriteLine("| Correct |");
            Console.WriteLine("-----------");
            question3 += score++;
        }
        else
        {
            Console.WriteLine("-----------");
            Console.WriteLine("| Wrong |");
            Console.WriteLine("-----------");
        }
        Console.Write("4.What does CRT stand for? ");
        string question4 = Console.ReadLine();
        if (question4 == "cathode ray tube")
        {
            Console.WriteLine("-----------");
            Console.WriteLine("| Correct |");
            Console.WriteLine("-----------");
            question4 += score++;
        }
        else
        {
            Console.WriteLine("-----------");
            Console.WriteLine("| Wrong |");
            Console.WriteLine("-----------");
        }
        Console.Write("5.What does Wi-Fi stand for? ");
        string question5 = Console.ReadLine();
        if (question5 == "wireless fidelity")
        {
            Console.WriteLine("-----------");
            Console.WriteLine("| Correct |");
            Console.WriteLine("-----------");
            question5 += score++;
        }
        else
        {
            Console.WriteLine("-----------");
            Console.WriteLine("| Wrong |");
            Console.WriteLine("-----------");
        }
        Console.WriteLine("---------------------------------");
        Console.WriteLine("-------------------");
        Console.WriteLine("| You got " + score + " score |");
        Console.WriteLine("-------------------");
    }
}