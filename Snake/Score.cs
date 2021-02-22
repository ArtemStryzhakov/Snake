using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Score
    {
        private int score;
        private int level;
        public int speed;

        public Score(int score, int level)
        {
            this.score = score;
            this.level = level;
        }

        public bool ScoreUp()
        {
            score++;
            if(score % 10 == 0)
            {
                level++;
                return true;
            }
            else { return false; }
        }
        public void ScoreWrite()
        {
            Console.SetCursorPosition(65, 10);
            Console.WriteLine($"Score: {score}");
            Console.SetCursorPosition(65, 11);
            Console.WriteLine($"Level: {level}");
        }
    }
}
