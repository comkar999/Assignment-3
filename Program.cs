using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   
        public delegate double AdditionDelegate(double number);
        public delegate double SubstractionDelegate(double number);
        public delegate double MultiplicationDelegate(double number);
        public delegate void MCDelegate();
        class Program
        {
            static void Main(string[] args)
            {

                
                
                   
                        Program p4 = new Program();
                        MCDelegate mc1 = new MCDelegate(p4.Addition);
                        MCDelegate mc2 = new MCDelegate(p4.Substraction);
                        MCDelegate mc3 = new MCDelegate(p4.Multiplication);
                        MCDelegate mc4 = mc1 + mc2 + mc3;
                        
                        mc4();
                        Console.ReadLine();

            }

            public void Addition()
            {
                Console.WriteLine("Addition is performed");
            }

            public void Substraction()
            {
                Console.WriteLine("Substraction is performed");
            }

            public void Multiplication()
            {
               Console.WriteLine( "Multiplication is performed");
            }


        }
    }


