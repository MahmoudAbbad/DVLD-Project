using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public class clsUsersDataAccess
    {
        public static bool IsUserExistByUserNameAndPassword(string UserName , string Password)
        {
            bool IsLogined = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT 1 FROM Users where UserName = @Username and Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", UserName);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    IsLogined = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return IsLogined; 
        }

        public static bool FindUserByUserNameAndPass(ref int UserID, ref int PersonID , string UserName , string Password , ref bool IsActive)
        {
            bool IsExist = false;
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Users where UserName = @Username and Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read() != null)
                {
                    UserID = int.Parse(reader["UserID"].ToString());
                    PersonID = int.Parse(reader["PersonID"].ToString());
                    IsActive = bool.Parse(reader["IsActive"].ToString());

                    IsExist = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return IsExist;
        }

        public static bool FindUserByUserName(ref int UserID, ref int PersonID, string UserName,ref string Password, ref bool IsActive)
        {
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Users where UserName = @Username;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", UserName);
            

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read() != null)
                {
                    UserID = int.Parse(reader["UserID"].ToString());
                    PersonID = int.Parse(reader["PersonID"].ToString());
                    IsActive = bool.Parse(reader["IsActive"].ToString());
                    Password = reader["Password"].ToString();

                    IsExist = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return IsExist;
        }

        public static bool FindUserByID(int UserID, ref int PersonID,ref string UserName, ref string Password, ref bool IsActive)
        {
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Users where UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read() != null)
                {
                    PersonID = int.Parse(reader["PersonID"].ToString());
                    IsActive = bool.Parse(reader["IsActive"].ToString());
                    Password = reader["Password"].ToString();
                    UserName = reader["UserName"].ToString();

                    IsExist = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return IsExist;
        }

        public static DataTable GetAllUsers()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT Users.UserID, Users.PersonID, People.FirstName+ " +
                "People.SecondName+ People.ThirdName+ People.LastName as FullName," +
                " Users.UserName, Users.IsActive FROM  People INNER JOIN  Users " +
                "ON People.PersonID = Users.PersonID";
            DataTable dt = new DataTable();
            
            SqlCommand commen = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = commen.ExecuteReader();
               
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


    }
}
