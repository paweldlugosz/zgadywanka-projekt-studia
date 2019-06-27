using System;
using System.Collections.Generic;

namespace Obiektowo
{
    public class Game
    {
        public enum Response { NotEnough = -1, Equal = 0, TooMuch = 1 }
        public enum GameState { Active, Guessed, GiveUp }

        private static readonly Random random = new Random();
        private readonly int number;
        private readonly bool cheat;
        private bool cheated;
        public int? Number
        {
            get
            {
                if (State == GameState.GiveUp || State == GameState.Guessed) return number;
                else return null;
            }
        }
        public int StepCounter { get; private set; } = 0;
        public GameState State { get; private set; }
        private readonly List<Step> history;
        public IReadOnlyList<Step> History => history;

        public Game (int start = 0, int end = 100, bool cheat = false)
        {
            this.cheat = cheat;
            this.cheated = false;
            history = new List<Step>();
            number = random.Next(Math.Min(start, end), Math.Max(start, end) + 1);
            State = GameState.Active;
        }

        public Step Rate(int proposition)
        {
            Response response;
            if (proposition == number)
            {
                State = GameState.Guessed;
                response = Response.Equal;
            }
            else response = proposition < number ? Response.NotEnough : Response.TooMuch;

            if (cheat && !cheated && response != Response.Equal && random.Next(0, 10) == 1)
            {
                response = response == Response.NotEnough ? Response.TooMuch : Response.NotEnough;
                cheated = true;
            }

            Step step = new Step(proposition, response);
            history.Add(step);
            return step;
        }

        public int GiveUp()
        {
            State = GameState.GiveUp;
            return number;
        }
    }
}
