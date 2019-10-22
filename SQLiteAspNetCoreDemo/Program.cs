using System;
using System.Linq;

namespace SQLiteAspNetCoreDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SQLiteDBContext())
            {
                // Create
                Console.WriteLine("Add New Employee: ");
                db.Employees.Add(new Employee { FirstName = "John", LastName = "Doe", Age = 55 });
                db.SaveChanges();

                Console.WriteLine("Employee has been added sucessfully.");

                // Read
                Console.WriteLine("Querying table for that employee.");
                var employee = db.Employees
                    .OrderBy(b => b.Id)
                    .First();

                Console.WriteLine("The employee found: {0} {1} and is {2} years old.", employee.FirstName, employee.LastName, employee.Age);

                // Update
                Console.WriteLine("Updating the employee first name and age.");

                employee.FirstName = "Louis";
                employee.Age = 90;

                Console.WriteLine("Newly updated employee is: {0} {1} and is {2} years old.", employee.FirstName, employee.LastName, employee.Age);

                db.SaveChanges();

                // Delete
                Console.WriteLine("Delete the employee.");

                db.Remove(employee);
                db.SaveChanges();
            }
        }
    }
}
