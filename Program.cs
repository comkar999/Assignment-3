using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAssignment3
{
    public delegate double AdditionDelegate(double number);
    public delegate double SubstractionDelegate(double number);
    public delegate double MultiplicationDelegate(double number);
    public delegate double MCDelegate(double number);
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the operation you wanna perform");
            string operation=  Console.ReadLine();
            switch(operation)
            {
                case "Addition":
                    Program p1 = new Program();
                    AdditionDelegate ad = new AdditionDelegate(p1.Addition);
                    Console.WriteLine("Enter the number for addition operation");
                    double number1= double.Parse(Console.ReadLine());
                    Console.WriteLine(ad(number1));
                    break;

                case "Substraction":
                    Program p2 = new Program();
                    SubstractionDelegate sb = new SubstractionDelegate(p2.Substraction);
                    Console.WriteLine("enter the number for substraction operation");
                    double number2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(sb(number2));
                    break;
                case "Multiplication":
                    Program p3 = new Program();
                    MultiplicationDelegate md = new MultiplicationDelegate(p3.Multiplication);
                    Console.WriteLine("enter the number for multipication operation");
                    double number3 = double.Parse(Console.ReadLine());
                    Console.WriteLine(md(number3));
                    break;
                case "MultipleOperations":
                    Program p4 = new Program();
                    MCDelegate mc1 = new MCDelegate(p4.Addition);
                    MCDelegate mc2 = new MCDelegate(p4.Substraction);
                    MCDelegate mc3 = new MCDelegate(p4.Multiplication);
                    MCDelegate mc4 = mc1 + mc2 + mc3;
                    Console.WriteLine("enter the number for the multiple operation");
                    double number4 = double.Parse(Console.ReadLine());
                    Console.WriteLine(mc4(number4));
                    break;

                default:

                    Console.WriteLine("default case executed");
                    break;


            }

            Console.ReadLine();

        }

        public double Addition(double number)
        {
            return number + number;
        }

        public double Substraction(double number)
        {
            return number - 2;
        }

        public double Multiplication(double number)
        {
            return number * 2;
        }

       
    }
}
