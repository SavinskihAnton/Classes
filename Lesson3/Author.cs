using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class Author
    {
        readonly string author;
        public Author(string author)
        {
            this.author = author;
        }
        public void Show()
        { 
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(author);
        }
    }
}
