using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakeee
{
    enum Directions
    {
        Up,
        Down,
        Right,
        Left
    }
    internal class Settings
    {
        public static int width;
        public static int heigth;
        public static int speeeed;
        public static int points;
        public static int score;
        public static bool GameOver;
        public static Directions direction;

        public Settings()
        {
            width = 16;
            heigth = 16;
            speeeed = 8;
            score = 0;
            points = 1;
            GameOver = false;
            direction = Directions.Down;
        }


    }
}
