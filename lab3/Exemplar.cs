using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Exemplar
    {
        public int ID_Exemplar
        { get; set; }
        public Book Book
        { get; set; }
        public DateTime Data
        { get; set; }
        public string Publisher
        { get; set; }
        public Exemplar(int ID_Exemplar, Book Book, DateTime Data, string Publisher)
        {
            this.ID_Exemplar = ID_Exemplar;
            this.Book = Book;
            this.Data = Data;
            this.Publisher = Publisher;
        }
    }
}
