﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class Book
    {
        readonly Title title;
        readonly Author author;
        readonly Content content;

        public Book(string author, string title, string content)
        {
            this.author = new Author(author);
            this.title = new Title(title);
            this.content = new Content(content);
        }

        public void Show()
        { 
            author.Show();
            title.Show();
            content.Show();
        }
    }
}
