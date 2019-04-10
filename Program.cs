using System;

namespace listEmployeesWorking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company rocketway = new Company("RocketWay", DateTime.Now);

            // Create three employees
            Employee bob = new Employee("Bob", "Dole", "Politician");
            Employee john = new Employee("John", "Harbaugh", "Coach");
            Employee chris = new Employee("Chris", "Johnson", "Athlete");

            // Assign the employees to the company
            rocketway.AddEmployees(bob);
            rocketway.AddEmployees(john);
            rocketway.AddEmployees(chris);


            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
//since i  am getting information from the company and employee cs files the loop must be in the program.cs and utilize the directory.***
            foreach (Employee employee in rocketway.Employees)
            {

                Console.WriteLine($@"
{employee.firstName} {employee.lastName} works at {rocketway.Name}as {employee.title} since {employee.startDate}.");

            }
//method to show all employees

        //    foreach (Employee employee in rocketway.Employees)
        //    {
        //        Console.WriteLine(employee);
        //    }


        }
    }

}
