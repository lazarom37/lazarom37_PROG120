using System;
using System.Collections.Generic;

namespace HW10_IDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            IDisplay[] newContent = new IDisplay[6];

            newContent[0] = new Book("Who Goes There?", "John W. Campbell", 230);
            newContent[1] = new Book("The Phantom Tollbooth", "Norton Juster", 255);
            newContent[2] = new ShortStory("Bimpus Quest", "Marcus Lazaro", 50);
            newContent[3] = new ShortStory("Birthday Quest", "Marcus Lazaro", 70);
            newContent[4] = new YouTubeVid("Me at the zoo", "jawed", "Documentary");
            newContent[5] = new YouTubeVid("GO MARIO GO", "Francisco Oporta", "Gaming");

            List<IDisplay> content = new List<IDisplay>();
            for (int i = 0; i < newContent.Length; i++)
            {
                content.Add(newContent[i]);
            }
            foreach (IDisplay item in content)
            {
                item.Display();
            }
        }
    }

    public class Document : IDisplay
    {
        private string _Title;
        private string _Author;
        private int _PageCount;
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }
        public int PageCount
        {
            get { return _PageCount; }
            set { _PageCount = value; }
        }

        public virtual void Display()
        {
            Console.WriteLine("Placeholder :)");
        }

    }

    public class Book : Document
    {
        public Book(string pTitle, string pAuthor, int pPageCount)
        {
            Title = pTitle;
            Author = pAuthor;
            PageCount = pPageCount;
        }
        
        public override void Display()
        {
            Console.WriteLine($"The Book \"{Title}\" by {Author} has {PageCount} pages.");
        }
    }

    public class ShortStory : Document
    {
        public ShortStory(string pTitle, string pAuthor, int pPageCount)
        {
            Title = pTitle;
            Author = pAuthor;
            PageCount = pPageCount;
        }

        public override void Display()
        {
            Console.WriteLine($"The Short Story \"{Title}\" by {Author} has {PageCount} pages.");
        }
    }

    public class YouTubeVid : IDisplay
    {
        private string _Title;
        private string _Author;
        private string _Category;
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }
        public string Category
        {
            get { return _Category; }
            set { _Category = value; }
        }

        public YouTubeVid(string pTitle, string pAuthor, string pCategory)
        {
            Title = pTitle;
            Author = pAuthor;
            Category = pCategory;
        }

        public virtual void Display()
        {
            Console.WriteLine($"The video \"{Title}\" by {Author} is in the {Category} category");
        }

    }

    public interface IDisplay
    {
        public void Display() 
        { 
            //Nothin'
        }
    }
}