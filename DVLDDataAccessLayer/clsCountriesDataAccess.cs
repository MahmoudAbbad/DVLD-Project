using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public class clsCountriesDataAccess
    {
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Countries;";

            SqlCommand Command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool GetCountry(int ID , ref string CountryName)
        {
            bool Found = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Countries WHERE CountryID = @ID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CountryName = (string)reader["CountryName"];
                    Found = true;

                }
                
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return Found;
        }
        public static bool GetCountry(ref int CountryId,string CountryName)
        {
            bool Found = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT * FROM Countries WHERE CountryName = @CountryName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CountryId = (int)reader["CountryID"];
                    Found = true;
                }
                
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return Found;

        }
      
    }
}
