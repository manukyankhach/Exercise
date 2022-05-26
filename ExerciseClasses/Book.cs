using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClasses
{
    public class Book
    {
        public void Show(string titleParameter, string authorParameter, string contentParameter)
        {
            Title titleInstance = new Title(titleParameter);
            titleInstance.Show();
            Author authorInstance = new Author(authorParameter);
            authorInstance.Show();
            Content contentInstance = new Content(contentParameter);
            contentInstance.Show();
        }
    }

    public class Title
    {
        public string _title;
        public Title(string title)
        {
            _title = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(_title);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    public class Author
    {
        public string _author;

        public Author(string author)
        {
            _author = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(_author);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    public class Content
    {
        public string _content;
        public Content(string content)
        {
            _content = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(_content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
