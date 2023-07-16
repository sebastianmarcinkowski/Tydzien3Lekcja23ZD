using System;

namespace Tydzien3Lekcja23ZD
{
	internal class Game
	{
		private int _randomNumber { get; set; }
		private int _counter { get; set; }
		private bool _gameStatus { get; set; }

		public Game(int range)
		{
			Random random = new Random();
			this._counter = 0;
			this._randomNumber = random.Next(range + 1);
			this._gameStatus = false;
		}

		public bool GameStatus() { return this._gameStatus; }
		public int HowManyAttemps() { return this._counter; }

		public int Play(int number)
		{
			this._counter++;

			if (number == this._randomNumber)
			{
				this._gameStatus = true;
				return 0;
			}
			else if (number > this._randomNumber)
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
