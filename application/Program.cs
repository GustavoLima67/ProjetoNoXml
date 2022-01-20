using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using System.IO;
using System.Xml.Serialization;

namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> products = new List<Employee>();

            Console.Write("Enter with name employee: ");
            string name = Console.ReadLine();
            Console.Write("Enter with birth date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter with salary employee: ");
            double price = double.Parse(Console.ReadLine());
            
            Employee pp = new Employee(name, birthDate, price);
            products.Add(pp);

            XmlSerializer xmlSrl = new XmlSerializer(typeof(Employee));

            StreamWriter stream = new StreamWriter(@"C:\Users\Gustavo\Documents\Arquivos c#\application.xml");

            xmlSrl.Serialize(stream, pp);

            foreach (var e in products)
            {
                Console.WriteLine("Employee name: {0}, salary: {1}, birth date: {2}", e.getName(), e.getSalary(), e.getBirthDate());
            }
        }
    }
}
