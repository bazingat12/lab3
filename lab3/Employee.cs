using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Employee
    {
        public int ID_Employee
        { get; set; }
        public Position EmployeePosition
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

        public Employee (int ID_Employee, Position EmployeePosition, string Surname, string Name, string Patronymic, int INN, byte Experience)
        {
            this.ID_Employee = ID_Employee;
            this.EmployeePosition = EmployeePosition;
            this.Surname = Surname;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.INN = INN;
            this.Experience = Experience;
        }
        public virtual void Info()
        {
            Console.WriteLine("Сотрудник: ");
            Console.WriteLine("    Код сотрудника: {0}\n    Должность: {1}\n    Фамилия: {2}\n    Имя: {3}\n    Отчество: "
                + "{4}\n    ИНН: {5}\n    Стаж работы: {6}\n",
                ID_Employee, EmployeePosition, Surname, Name, Patronymic, INN, Experience);
        }
    }
    
}
