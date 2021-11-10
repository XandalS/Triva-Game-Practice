using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Week_5
{
    class TriviaItem
    {
        public string Question { get; }
        public string Answer { get; }

        public TriviaItem(string Q, string A)
        {
            Question = Q;
            Answer = A;
        }
    }
}
