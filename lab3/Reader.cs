using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Reader
    {
        public int ID_Reader
        { get; set; }
        public string Surname
        { get; set; }
        public string Name
        { get; set; }
        public string Patronymic
        { get; set; }
        public string Gender
        { get; set; }
        public int Phone
        { get; set; }
        public Reader(int ID_Reader, string Surname, string Name, string Patronymic, string Gender, int Phone)
        {
            this.ID_Reader = ID_Reader;
            this.Surname = Surname;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.Gender = Gender;
            this.Phone = Phone;
        }
    }
}
