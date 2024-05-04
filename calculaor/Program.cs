using System.ComponentModel.Design;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("opeator");
            string op = Console.ReadLine();

            Console.WriteLine("Enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();

            if (op == "+") 
            {
                Console.WriteLine(num1 + num2);
            }
            
            else if(op == "-") {
                Console.WriteLine(num1-num2);


            }
            else if (op == "*")
            {
                Console.WriteLine(num1 *num2);


            }
            else
            {
                Console.WriteLine(num2 / num1);
            }
        }
    }
}
