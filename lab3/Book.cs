﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Book
    {
        public int ID_Book
        { get; set; }
        public string Author
        { get; set; }
        public string NameBook
        { get; set; }
        public string Genre
        { get; set; }

        public Book(int ID_Book, string Author, string NameBook, String Genre)
        {
            this.ID_Book = ID_Book;
            this.Author = Author;
            this.NameBook = NameBook;
            this.Genre = Genre;
        }
    }
}
