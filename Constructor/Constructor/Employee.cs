﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class NewEmployee
    {
        public string firstName;
        public string lastName;
        public NewEmployee()
        {
            Console.WriteLine("New Employee")
        }
        public NewEmployee(string firstName)
        {
            this.firstName = firstName;
        }
        public NewEmployee(string firstName, string lastName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            Console.WriteLine("New Employee");
        }
        
    }
    
}
