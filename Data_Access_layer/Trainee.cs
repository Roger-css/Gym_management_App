using System;
using System.Data;
using System.Data.SqlClient;

namespace GymDataAccesLayer
{
    public class clsTraineeDataAccess
    {


        /// <summary>
        ///  Take ID And Search For It in DB
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Name"></param>
        /// <param name="Phone"></param>
        /// <param name="Photo"></param>
        /// <param name="EnrollmentStartDate"></param>
        /// <param name="EnrollmentEndDate"></param>
        /// <returns>True if Found False If Not</returns>
        public static bool GetTraineeInfoByID(int ID,
            ref string Name, ref string Phone, ref string Photo,
            ref DateTime EnrollmentStartDate, ref DateTime EnrollmentEndDate)
        {
            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            bool isFound = false;
            // Here Become Your Trun Wolfy
            string query = "Select * From Trainees Where TraineeID = @ID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Name = (string)reader["Name"];
                    Phone = (string)reader["Phone"];
                    EnrollmentStartDate = (DateTime)reader["EnrollmentStartDate"];
                    EnrollmentEndDate = (DateTime)reader["EnrollmentEndDate"];
                    if (reader["Photo"] != DBNull.Value)
                        Photo = (string)reader["Photo"];
                    else
                        Photo = "";
                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                return false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        /// <summary>
        /// function take Name And Search For It inDB
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Name"></param>
        /// <param name="Phone"></param>
        /// <param name="Photo"></param>
        /// <param name="EnrollmentStartDate"></param>
        /// <param name="EnrollmentEndDate"></param>
        /// <returns> True if Found False If Not </returns>
        public static bool GetTraineeInfoByName(ref int ID,
            string Name, ref string Phone, ref string Photo,
            ref DateTime EnrollmentStartDate, ref DateTime EnrollmentEndDate)
        {
            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            bool isFound = false;
            // Here Become Your Trun Wolfy
            string query = "Select * From Trainees Where  Name = @Name";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["ID"];
                    Name = (string)reader["Name"];
                    Phone = (string)reader["Phone"];
                    EnrollmentStartDate = (DateTime)reader["EnrollmentStartDate"];
                    EnrollmentEndDate = (DateTime)reader["EnrollmentEndDate"];
                    if (reader["Photo"] != DBNull.Value)
                        Photo = (string)reader["Photo"];
                    else
                        Photo = "";
                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                return false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewTrainee(
            string Name, string Phone, string Photo,
            DateTime EnrollmentStartDate, DateTime EnrollmentEndDate)
        {
            int TrainneID = -1;
            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            string query = @"INSERT INTO Trainees
                            (Name, Phone, Photo, EnrollmentStartDate, EnrollmentEndDate )
                             VALUES(@Name, @Phone, @Photo, @EnrollmentStartDate, EnrollmentEndDate)
                             SELECT SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("Phone", Phone);
            command.Parameters.AddWithValue("@EnrollmentStartDate", EnrollmentStartDate);
            command.Parameters.AddWithValue("@EnrollmentEndDate", EnrollmentEndDate);

            if (Photo != "" && Photo != null)
                command.Parameters.AddWithValue("@Photo", Photo);
            else
                command.Parameters.AddWithValue("@Photo", System.DBNull.Value);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int value))
                {
                    TrainneID = value;
                }
            }
            catch (Exception ex)
            {

                return -1;
            }
            finally
            {
                connection.Close();
            }

            return TrainneID;
        }




        public static bool UpdateTrainee(int ID ,string Name, string Phone, string Photo)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            string query = @"Update Trainees
                             set Name = @Name
                                  Phone = @Phone
                                  Photo = @Photo
                                  Where TraineeID = @TraineeID";
            SqlCommand  cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@TraineeID", ID);


            if (Photo != "" && Photo != null)
                cmd.Parameters.AddWithValue("@Photo", Photo);
            else
                cmd.Parameters.AddWithValue("@Photo", System.DBNull.Value);

            try
            {
                connection.Open ();
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex )
            {

                return false ;
            } 
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static DataTable GetAllTrainees()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            string query = "Select * From Trainees";
            SqlCommand cmd = new SqlCommand (query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                return null;
            }
            finally { 
                connection.Close(); 
            }
            return dt;
        }
    
        public static bool DeleteTrainee(int ID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            string query = @"Delete Trainees
                                     where TraineeID = @TraineeID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TraineeID", ID);

            try
            {
                connection.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                return false;
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static bool IsTraineeExisit(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Trainees WHERE TraineeID = @TraineeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TraineeID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static DataTable GetTraineesBetweenAge(int From, int To)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            string query = @"Select * From Trainees     
                                Where Age >= @From && Age <= @To";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@From", From);
            cmd.Parameters.AddWithValue("@To", To);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }

}
