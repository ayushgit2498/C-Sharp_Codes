using System;
using System.Timers;
using System.Threading;

namespace InheritanceAndInterface
{
    class VideoPost:Post
    {
        private string videoURL;
        private int length;
        private int timeConsumed;
        public VideoPost()
        {
            timeConsumed = 0;
        }

        // Here we are calling the base class parameterized constructor.
        // There is also an option that we can set the value of inherited members of the base class in this
        // derived constructor like we did in ImagePost class.
        // Note - If base class only has a parameterized constructor and no default constructor then you have to pass the arguments
        // from construtor of derived class to parameterized constructor of base class.So it always good to have a default constructor in every 
        // class.
        public VideoPost(string title, string sendByUsername, bool isPublic, string videoURL, int length) : base(title, sendByUsername, isPublic)
        {
            // Property of VideoPost
            this.videoURL = videoURL;
            this.length = length;
            timeConsumed = 0;
        }

        public void Play()
        {

                Console.WriteLine("Press any key to exit");
                while(true)
                {
                    if(Console.KeyAvailable == true)
                    {
                        Console.ReadKey(true);  // when we pass true as an argument to Console.ReadKey it does not display the key pressed in console.
                        break;
                    }else
                    {
                        Thread.Sleep(1000);
                        timeConsumed++;
                        Console.WriteLine(timeConsumed);
                    }
                    if(timeConsumed == length)
                    {
                        Console.WriteLine("Video got over");
                        break;
                    }
                }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - length:{3} - {4}", this.ID, this.Title, this.videoURL, this.length, this.SendByUsername);
        }
    }
}
