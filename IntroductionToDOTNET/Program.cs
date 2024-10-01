//#define CONSOLE_CLASS
//#define STRING_OPERATIONS
//#define GEOMETRY
//#define HARD_CHESS
#define CHESS

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
	internal class Program
	{
		static readonly string delimiter = "\n-------------------------------------------------------\n";

		const char UPPER_LEFT_ANGLE = '┌';
		const char UPPER_RIGHT_ANGLE = '┐';
		const char LOWER_LEFT_ANGLE = '└';
		const char LOWER_RIGHT_ANGLE = '┘';
		const char VERTICAL_LINE = '│';
		const string HORIZONTAL_LINE = "──";
		const string BLOCK = "██";
		const string PROBEL = "  ";

		static void Main(string[] args)
		{
			Console.SetBufferSize(120, 1000);
#if CONSOLE_CLASS
			Console.Title = "Introduction to .NET";
			Console.WriteLine("\t\t\tHello .NET");
			//Console.CursorLeft = 25;
			//Console.CursorTop = 8;
			Console.SetCursorPosition(21, 5);
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("Привет .NET");
			Console.ResetColor();

			Console.WriteLine(delimiter);

			Console.WriteLine("Позиция окна консоли: " + Console.WindowLeft + " знакопозиций");
			Console.WriteLine("Позиция окна консоли: " + Console.WindowTop + " знакопозиций");

			Console.SetWindowSize(120, 30);
			Console.WriteLine("Ширина окна консоли: " + Console.WindowWidth + " знакопозиций");
			Console.WriteLine("Высота окна консоли: " + Console.WindowHeight + " знакопозиций");

			Console.SetBufferSize(120, 10000);
			Console.WriteLine("Ширина буфера консоли: " + Console.BufferWidth + " знакопозиций");
			Console.WriteLine("Высота буфера консоли: " + Console.BufferHeight + " знакопозиций"); 
#endif

#if STRING_OPERATIONS
			Console.Write("Введите Ваше имя: ");
			string first_name = Console.ReadLine();

			Console.Write("Введите Вашу фамилию: ");
			string last_name = Console.ReadLine();

			Console.Write("Введите Ваш возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(first_name + " " + last_name + " " + age);    //Конкатенация строк
			Console.WriteLine(String.Format("{0} {1} {2}", first_name, last_name, age));    //Форматирование строк
			Console.WriteLine($"{first_name} {last_name} {age}");   //Интерполяция строк  
#endif

#if GEOMETRY
			Console.Write("Введите размер фигур: ");
			int n = Convert.ToInt32(Console.ReadLine());

			//Square
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
					Console.Write(" *");
				Console.WriteLine();
			}
			Console.WriteLine();

			//Triangle 1
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++)
					Console.Write(" *");
				Console.WriteLine();
			}
			Console.WriteLine();

			//Triangle 2
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n; j++)
					Console.Write(" *");
				Console.WriteLine();
			}
			Console.WriteLine();

			//Triangle 3
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
					Console.Write(j < i ? "  " : " *");
				Console.WriteLine();
			}
			Console.WriteLine();

			//Triangle 4
			for (int i = 4; i >= 0; i--)
			{
				for (int j = 0; j < n; j++)
					Console.Write(j >= i ? " *" : "  ");
				Console.WriteLine();
			}
			Console.WriteLine();

			//Rhombus
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n; j++) Console.Write(" ");
				Console.Write("/");
				for (int j = 0; j < i; j++) Console.Write("  ");
				Console.WriteLine("\\");
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < i; j++) Console.Write(" ");
				Console.Write(" \\");
				for (int j = i + 1; j < n; j++) Console.Write("  ");
				Console.WriteLine("/");
			} 

			//Square +-
			for(int i = 0;i < n; i++)
			{
				for (int j = 0; j < n; j++)
					Console.Write(i % 2 == j % 2 ? "+ " : "- ");
                Console.WriteLine();
            }
#endif

#if HARD_CHESS
			Console.Write("Введите размер доски: ");
			int n = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < n; i++)
				for (int j = 0; j < n; j++)
				{
					for (int k = 0; k < n; k++)
						for (int l = 0; l < n; l++)
							Console.Write(k % 2 == i % 2 ? "* " : "  ");
					Console.WriteLine();
				} 
#endif

#if CHESS
			Console.Write("Введите размер доски: ");
			int n = Convert.ToInt32(Console.ReadLine());
			n++;

			for (int i = 0; i <= n; i++)
			{
				for (int j = 0; j <= n; j++)
				{
					if (i == 0 && j == 0) Console.Write(UPPER_LEFT_ANGLE);
					else if (i == 0 && j == n) Console.Write(UPPER_RIGHT_ANGLE);
					else if (i == n && j == 0) Console.Write(LOWER_LEFT_ANGLE);
					else if (i == n && j == n) Console.Write(LOWER_RIGHT_ANGLE);
					else if (i == 0 || i == n) Console.Write(HORIZONTAL_LINE);
					else if (j == 0 || j == n) Console.Write(VERTICAL_LINE);
					else Console.Write(i % 2 == j % 2 ? BLOCK : PROBEL);
				}
				Console.WriteLine();
			} 
#endif

		}
	}
}
