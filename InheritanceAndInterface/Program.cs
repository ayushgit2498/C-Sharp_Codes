using System;

namespace InheritanceAndInterface
{
    public interface INotifications
    {
        // Interface members and methods are public by default
        void ShowNotification();
        string GetDate();
    }

    public class Notification : INotifications
    {
        private string sender;
        private string message;
        private string date;

        public Notification()
        {
            sender = "Admin";
            message = "This is a test notification.";
            date = "1.1.2020";
        }
        
        public Notification(string sender, string message, string date)
        {
            this.sender = sender;
            this.message = message;
            this.date = date;
        }

        public void ShowNotification()
        {
            Console.WriteLine("Message : {0} - sent by {1} - at {2}", message, sender, date);
        }

        public string GetDate()
        {
            return date;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Post p1 = new Post();
            Console.WriteLine(p1);
            Post p2 = new Post("Looking forawrd to tomorrow", "Blazehunter", true);
            Console.WriteLine(p2);
            ImagePost ip1 = new ImagePost("Checkout my new phone", "Ayush Gupta", true, "https://static.toiimg.com/thumb/msid-71646686,width-320,resizemode-4/OnePlus-8-Pro.jpg");
            Console.WriteLine(ip1);
            VideoPost vp1 = new VideoPost("Dude Perfect Video", "Coby Cotton", true, "https://Dudeperfect.com/RocketBattle", 10);
            Console.WriteLine(vp1);
            vp1.Play();
            VideoPost vp2 = new VideoPost("Dude Perfect Video", "Tyler Tony", true, "https://Dudeperfect.com/AllSportsGolfBattle", 5);
            Console.WriteLine(vp2);
            vp2.Play();
            Notification n1 = new Notification("Ayush Gupta", "Hey!How are you?", "25.05.2020");
            n1.ShowNotification();
            Console.WriteLine(n1.GetDate());
        }
    }
}
