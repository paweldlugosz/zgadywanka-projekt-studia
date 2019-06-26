﻿using System;
using System.Collections.Generic;

namespace Obiektowo
{
    public class Game
    {
        public enum Response { NotEnough = -1, Equal = 0, TooMuch = 1 }
        public enum GameState { Active, Guessed, GiveUp }

        private static readonly Random random = new Random();
        private readonly int number;
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

        public Game (int start = 0, int end = 100)
        {
            history = new List<Step>();
            number = random.Next(Math.Min(start, end), Math.Max(start, end) + 1);
            State = GameState.Active;
        }

        public Response Rate(int proposition)
        {
            Response response;
            if (proposition == number)
            {
                State = GameState.Guessed;
                response = Response.Equal;
            }
            else response = proposition < number ? Response.NotEnough : Response.TooMuch;
            history.Add(new Step(proposition, response));
            return response;
        }

        public int GiveUp()
        {
            State = GameState.GiveUp;
            return number;
        }
    }
}