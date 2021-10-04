using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Database");
            // Instantiate employee list
            List<Employee> employees = new List<Employee>();

            // Add 10 employees to the list
            Employee employee1 = new Employee();
            employee1.FirstName = "Joe";
            employee1.LastName = "Smith";
            employee1.Id = 01;
            employees.Add(employee1);

            Employee employee2 = new Employee();
            employee1.FirstName = "Joe";
            employee1.LastName = "Burrow";
            employee1.Id = 02;
            employees.Add(employee2);

            Employee employee3 = new Employee();
            employee1.FirstName = "Phil";
            employee1.LastName = "Marino";
            employee1.Id = 03;
            employees.Add(employee3);

            Employee employee4 = new Employee();
            employee1.FirstName = "Taylor";
            employee1.LastName = "Smith";
            employee1.Id = 04;
            employees.Add(employee4);

            Employee employee5 = new Employee();
            employee1.FirstName = "Jerry";
            employee1.LastName = "Rice";
            employee1.Id = 05;
            employees.Add(employee5);

            Employee employee6 = new Employee();
            employee1.FirstName = "Davis";
            employee1.LastName = "Lee";
            employee1.Id = 06;
            employees.Add(employee6);

            Employee employee7 = new Employee();
            employee1.FirstName = "Joe";
            employee1.LastName = "Sawyer";
            employee1.Id = 07;
            employees.Add(employee7);

            Employee employee8 = new Employee();
            employee1.FirstName = "Chris";
            employee1.LastName = "Samm";
            employee1.Id = 08;
            employees.Add(employee8);

            Employee employee9 = new Employee();
            employee1.FirstName = "Sammie";
            employee1.LastName = "McGowan";
            employee1.Id = 09;
            employees.Add(employee9);

            Employee employee10 = new Employee();
            employee1.FirstName = "David";
            employee1.LastName = "Story";
            employee1.Id = 10;
            employees.Add(employee10);

            // Create list to keep filtered results 
            //List<Employee> filteredList = new List<Employee>();

            //// Foreach loop to filter FirstName == "Joe"
            //foreach (Employee employee in employees)
            //{
            //    if (employee.FirstName == "Joe")
            //    {
            //        filteredList.Add(employee);
            //        Console.WriteLine(employee.FirstName + " " + employee.LastName);
            //    }
            //}
            //Console.ReadLine();


            //// Lamda expression to filter FirstName == "Joe"
            //List<Employee> filterList = employees.Where(x => x.FirstName == "Joe").ToList();
            //foreach (Employee employee in filterList)
            //{
            //    Console.WriteLine(employee.FirstName + " " + employee.LastName);
            //}
            //Console.ReadLine();

            // Lambda expression to filter Id > 5
            List<Employee> filterList2 = employees.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in filterList2)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} has an Id of {employee.Id}");
            }

            Console.ReadLine();

        }
    }
}