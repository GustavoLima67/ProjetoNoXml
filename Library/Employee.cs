using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Employee
    {
        private String name;
        private DateTime birthDate;
        private Double salary;

        public Employee() { }

        public Employee(String name, DateTime birthDate,Double salary)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.salary = salary;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public DateTime getBirthDate()
        {
            return birthDate;
        }

        public void setBirthDate(DateTime birthDate)
        {
            this.birthDate = birthDate;
        }

        public Double getSalary()
        {
            return salary;
        }

        public void setSalary(Double salary)
        {
            this.salary = salary;
        }
    }
}
