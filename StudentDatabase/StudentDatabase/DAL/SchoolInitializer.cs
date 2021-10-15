using StudentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentDatabase.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstName="Carson",LastName="Alexander", },
            new Student{FirstName="Meredith",LastName="Alonso", },
            new Student{FirstName="Arturo",LastName="Anand", },
            new Student{FirstName="Gytis",LastName="Barzdukas", },
            new Student{FirstName="Yan",LastName="Li", },
            new Student{FirstName="Peggy",LastName="Justice", },
            new Student{FirstName="Laura",LastName="Norman", },
            new Student{FirstName="Nino",LastName="Olivetto", },
            };
            context.SaveChanges();
        }
    }
}