using Microsoft.Data.SqlClient;
using System.Data;
namespace DVLDDataAccessLayer.Person
{
    public class clsPeopleDataAccess
    {
        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT People.PersonID, People.NationalNo, People.FirstName, " +
"People.SecondName, People.ThirdName, People.LastName, " +
"CASE WHEN People.Gendor = 0 THEN 'Male' ELSE 'Female' END AS Gender, " +
"People.DateOfBirth, Countries.CountryName AS 'Nationality', People.Phone, People.Email " +
"FROM People JOIN Countries ON People.NationalityCountryID = Countries.CountryID";


            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

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
        public static clsPersonEntity GetPersonById(int PersonID)
        {
            clsPersonEntity person = new clsPersonEntity();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM People where PersonID = @PersonID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read() != null)
                {
                    person.PersonID = PersonID;
                    person.NationalNo = reader["NationalNo"].ToString();
                    person.FirstName = reader["FirstName"].ToString();
                    person.SecondName = reader["SecondName"].ToString();
                    person.ThirdName = reader["ThirdName"].ToString();
                    person.LastName = reader["LastName"].ToString();
                    person.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    person.Gendor = reader["Gendor"].ToString();
                    person.Address = reader["Address"].ToString();
                    person.Phone = reader["Phone"].ToString();
                    person.Email = reader["Email"].ToString();
                    clsCountriesDataAccess.GetCountry(Convert.ToInt32(reader["NationalityCountryID"]), ref person.NationalityCountry);
                    person.ImagePath = reader["ImagePath"].ToString();
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

            return person;
        }

        public static int AddPerson(clsPersonEntity person)
        {
            int NatinoalityCountryID = 0;
            clsCountriesDataAccess.GetCountry(ref NatinoalityCountryID, person.NationalityCountry);


            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "Insert Into People (NationalNo,FirstName,SecondName , ThirdName,LastName," +
                "DateOfBirth,Gendor,Address,Phone,Email,NationalityCountryID,ImagePath) values" +
                "(@NationalNo,@FirstName,@SecondName ,@ThirdName,@LastName" +
                ",@DateOfBirth,@Gendor,@Address,@Phone,@Email,@NationalCountryID,@ImagePath);" +
                "Select Scope_Identity();";

            SqlCommand command = new SqlCommand(query, connection);

            byte GenderNum = 0;

            if (person.Gendor == "Female")
            {
                GenderNum = 1;
            }

            command.Parameters.AddWithValue("@NationalNo", person.NationalNo);
            command.Parameters.AddWithValue("@FirstName", person.FirstName);
            command.Parameters.AddWithValue("@SecondName", person.SecondName);
            command.Parameters.AddWithValue("@ThirdName", person.ThirdName);
            command.Parameters.AddWithValue("@LastName", person.LastName);
            command.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", GenderNum);
            command.Parameters.AddWithValue("@Address", person.Address);
            command.Parameters.AddWithValue("@Phone", person.Phone);
            command.Parameters.AddWithValue("@Email", person.Email);
            command.Parameters.AddWithValue("@NationalCountryID", NatinoalityCountryID);

            if (person.ImagePath == null)
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", person.ImagePath);
            }

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedPersonID))
                {
                    PersonID = InsertedPersonID;
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

            return PersonID;
        }

        public static bool UpdatePerson(clsPersonEntity person)
        {
            int NatinoalityCountryID = 0;
            clsCountriesDataAccess.GetCountry(ref NatinoalityCountryID, person.NationalityCountry);

            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "Update People set NationalNo = @NationalNo,FirstName = @FirstName," +
                "SecondName = @SecondName , ThirdName = @ThirdName,LastName = @LastName," +
                "DateOfBirth = @DateOfBirth,Gendor = @Gendor,Address = @Address," +
                "Phone = @Phone,Email = @Email,NationalityCountryID = @NationalCountryID," +
                "ImagePath = @ImagePath where PersonID = @PersonID;";

            byte GendorNumber = 0;

            if (person.Gendor == "Male")
            {
                GendorNumber = 0;
            }
            else
            {
                GendorNumber = 1;
            }

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", person.PersonID);
            command.Parameters.AddWithValue("@NationalNo", person.NationalNo);
            command.Parameters.AddWithValue("@FirstName", person.FirstName);
            command.Parameters.AddWithValue("@SecondName", person.SecondName);
            command.Parameters.AddWithValue("@ThirdName", person.ThirdName);
            command.Parameters.AddWithValue("@LastName", person.LastName);
            command.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", GendorNumber);
            command.Parameters.AddWithValue("@Address", person.Address);
            command.Parameters.AddWithValue("@Phone", person.Phone);
            command.Parameters.AddWithValue("@Email", person.Email);
            command.Parameters.AddWithValue("@NationalCountryID", NatinoalityCountryID);

            if (string.IsNullOrEmpty(person.ImagePath))
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", person.ImagePath);
            }

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    IsUpdated = true;
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
            return IsUpdated;
        }

        public static bool DeletePerson(int personID)
        {
            bool IsDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "Delete From People where PersonID = @PersonID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", personID);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    IsDeleted = true;
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
            return IsDeleted;
        }
        public static bool IsNationalityNoValid(string NationalNo)
        {
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "Select 1 from People where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    IsExist = true;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }

            return !IsExist;
        }
    }
}
