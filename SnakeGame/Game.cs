using System;
using System.Threading;

namespace SnakeGame
{
    class Game
    {
        private Snake snake;
        private Point food;
        private int width = 40;
        private int height = 20;
        private Random random = new Random();
        private char[,] buffer;

        public Game()
        {
            snake = new Snake(new Point(width / 2, height / 2), 3, Direction.Right);
            buffer = new char[width, height];
            GenerateFood();
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

                if (snake.Head.Equals(food))
                {
                    snake.Grow();
                    GenerateFood();
                }

                if (snake.IsCollision(width, height))
                {
                    Console.Clear();
                    Console.WriteLine("Game Over!");
                    break;
                }

                Draw();
                Thread.Sleep(100);
            }
        }

        private void GenerateFood()
        {
            food = new Point(random.Next(1, width - 1), random.Next(1, height - 1));
        }

        private void Draw()
        {
            Array.Clear(buffer, 0, buffer.Length);

            // Draw borders
            for (int x = 0; x < width; x++)
            {
                buffer[x, 0] = '#';
                buffer[x, height - 1] = '#';
            }
            for (int y = 0; y < height; y++)
            {
                buffer[0, y] = '#';
                buffer[width - 1, y] = '#';
            }

            // Draw snake
            foreach (var point in snake.Body)
            {
                buffer[point.X, point.Y] = '*';
            }

            // Draw food
            buffer[food.X, food.Y] = 'O';

            // Render buffer to console
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(buffer[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
