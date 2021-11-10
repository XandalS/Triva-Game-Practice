using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Week_5
{
    class Player
    {
        public string Name { get; } = "Sir Lancelot";
        public int Score { get; private set; } = 0;
        
        public Player()
        {

        }
        public Player(string n)
        {
            Name = n;
        }

        public void TrackScore(int i)
        {
            this.Score += i;
        }
    }
}
