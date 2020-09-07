namespace FlappyBird.Models
{
      public class ScoreModel
    {
        public int Score { get; set; } =0;

        public int IncreaseScore()
        {
            return ++Score;
        }
    }
}