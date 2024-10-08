//#define ARRAYS_1
//#define ARRAYS_2
#define JAGGED_ARRAY
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if ARRAYS_1
			Console.Write("Введитее размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			//int[] arr = new[] { 3, 5, 8, 13, 21 };
			int[] arr = new int[n];
			Random rand = new Random(0);
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100);
			}
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine(); 

			foreach (int i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();

            //	sum
            int sum = 0;
			foreach(int i in arr)
				sum += i;
			Console.WriteLine("Сумма элементов массива: " + sum);

			//	avg
			double avg = (double)sum / arr.Length;
            Console.WriteLine("Среднее арифметическое элементов массива: " + avg);

			//	min
			int min = arr[0];
			foreach(int i in arr)
				if(i < min) min = i;
            Console.WriteLine("Минимальный элемент массива: " + min);

			//	max
			int max = arr[0];
			foreach (int i in arr)
				if(i > max) max = i;
			Console.WriteLine("Максимальный элемент массива: " + max);

			// sort
			for (int i = 0; i < arr.Length; i++)
			{
				for(int j = i + 1; j < arr.Length; j++)
				{
					if(arr[j] < arr[i])
					{
						int buffer = arr[i];
						arr[i] = arr[j];
						arr[j] = buffer;
					}
				}
			}

			foreach (int i in arr) 
				Console.Write(i + "\t");
			Console.WriteLine();
#endif

#if ARRAYS_2
			Console.Write("Введите количество строк: ");
			int rows = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите количество элементов строки: ");
			int cols = Convert.ToInt32(Console.ReadLine());

			int[,] i_arr_2 = new int[rows, cols];

			Console.WriteLine(i_arr_2.Rank);

			Random rand = new Random(0);
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					i_arr_2[i, j] = rand.Next(100);
				}
			}
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();
			} 

			foreach (int i in i_arr_2)
			{
				Console.Write(i + "\t");
			}
            Console.WriteLine();

			//	sum
			int sum = 0;
			foreach (int i in i_arr_2)
				sum += i;
			Console.WriteLine("Сумма элементов массива: " + sum);

			//	avg
			double avg = (double)sum / i_arr_2.Length;
			Console.WriteLine("Среднее арифметическое элементов массива: " + avg);

			//	min
			int min = i_arr_2[0, 0];
			foreach (int i in i_arr_2)
				if (i < min) min = i;
			Console.WriteLine("Минимальный элемент массива: " + min);

			//	max
			int max = i_arr_2[0, 0];
			foreach(int i in i_arr_2)
				if (i > max) max = i;
			Console.WriteLine("Максимальный элемент массива: " + max);

			//	sort
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					for (int k = i; k < rows; k++)
					{
						for (int l = k == i ? j + 1 : 0; l < cols; l++)
						{
							if (i_arr_2[k, l] < i_arr_2[i, j])
							{
								int buffer = i_arr_2[i, j];
								i_arr_2[i, j] = i_arr_2[k, l];
								i_arr_2[k, l] = buffer;
							}
						}
					}
				}
			}

			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();
			}
#endif

#if JAGGED_ARRAY

			int[][] arr_jagged = new int[][]
			{
				new int[] { 3, 5, 8, 13, 21 },
				new int[] { 0, 1, 1, 2 },
				new int[] { 144, 233, 377, 610, 987 },
				new int[] { 34, 55, 89 },
			};

			for (int i = 0; i < arr_jagged.Length; i++)
			{
				for (int j = 0; j < arr_jagged[i].Length; j++)
				{
					Console.Write(arr_jagged[i][j] + "\t");
				}
				Console.WriteLine(); 
			}

			//	sum
			int sum = 0;
			for (int i = 0; i < arr_jagged.Length; i++)
				for (int j = 0; j < arr_jagged[i].Length; j++)
					sum += arr_jagged[i][j];
			Console.WriteLine("Сумма элементов массива: " + sum);

			//	avg
			int length = 0;
			for (int i = 0; i < arr_jagged.Length; i++)
				length += arr_jagged[i].Length;

            double avg = (double)sum / length;
			Console.WriteLine("Среднее арифметическое элементов массива: " + avg);

			// min
			int min = 0;
			for (int i = 0; i < arr_jagged.Length; i++)
				for (int j = 0; j < arr_jagged[i].Length; j++)
					if (arr_jagged[i][j]<min)min = arr_jagged[i][j];
			Console.WriteLine("Минимальный элемент массива: " + min);

			// max
			int max = 0;
			for (int i = 0; i < arr_jagged.Length; i++)
				for (int j = 0; j < arr_jagged[i].Length; j++)
					if (arr_jagged[i][j] > max) max = arr_jagged[i][j];
			Console.WriteLine("Максимальный элемент массива: " + max);

			//	sort
			for (int i = 0; i < arr_jagged.Length; i++)
			{
				for (int j = 0; j < arr_jagged[i].Length; j++)
				{
					for (int k = i; k < arr_jagged.Length; k++)
					{
						for (int l = k == i ? j + 1 : 0; l < arr_jagged[k].Length; l++)
						{
							if (arr_jagged[k][l] < arr_jagged[i][j])
							{
								int buffer = arr_jagged[i][j];
								arr_jagged[i][j] = arr_jagged[k][l];
								arr_jagged[k][l] = buffer;
							}
						}
					}
				}
			}

			for (int i = 0; i < arr_jagged.Length; i++)
			{
				for (int j = 0; j < arr_jagged[i].Length; j++)
				{
					Console.Write(arr_jagged[i][j] + "\t");
				}
				Console.WriteLine();
			}
#endif
		}
	}
}
