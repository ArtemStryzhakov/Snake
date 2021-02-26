using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;

			Console.SetWindowSize(75, 25);

			Walls walls = new Walls(62, 25);
			walls.Draw();

			// Отрисовка точек			
			Point p = new Point(4, 8, '*', ConsoleColor.Red);
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Draw();

			FoodCreator foodCreator = new FoodCreator(62, 25, '$', ConsoleColor.Green);
			Point food = foodCreator.CreateFood();
			food.Draw();
			Score score = new Score(0, 1);//score-0, level-1
			score.speed = 50;
			score.ScoreWrite();

			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					break;
				}
				if (snake.Eat(food))
				{
					score.ScoreUp();
					score.ScoreWrite();
					food = foodCreator.CreateFood();
					food.Draw();
					if (score.ScoreUp())
                    {
						score.speed -= 10;
                    }
				}
				else
				{
					snake.Move();
				}

				Thread.Sleep(score.speed);
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
			WriteGameOver();
			Console.ReadLine();
		}


		static void WriteGameOver()
		{
			int xOffset = 15;
			int yOffset = 8;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.SetCursorPosition(xOffset, yOffset++);
			WriteText("-----------------------------", xOffset, yOffset++);
			WriteText("И Г Р А    О К О Н Ч Е Н А", xOffset + 1, yOffset++);
			yOffset++;
			WriteText("Autor: Artem Stryzhakov", xOffset + 2, yOffset++);
			WriteText("Special for Marina Oleinik.", xOffset + 1, yOffset++);
			WriteText("-----------------------------", xOffset, yOffset++);
			WriteText("( ͡° ͜ʖ ͡°)", xOffset + 9, yOffset++);
		}

		static void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}
	}
}
