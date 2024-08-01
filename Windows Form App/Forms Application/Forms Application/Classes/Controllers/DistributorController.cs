using Forms_Application.Classes.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Diagnostics;

namespace Forms_Application.Classes.Controllers
{
    public class DistributorController
    {
        private List<Distributor> DistributorsList = new();
        
        public DistributorController()
        {
            DistributorsList = GetAllDistributors();
        }

        public Distributor GetDistributor(String name)
        {
            foreach(Distributor d in DistributorsList)
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
            foreach (Distributor d in DistributorsList)
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
            string connectionString = ConfigurationManager.ConnectionStrings["WarehouseDatabase"].ConnectionString;
            using (SqliteConnection connection = new(connectionString)) 
            {
                string query = "SELECT DistributorID, Name, ContactInfo FROM Distributors";
                var command = new SqliteCommand(query, connection); 

                try
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader()) 
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
                catch (SqliteException ex) 
                {
                    Console.WriteLine($"SQL Error: {ex.Message}");
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return distributors;
        }

        public void Debug_LogAllDistributors()
        {
            foreach(Distributor d in DistributorsList)
            {
                Debug.WriteLine(d.ToString());
            }
        }
    }
}
