using System;
using System.Collections.Generic;

namespace listEmployeesWorking
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string title;
        public DateTime startDate;


        //constructor HAS TO BE THE SAME NAME AS CLASS!!!
        public Employee(string first, string last, string jobTitle){
            firstName = first;
            lastName = last;
            title = jobTitle;
            startDate = DateTime.Now;
        }


    }

}