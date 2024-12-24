using System;
using System.Collections.Generic;

namespace SnakeGame
{
    class Snake
    {
        public List<Point> Body { get; private set; }
        public Point Head => Body[0];
        private Direction direction;

        public Snake(Point initialPosition, int initialLength, Direction initialDirection)
        {
            Body = new List<Point>();
            for (int i = 0; i < initialLength; i++)
            {
                Body.Add(new Point(initialPosition.X - i, initialPosition.Y));
            }
            direction = initialDirection;
        }

        public void Move()
        {
            for (int i = Body.Count - 1; i > 0; i--)
            {
                Body[i] = Body[i - 1];
            }

            switch (direction)
            {
                case Direction.Up:
                    Body[0] = new Point(Head.X, Head.Y - 1);
                    break;
                case Direction.Down:
                    Body[0] = new Point(Head.X, Head.Y + 1);
                    break;
                case Direction.Left:
                    Body[0] = new Point(Head.X - 1, Head.Y);
                    break;
                case Direction.Right:
                    Body[0] = new Point(Head.X + 1, Head.Y);
                    break;
            }
        }

        public void ChangeDirection(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.W:
                    if (direction != Direction.Down) direction = Direction.Up;
                    break;
                case ConsoleKey.S:
                    if (direction != Direction.Up) direction = Direction.Down;
                    break;
                case ConsoleKey.A:
                    if (direction != Direction.Right) direction = Direction.Left;
                    break;
                case ConsoleKey.D:
                    if (direction != Direction.Left) direction = Direction.Right;
                    break;
            }
        }

        public void Grow()
        {
            Body.Add(new Point(Body[Body.Count - 1].X, Body[Body.Count - 1].Y));
        }

        public bool IsCollision(int width, int height)
        {
            // Check collision with borders
            if (Head.X <= 0 || Head.X >= width - 1 || Head.Y <= 0 || Head.Y >= height - 1)
            {
                return true;
            }

            // Check collision with itself
            for (int i = 1; i < Body.Count; i++)
            {
                if (Head.Equals(Body[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public void Draw()
        {
            foreach (var point in Body)
            {
                Console.SetCursorPosition(point.X, point.Y);
                Console.Write("*");
            }
        }
    }
}