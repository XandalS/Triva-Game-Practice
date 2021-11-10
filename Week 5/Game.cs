using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Week_5
{
    class Game
    {
        private Player MyPlayer = new Player();
        private TriviaItem[] Quiz = new TriviaItem[4];

        public Game()
        {
            StartGame();
            LoadQuiz();
            TakeQuiz();
        }


        public void StartGame()
        {
            //Launch app, greet and setup player
            WriteLine("Good day dear traveler, may a simple quizmaster ask for your name?");
            MyPlayer = new Player(ReadLine());
            WriteLine($"Wonderful to meet you {MyPlayer.Name}");
            ReadKey(true);
        }
        public void LoadQuiz()
        {
            //Create out trivia items and store in array
            Quiz[0] = new TriviaItem("What is the name of the Hololive Graduated Dragon?", "Kiryu Coco");
            Quiz[1] = new TriviaItem("What is the item aquired in the Ocarina of Time fire temple?", "Goron Hammer");
            Quiz[2] = new TriviaItem("What is YOUR Name?", MyPlayer.Name);
            Quiz[3] = new TriviaItem("What is the quest?", "To seek the grail.");
        }
        public void TakeQuiz()
        {
            //Quiz player on trivia
            for (int i = 0; i < Quiz.Length; i++)
            {
                Clear();
                WriteLine(Quiz[i].Question);
                WriteLine("Select your Answer:");

                for(int a=0; a< Quiz.Length; a++)
                {
                    WriteLine($"{a + 1}. {Quiz[a].Answer}");
                }
                int ans = Convert.ToInt32(ReadLine());

                if (Quiz[ans-1].Answer == Quiz[i].Answer)
                {
                    //Correct
                    WriteLine("Correct");
                    MyPlayer.TrackScore(1);
                }
                else
                {
                    //Incorrect
                    WriteLine("Incorrect!");
                }

                WriteLine("Pres any key to Continue...");
                ReadKey(true);
            }
            Clear();
            WriteLine($"{MyPlayer.Name} scored {MyPlayer.Score} out of {Quiz.Length}.");
        }

    }
}
