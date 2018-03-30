using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Delivery
    {
        public int ID_Delivery
        { get; set; }
        public DateTime Data
        { get; set; }
        public Employee Employee
        { get; set; }
        public Reader Reader
        { get; set; }
        public Exemplar Exemplar
        { get; set; }
        public Delivery(int ID_Delivery, DateTime Data, Employee Employee, Reader Reader, Exemplar Exemplar)
        {
            this.ID_Delivery = ID_Delivery;
            this.Data = Data;
            this.Employee = Employee;
            this.Reader = Reader;
            this.Exemplar = Exemplar;
        }
    }
}
