namespace FlappyBird.Models
{
    public class BirdModel
    {
        public int DistanceFromGround { get; set; } = 100;
        public int JumpStrength { get; set; } = 50;

        public void Fall(int gravity)
        {
            DistanceFromGround -= gravity;
        }

        public void Jump()
        {
            if(DistanceFromGround <=530)
            {
                DistanceFromGround +=JumpStrength;
            }
        }

        public bool IsOnGround()
        {
            return DistanceFromGround<=0 ? true: false;
        }
    }
}