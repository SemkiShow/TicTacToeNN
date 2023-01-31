using System;

namespace TicTocToeNN
{
	class NeuralNetwork
	{
		public static void CalculateNeurons(double[] neurons1, double[] weight1, double[] neurons2)
		{
			for (int i = 0; i < neurons2.Length; i++)
			{
				for (int j = 0; j < neurons1.Length; j++)
				{
					neurons2[i] += neurons1[j] * weight1[neurons2.Length * 0 + j];
				}
			}
		}
		public static void RandomizeWeights(double[] weight1)
		{
			for (int i = 0; i < weight1.Length; i++)
			{
				weight1[i] = new Random().NextDouble();
			}
		}
		public static void NN()
		{
			double[] neurons1 = new double[]{};
			double[] weight1 = new double[]{};
			double[] neurons2 = new double[]{};
		}
	}
	class Program
	{
		public static void DrawBoard(string[,] board)
		{
			// Console.BackgroundColor = ConsoleColor.White;
			Console.Write("-------");
			Console.ResetColor();
			Console.WriteLine();
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					// Console.BackgroundColor = ConsoleColor.White;
					Console.Write("|");
					Console.ResetColor();
					Console.Write(board[i, j]);
				}
				// Console.BackgroundColor = ConsoleColor.White;
				Console.Write("|");
				Console.ResetColor();
				Console.WriteLine();
				// Console.BackgroundColor = ConsoleColor.White;
				Console.Write("-------");
				Console.ResetColor();
				Console.WriteLine();
			}
		}
		public static int[] InputBoard(string[,] board)
		{
			// Console.WriteLine();
			// DrawBoard(board);
			// Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop - 6);
			int[] position = new int[]{0, 0};
			/* while (true)
			{
				var key = Console.ReadKey();
				if (key.Key == ConsoleKey.UpArrow && position[0] >= 1)
				{
					Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
					position[0]--;
				}
				if (key.Key == ConsoleKey.DownArrow && position[0] <= 3)
				{
					Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
					position[0]++;
				}
				if (key.Key == ConsoleKey.LeftArrow && position[1] >= 1)
				{
					Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
					position[1]--;
				}
				if (key.Key == ConsoleKey.RightArrow && position[1] <= 3)
				{
					Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
					position[1]++;
				}
				if (key.Key == ConsoleKey.Enter)
				{
					return position;
					break;
				}
			} */
			position[0] = Convert.ToInt16(Console.ReadLine());
			position[1] = Convert.ToInt16(Console.ReadLine());
			return position;
		}
		public static void Main()
		{
			Console.WriteLine("Hello, World!");
			string[,] board = new string[3, 3];
			board = new string[3, 3]{
				{" ", " ", " "},
				{" ", " ", " "},
				{" ", " ", " "}
			};
			/* while (true)
			{
				DrawBoard(board);
				int[] position = InputBoard(board);
				board[position[0] - 1, position[1] - 1] = "X";
				var key = Console.ReadKey();
				if (key.Key == ConsoleKey.Q)
				{
					break;
				}
			} */
		}
	}
}
