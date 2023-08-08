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
        //public static bool GetTraineeInfoByID(int ID,
        //    ref string Name, ref string Phone, ref string Photo,
        //    ref DateTime EnrollmentStartDate, ref DateTime EnrollmentEndDate)
        //{
        //    SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

        //    bool isFound = false;
        //    // done
        //    string query = "Select * From Trainers Where Trainers._id = @ID";

        //    SqlCommand cmd = new SqlCommand(query, connection);

        //    cmd.Parameters.AddWithValue("@ID", ID);

        //    try
        //    {
        //        connection.Open();

        //        SqlDataReader reader = cmd.ExecuteReader();

        //        if (reader.Read())
        //        {
        //            isFound = true;

        //            Name = (string)reader["Name"];
        //            Phone = (string)reader["Phone"];
        //            EnrollmentStartDate = (DateTime)reader["EnrollmentStartDate"];
        //            EnrollmentEndDate = (DateTime)reader["EnrollmentEndDate"];
        //            if (reader["Photo"] != DBNull.Value)
        //                Photo = (string)reader["Photo"];
        //            else
        //                Photo = "";
        //        }
        //        else
        //        {
        //            isFound = false;
        //        }
        //        reader.Close();
        //    }
        //    catch (Exception ex)
        //    {

        //        return false;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return isFound;
        //}

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
            string query = "SELECT top(1) Trainers.*, Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd, Subscriptions.TotalAmount,Subscriptions.PaidAmount, Subscriptions.RemainingAmount, Subscriptions.DaysTillSubscriptionExpired FROM  Subscriptions INNER JOIN Trainers ON Subscriptions.[Player _id] = Trainers._id Where Trainers.Name = @Name order by Subscriptions.EnrollmentStart";

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
            SqlCommand cmd = new SqlCommand(query, connection);

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

            string query = "SELECT Trainers.*, Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd, Subscriptions.TotalAmount,Subscriptions.PaidAmount, Subscriptions.RemainingAmount, Subscriptions.DaysTillSubscriptionExpired FROM  Subscriptions INNER JOIN Trainers ON Subscriptions.[Player _id] = Trainers._id";
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
        public static DataTable GetAllActiveTrainees()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);
            string query = "SELECT Trainers.*, Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd, Subscriptions.TotalAmount,Subscriptions.PaidAmount, Subscriptions.RemainingAmount, Subscriptions.DaysTillSubscriptionExpired FROM  Subscriptions INNER JOIN Trainers ON Subscriptions.[Player _id] = Trainers._id where Subscriptions.DaysTillSubscriptionExpired >= 0";
            SqlCommand cmd = new SqlCommand(query, connection);

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
        public static DataTable GetAllBalance(string startDate,string endDate)
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);
            string query = "SELECT Trainers.*, Subscriptions.TotalAmount,Subscriptions.PaidAmount FROM  Subscriptions INNER JOIN Trainers ON Subscriptions.[Player _id] = Trainers._id where Subscriptions.EnrollmentStart between @StartDate and @EndDate";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@StartDate", startDate);
            cmd.Parameters.AddWithValue("@EndDate", endDate);
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
        public static DataTable GetAllTraineesWithRemainings()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);
            string query = "SELECT Trainers.*, Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd, Subscriptions.TotalAmount,Subscriptions.PaidAmount, Subscriptions.RemainingAmount, Subscriptions.DaysTillSubscriptionExpired FROM  Subscriptions INNER JOIN Trainers ON Subscriptions.[Player _id] = Trainers._id where RemainingAmount > 0";
            SqlCommand cmd = new SqlCommand(query, connection);

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
        public static bool IsTraineeExisit(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Trainers WHERE _id = @TraineeID";

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
        public static DataTable GetAllSubscribtionsByPlayerID(int PlayerID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            string query = "Select * From Subscribtions Where PlayerID = @PlayerID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PlayerID", PlayerID);

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
        public static int AddNewSubscribtion(int playerID, DateTime startDate, DateTime endDate,
          int totalAmount, float paidAmount, float remainingAmount,
          int daysTillSubscribtionEnds)
        {
            int TrainneID = -1;
            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            string query = @"INSERT INTO Subscribtions
                             (PlayerID, startDate, endDate, totalAmount, paidAmount ,
                             remainingAmount, daysTillSubscribtionEnds )
                             VALUES
                             (@playerID, @startDate, @endDate, @totalAmount, @paidAmount ,
                             @remainingAmount, @daysTillSubscribtionEnds )
                             SELECT SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@playerID", playerID);
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@endDate", endDate);
            command.Parameters.AddWithValue("@totalAmount", totalAmount);
            command.Parameters.AddWithValue("@paidAmount", paidAmount);
            command.Parameters.AddWithValue("@remainingAmount", remainingAmount);
            command.Parameters.AddWithValue("@daysTillSubscribtionEnds", daysTillSubscribtionEnds);
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
    }

}
