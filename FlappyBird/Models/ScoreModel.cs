namespace FlappyBird.Models
{
      public class ScoreModel
    {
        public int Score { get; set; } =0;
        public int HighScore { get; set; }

        public int IncreaseScore()
        {
            return ++Score;
        }

        public void ResetScore()
        {
            if(Score>HighScore)
            {
                HighScore = Score;
            }
             Score = 0;
        }
    }
}