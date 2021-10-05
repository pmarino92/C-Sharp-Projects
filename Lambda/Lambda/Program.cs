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
            employee1.FirstName = "Bob";
            employee1.LastName = "Smith";
            employee1.Id = 01;
            employees.Add(employee1);

            Employee employee2 = new Employee();
            employee2.FirstName = "Joe";
            employee2.LastName = "Burrow";
            employee2.Id = 02;
            employees.Add(employee2);

            Employee employee3 = new Employee();
            employee3.FirstName = "Phil";
            employee3.LastName = "Marino";
            employee3.Id = 03;
            employees.Add(employee3);

            Employee employee4 = new Employee();
            employee4.FirstName = "Taylor";
            employee4.LastName = "Smith";
            employee4.Id = 04;
            employees.Add(employee4);

            Employee employee5 = new Employee();
            employee5.FirstName = "Jerry";
            employee5.LastName = "Rice";
            employee5.Id = 05;
            employees.Add(employee5);

            Employee employee6 = new Employee();
            employee6.FirstName = "Davis";
            employee6.LastName = "Lee";
            employee6.Id = 06;
            employees.Add(employee6);

            Employee employee7 = new Employee();
            employee7.FirstName = "Joe";
            employee7.LastName = "Sawyer";
            employee7.Id = 07;
            employees.Add(employee7);

            Employee employee8 = new Employee();
            employee8.FirstName = "Chris";
            employee8.LastName = "Samm";
            employee8.Id = 08;
            employees.Add(employee8);

            Employee employee9 = new Employee();
            employee9.FirstName = "Sammie";
            employee9.LastName = "McGowan";
            employee9.Id = 09;
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