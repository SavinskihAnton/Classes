using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class Title
    {
        readonly string title;
        public Title(string title)
        {
            this.title = title;
        }
        public void Show()
        { 
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine(title);
        }
    }
}
