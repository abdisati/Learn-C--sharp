using System;
using System.Collections.Generic;
using System.Threading;
using SnakeBody;
using SnakeFood;

namespace SnakeGame
{
    class Game
    {
        private Snake snake;
        private Food food;
        private int width = 40;
        private int height = 20;
        private int score = 0;

        public Game()
        {
            snake = new Snake((height / 2, width / 2), 3, (0, 1));
            food = new Food(width, height);
        }

        public void Start()
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.ChangeDirection(key.Key);
                }

                snake.Move();

                if (snake.Body[0] == food.Position)
                {
                    EatFood();
                }

                if (snake.CheckCollision(width, height))
                {
                    Console.Clear();
                    Console.WriteLine("Game Over!");
                    Console.WriteLine($"Final Score: {score}");
                    break;
                }

                Draw();
                Thread.Sleep(100);
            }
        }

        private void EatFood()
        {
            score++;
            snake.Grow();
            food.GenerateFood(width, height);
        }

        private void Draw()
        {
            Console.Clear();

            // Draw borders
            for (int x = 0; x < width; x++)
            {
                Console.SetCursorPosition(x, 0);
                Console.Write("#");
                Console.SetCursorPosition(x, height - 1);
                Console.Write("#");
            }
            for (int y = 0; y < height; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.Write("#");
                Console.SetCursorPosition(width - 1, y);
                Console.Write("#");
            }

            // Draw snake
            foreach (var point in snake.Body)
            {
                Console.SetCursorPosition(point.Item2, point.Item1);
                Console.Write("*");
            }

            // Draw food
            Console.SetCursorPosition(food.Position.Item2, food.Position.Item1);
            Console.Write("O");

            // Draw score
            Console.SetCursorPosition(0, height);
            Console.Write($"Score: {score}");
        }
    }
}