using System;
using System.Collections.Generic;

namespace listEmployeesWorking
{
    public class Company
    {
       public DateTime CreatedOn{get;}
       public string Name {get;}
       public List<Employee> Employees{get; set;} = new List<Employee>();

        //constructor to create company
       public Company(string companyName, DateTime creation){
           Name = companyName;
           CreatedOn = creation;
       }
       //method to add employees to list
       public void AddEmployees(Employee employee){
           Employees.Add(employee);
       }






    }

}
