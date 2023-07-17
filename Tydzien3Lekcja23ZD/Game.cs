using System;

namespace Tydzien3Lekcja23ZD
{
    internal class Game
    {
        private int _randomNumber;
        public int Counter { get; private set; }
        public bool GameStatus { get; private set; }

        public Game(int range)
        {
            Random random = new Random();
            Counter = 0;
            _randomNumber = random.Next(range + 1);
            GameStatus = false;
        }
        public int Play(int number)
        {
            Counter++;

            if (number == _randomNumber)
            {
                GameStatus = true;
                return 0;
            }
            else if (number > _randomNumber)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
