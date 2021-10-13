using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\PHILI\ONEDRIVE\DESKTOP\C-SHARP-PROJECTS\CARINSURANCE\CARINSURANCE\APP_DATA\INSURANCE.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        // GET: Admin
        public ActionResult Dashboard()
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, Quote from Insurees";
            List<Insured> insured = new List<Insured>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var insuree = new Insured();
                    insuree.Id = Convert.ToInt32(reader["Id"]);
                    insuree.FirstName = reader["FirstName"].ToString();
                    insuree.LastName = reader["LastName"].ToString();
                    insuree.EmailAddress = reader["EmailAddress"].ToString();
                    insuree.Quote = Convert.ToInt32(reader["Quote"]);
                    insured.Add(insuree);
                }
            }

            return View(insured);
        }
    }
}