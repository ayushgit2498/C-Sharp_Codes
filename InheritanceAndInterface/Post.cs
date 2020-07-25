using System;

namespace InheritanceAndInterface
{
    class Post
    {

        private static int currentPostId;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            this.ID = 0;
            this.Title = "First Post";
            this.SendByUsername = "Ayush Gupta";
            this.IsPublic = true;
        }

        public Post(string title, string sendByUsername, bool isPublic)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextId()
        {
            return ++currentPostId;
        }

        protected void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        // Every class derives from System.Object class
        public override string ToString()
        {
            return String.Format("{0} - {1} by - {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
