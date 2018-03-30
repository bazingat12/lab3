using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Employee : Status
    {
        public int ID_Employee
        { get; set; }
        public string Position
        { get; set; }
        public string Surname
        { get; set; }
        public string Name
        { get; set; }
        public string Patronymic
        { get; set; }
        public int INN
        { get; set; }
        public byte Experience
        { get; set; }

        public Employee (int ID_Employee, string Position, string Surname, string Name, string Patronymic, int INN, byte Experience)
        {
            this.ID_Employee = ID_Employee;
            this.Position = Position;
            this.Surname = Surname;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.INN = INN;
            this.Experience = Experience;
        }
        public virtual void Info()
        {
            Console.WriteLine("Код сотрудника: {0}\nДолжность: {1}\nФамилия: {2}\nИмя: {3}\nОтчество: "
                + "{4}\nИНН: {5}\nСтаж работы: {6}\n",
                ID_Employee, Position, Surname, Name, Patronymic, INN, Experience);
        }
        void Status.BestEmployee(string Best)
        {
            Console.WriteLine("Лучший работник библиотеки: {0}", Best);
        }
    }
    
}
