using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal struct Employee
    {
        // Attributes
        public int Id;
        public string Name;
        public decimal salary;

        // Automatic property
        //compilar will generate the attribute [hidden privaye attribute]
        public int Age { get; set; }


        // Derived attribute
        public decimal deduction
        {
            get { return salary * 0.1M; } //readonly property
        }



        public Employee(int _id, string _name, decimal _salary, int _age)
        {
            this.Id = _id;
            this.Name = _name;
            this.salary = _salary;
            this.Age = _age;

        }


        //Encapsulation: Separates Data Definition [Attributes] from its use
        // 1. Applying Encapsulation using Getter Setter [Functions]
      
        // Getter
        public string getName()
        {
            return Name;
        }
        public decimal getSalary() 
        { return salary; }

        //Setter
        public void setName(string _name)
        {
            this.Name = _name.Length <= 5? _name : _name.Substring(0,5);
        }

        // 2. Applying Encapsulation: Using Property (Full property)
        public decimal Salary
        {
            get { return salary; }
            set { salary = value >= 2000? value :2000; } //Control data
        }
        

        //Methods
        public override string ToString()
        {
            return $"Id: {Id} \nName: {Name} \nSalary: {salary}";     
        }


    }
}
