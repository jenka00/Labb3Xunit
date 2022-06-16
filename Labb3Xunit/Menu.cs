using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3Xunit
{
    public class Menu
    {
        public List<string> Calculations = new List<string>();
        Calculator cal = new Calculator();
        bool showMenu = true;
        public void ShowMenu()
        {               
            do
            {
                Console.WriteLine("Vilken räknesätt vill du använda? Gör ett val ur nedanstående menyn genom att ange en siffra.");
                Console.WriteLine(
                    "1. Addition" +
                    "\n2. Subtraktion" +
                    "\n3. Multiplikation" +
                    "\n4. Division" +
                    "\n5. Visa alla tidigare uträkningar" +
                    "\n6. Avsluta");
                string input = Console.ReadLine();
                switch (input)
                {                    
                    case "1":
                        double firstNumber = GetNumber();
                        double secondNumber = GetNumber();
                        double result = cal.Add(firstNumber, secondNumber);
                        string sign = "+";
                        PrintSum(result);
                        SaveCalculation(firstNumber, secondNumber, result, sign);
                        break;
                    case "2":
                        firstNumber = GetNumber();
                        secondNumber = GetNumber();
                        result = cal.Subtract(firstNumber, secondNumber);
                        sign = "-";
                        PrintSum(result);
                        SaveCalculation(firstNumber, secondNumber, result, sign);
                        break;
                    case "3":
                        firstNumber = GetNumber();
                        secondNumber = GetNumber();
                        result = cal.Multiply(firstNumber, secondNumber);
                        sign = "*";
                        PrintSum(result);
                        SaveCalculation(firstNumber, secondNumber, result, sign);
                        break;
                    case "4":
                        firstNumber = GetNumber();
                        secondNumber = GetNumber();
                        result = cal.Divide(firstNumber, secondNumber);
                        sign = "/";
                        PrintSum(result);
                        SaveCalculation(firstNumber, secondNumber, result, sign);
                        break;
                    case "5":
                        PrintAllCalculations();
                        break;
                    case "6":
                        showMenu = false;
                        break;
                    default:
                        Console.WriteLine("Felaktigt val");
                        break;
                }
                Console.WriteLine("Vill du fortsätta räkna? j/n");
                string answer = Console.ReadLine();
                if(answer == "n" || answer == "N" )
                {
                    showMenu = false;
                }
                Console.Clear();
            }
            while (showMenu != false);
        }
        public double GetNumber()
        {
            Console.WriteLine("Ange ett tal");
            double t1 = double.Parse(Console.ReadLine());
            return t1;
        }
        public void PrintSum(double sum)
        {
            Console.WriteLine($"Resultatet är {sum}");
        }
        public void SaveCalculation(double firstNumber, double secondNumber, double result, string sign)
        {
            Calculations.Add($"{firstNumber} {sign} {secondNumber} = {result}");                       
        }
        public bool PrintAllCalculations()
        {
            if(Calculations.Count < 1)
            {
                Console.WriteLine("Du har inga tidigare uträkningar.");
                return false;
            }
            Console.WriteLine("Uträkningar:");
            foreach (var calculation in Calculations)
            {
                Console.WriteLine(calculation);                
            }
            return true;
        }
    }
}
        
  