using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите арифметическое выражение: ");
			string expression = Console.ReadLine();
			expression = expression.Replace('.', ',');
			//Console.WriteLine(expression);

			char[] delimiters = { '+', '-', '*', '/' };
			string[] numbers = expression.Split(delimiters);

			try
			{
				double a = Convert.ToDouble(numbers[0]);
				double b = Convert.ToDouble(numbers[1]);

				#region IFcalc
				/*if(expression.Contains("+")) Console.WriteLine($"{a} + {b} = {a+b}");
					else if(expression.Contains("-")) Console.WriteLine($"{a} - {b} = {a-b}");
					else if(expression.Contains("*")) Console.WriteLine($"{a} * {b} = {a*b}");
					else if(expression.Contains("/")) Console.WriteLine($"{a} / {b} = {a/b}");*/
				#endregion

				switch (expression[expression.IndexOfAny(delimiters)])
				{
					case '+': Console.WriteLine($"{numbers[0]} + {numbers[1]} = {a + b}"); break;
					case '-': Console.WriteLine($"{numbers[0]} - {numbers[1]} = {a - b}"); break;
					case '*': Console.WriteLine($"{numbers[0]} * {numbers[1]} = {a * b}"); break;
					case '/': Console.WriteLine($"{numbers[0]} / {numbers[1]} = {a / b}"); break;
				}
			}
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
            }

				Main(args);
		}
	}
}
