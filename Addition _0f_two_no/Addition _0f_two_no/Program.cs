using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static void Main()
        {
        Console.Write("Enter Your first number:= ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Your second number:= ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int result = num1 + num2;
        Console.WriteLine($"\nYour result is = {result}");
        Console.ReadLine();
    }
    }

