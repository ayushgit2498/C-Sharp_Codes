using System;

namespace InheritanceAndInterface
{
    class ImagePost:Post
    {
        public string imageURL;

        public ImagePost(){ }


        public ImagePost(string title, string sendByUsername, bool isPublic, string imageURL)
        {
            // Properties derived from base class
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            // Property of ImagePost
            this.imageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", this.ID, this.Title, this.imageURL, this.SendByUsername);
        }
    }
}
