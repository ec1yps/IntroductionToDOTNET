//#define DATA_TYPES
#define FACTORIAL
//#define CALCULATOR
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DataTypes
{
	internal class Program
	{
		static readonly string delimiter = "\n---------------------------------------------------\n";
		static void Main(string[] args)
		{ 

#if DATA_TYPES
			Console.WriteLine("Hello DataTypes");
			#region Bool
			/*Console.WriteLine(sizeof(bool));
				Console.WriteLine(true);
				Console.WriteLine(false);
				Console.WriteLine(bool.FalseString);*/
			#endregion

			//Console.WriteLine(sizeof(char));

			Console.WriteLine("Byte: ");
			Console.WriteLine(sizeof(byte));
			Console.WriteLine(byte.MinValue);
			Console.WriteLine(byte.MaxValue);
			Console.WriteLine(delimiter);

			Console.WriteLine("SByte: ");
			Console.WriteLine(sizeof(sbyte));
			Console.WriteLine(sbyte.MinValue);
			Console.WriteLine(sbyte.MaxValue);
			Console.WriteLine(delimiter);

			Console.WriteLine("Decimal: ");
			Console.WriteLine(sizeof(decimal));
			Console.WriteLine(decimal.MinValue);
			Console.WriteLine(decimal.MaxValue);
			Console.WriteLine(delimiter);

			int a = 2000000000;
			int b = 4;
			try
			{
				Console.WriteLine((a * b).GetType());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			} 
#endif
			
#if FACTORIAL
			Console.Write("Введите число: ");
			int n = Convert.ToInt32(Console.ReadLine());
			
			try
			{
				
				decimal factorial = 1;
				for (int i = 1; i <= n; i++)
				{
					factorial *= i;
				}
				Console.WriteLine(n + "! = " + factorial);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
#endif

#if CALCULATOR
			double value_1, value_2;
			char operation;

            Console.Write("Введите опрецию: ");
			operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Введите первое значение: ");
			value_1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Введите второе значение: ");
			value_2 = Convert.ToDouble(Console.ReadLine());

			switch(operation)
			{
				case '+':
					Console.WriteLine(value_1 + " + " + value_2 + " = " + (value_1 + value_2));
					break;
				case '-':
					Console.WriteLine(value_1 + " - " + value_2 + " = " + (value_1 - value_2));
					break;
				case '*':
					Console.WriteLine(value_1 + " * " + value_2 + " = " + (value_1 * value_2));
					break;
				case '/':
					if (value_2 != 0)
						Console.WriteLine(value_1 + " / " + value_2 + " = " + (value_1 / value_2));
					else
						Console.WriteLine("Error: Division by zero");
					break;
				default: 
					Console.WriteLine("Неверный оператор");
					break;
			}
#endif
		}
	}
}
