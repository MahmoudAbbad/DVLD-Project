using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer.Users
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

        public static clsUserEntity FindUserByUserNameAndPass(string UserName , string Password)
        {
            clsUserEntity user = new();   
            
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
                    user.UserID = int.Parse(reader["UserID"].ToString());
                    user.PersonID = int.Parse(reader["PersonID"].ToString());
                    user.IsActive = bool.Parse(reader["IsActive"].ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                user = null;
            }
            finally
            {
                connection.Close();
            }


            return user;
        }

        public static clsUserEntity FindUserByUserName(string userName)
        {
            bool IsExist = false;
            clsUserEntity user = new clsUserEntity();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Users where UserName = @Username;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", userName);
            

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read() != null)
                {
                    user.UserID = int.Parse(reader["UserID"].ToString());
                    user.PersonID = int.Parse(reader["PersonID"].ToString());
                    user.IsActive = bool.Parse(reader["IsActive"].ToString());
                    user.Password = reader["Password"].ToString();

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


            return user;
        }

        public static clsUserEntity FindUserByID(int UserID)
        {
            bool IsExist = false;
            clsUserEntity user = new clsUserEntity();

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
                    user.PersonID = int.Parse(reader["PersonID"].ToString());
                    user.IsActive = bool.Parse(reader["IsActive"].ToString());
                    user.Password = reader["Password"].ToString();
                    user.UserName = reader["UserName"].ToString();

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


            return user;
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
