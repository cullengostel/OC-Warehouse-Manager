using Forms_Application.Classes.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Forms_Application.Classes.Controllers
{
    public class DistributorController
    {
        public List<Distributor> DistributorList = new();
        
        public DistributorController()
        {
            DistributorList = GetAllDistributors();
        }

        public Distributor GetDistributor(String name)
        {
            foreach(Distributor d in DistributorList)
            {
                if (d.Name.Equals(name))
                {
                    return d;
                }
            }
            return null;
        }

        public Distributor GetDistributor(int id)
        {
            foreach (Distributor d in DistributorList)
            {
                if (d.DistributorID == id)
                {
                    return d;
                }
            }
            return null;
        }

        private List<Distributor> GetAllDistributors()
        {
            List<Distributor> distributors = new();
            string connectionString = ConfigurationManager.ConnectionStrings["WarehouseDatabase"].ConnectionString
            using (SqlConnection connection = new(connectionString)) // Use SQLiteConnection for SQLite
            {
                string query = "SELECT DistributorID, Name, ContactInfo FROM Distributor";
                SqlCommand command = new SqlCommand(query, connection); // Use SQLiteCommand for SQLite

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()) // Use SQLiteDataReader for SQLite
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0); // DistributorID
                            string name = reader.GetString(1); // Name
                            string contactInfo = reader.GetString(2); // ContactInfo

                            // Create a Distributor object and add it to the list
                            Distributor distributor = new Distributor(id, name, contactInfo);
                            distributors.Add(distributor);
                        }
                    }
                }
                catch (SqlException ex) // Catch SQL exceptions
                {
                    Console.WriteLine($"SQL Error: {ex.Message}");
                }
                catch (Exception ex) // Catch general exceptions
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return distributors;
        }
    }
}
