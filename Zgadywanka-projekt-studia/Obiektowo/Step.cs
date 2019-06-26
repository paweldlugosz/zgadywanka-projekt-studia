using System;
using System.Collections.Generic;
using System.Text;

namespace Obiektowo
{
    public class Step
    {
        public readonly int proposition;
        public readonly Game.Response response;
        public readonly DateTime time;

        public Step(int prop, Game.Response res)
        {
            proposition = prop;
            response = res;
            time = DateTime.Now;
        }

        public override string ToString() => $"( {proposition}, {response}, {time})";

    }
}
