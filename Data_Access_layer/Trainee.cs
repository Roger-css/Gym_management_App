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
            // done
            string query = "Select * From Trainers Where Trainers._id = @ID";

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
            // done
            string query = "SELECT Trainers.*, Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd, Subscriptions.TotalAmount,Subscriptions.PaidAmount, Subscriptions.RemainingAmount, Subscriptions.DaysTillSubscriptionExpired FROM  Subscriptions INNER JOIN Trainers ON Subscriptions._id = Trainers._id Where Trainers.Name = @Name";

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

        public static int AddNewTrainee(string Name, string Phone, string Photo)
        {
            int TrainneID = -1;
            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            string query = @"INSERT INTO Trainers
                            (Name, Phone, Photo )
                             VALUES(@Name, @Phone, @Photo)
                             SELECT SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Phone", Phone);

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

            string query = @"Update Trainers
                             set Name = @Name
                                  Phone = @Phone
                                  Photo = @Photo
                                  Where _id = @TraineeID";
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

            string query = "Select * From Trainers";
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

        public static bool IsTraineeExisit(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Trainees WHERE _id = @TraineeID";

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
    }

}
