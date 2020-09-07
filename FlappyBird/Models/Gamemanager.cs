using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlappyBird.Models
{public class GameManager
    {
        public BirdModel Bird { get; private set; }
        public List<PipeModel> Pipes { get; private set; }
        public ScoreModel Score {get; set;}
        public bool IsRunning { get; private set; } = false;
        private readonly int _gravity =2;
        public event EventHandler MainLoopCompleted;

        public GameManager()
        {
            Bird = new BirdModel();
            Pipes = new List<PipeModel>();
        }


        public async void MainLoop()
        {
            IsRunning=true;
            while(IsRunning)
            {
                MoveObjects();

                CheckForCollisions();
                ManagePipes();

                MainLoopCompleted?.Invoke(this, EventArgs.Empty);
                await Task.Delay(20);
            }

        }

        public void StartGame()
        {
            if(!IsRunning)
            {
                Bird = new BirdModel();
                this.MainLoop();
                this.Pipes = new List<PipeModel>();
            }
        }

        public void GameOver()
        {
            this.IsRunning = false;
        }

        public void Jump()
        {
            if(IsRunning)
            {
                Bird.Jump();
            }
        }
        void MoveObjects()
        {
            Bird.Fall(_gravity);
                foreach (var pipe in Pipes)
                {
                    pipe.Move();
                }
               
        }

        void CheckForCollisions()
        {
             if(Bird.IsOnGround())
             {
                 this.GameOver();
             }

             //Check for collisions with pipes and bird
             //1. Check if a pipe is in the middle of the screen.
             var centeredPipe = Pipes.FirstOrDefault(p => p.IsCentered());

             //2. If a pipe is in the center, check for collisions
             if(centeredPipe != null)
             {
             //2.a. check for collision with bottom pipe
                bool birdHasColidedWithBottom = Bird.DistanceFromGround<centeredPipe.GapBottom-150;
                //45 is the height of the bird. 
                bool birdHasCollidedWithTop = Bird.DistanceFromGround + 45> centeredPipe.GapTop -150;

                if(birdHasColidedWithBottom || birdHasCollidedWithTop)
                {
                    this.GameOver();
                }
             }
             //2.b. check for collision with top pipe. 

        }
        void ManagePipes()
        {
            if(!Pipes.Any() || Pipes.Last().DistanceFromLeft<=250)
            {
                Pipes.Add(new PipeModel());
            }
            if(Pipes.First().IsOffScreen())
            {
                Pipes.Remove(Pipes.First());
            }
        }
    }


}