using System;

namespace SnakeFood
{
    class Food
    {
        public (int, int) Position { get; private set; }
        private Random random = new Random();

        public Food(int width, int height)
        {
            GenerateFood(width, height);
        }

        public void GenerateFood(int width, int height)
        {
            Position = (random.Next(0, height), random.Next(0, width));
        }
    }
}