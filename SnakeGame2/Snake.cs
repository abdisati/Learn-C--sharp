using System;
using System.Collections.Generic;

namespace SnakeBody
{
    class Snake
    {
        public List<(int, int)> Body { get; private set; }
        public (int, int) Direction { get; private set; }

        public Snake((int, int) initialPosition, int initialLength, (int, int) initialDirection)
        {
            Body = new List<(int, int)>();
            for (int i = 0; i < initialLength; i++)
            {
                Body.Add((initialPosition.Item1 - i * initialDirection.Item1, initialPosition.Item2 - i * initialDirection.Item2));
            }
            Direction = initialDirection;
        }

        public void ChangeDirection(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (Direction != (1, 0)) Direction = (-1, 0);
                    break;
                case ConsoleKey.DownArrow:
                    if (Direction != (-1, 0)) Direction = (1, 0);
                    break;
                case ConsoleKey.LeftArrow:
                    if (Direction != (0, 1)) Direction = (0, -1);
                    break;
                case ConsoleKey.RightArrow:
                    if (Direction != (0, -1)) Direction = (0, 1);
                    break;
            }
        }

        public void Move()
        {
            var head = Body[0];
            var newHead = (head.Item1 + Direction.Item1, head.Item2 + Direction.Item2);
            Body.Insert(0, newHead);
            Body.RemoveAt(Body.Count - 1);
        }

        public void Grow()
        {
            Body.Add(Body[Body.Count - 1]);
        }

        public bool CheckCollision(int width, int height)
        {
            var head = Body[0];
            if (head.Item1 < 0 || head.Item1 >= height || head.Item2 < 0 || head.Item2 >= width)
            {
                return true;
            }

            for (int i = 1; i < Body.Count; i++)
            {
                if (Body[i] == head)
                {
                    return true;
                }
            }

            return false;
        }
    }
}