using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices.ComTypes;
using System.Xml.Linq;

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
            catch (Exception)
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



        public static DataTable GetTraineeLastSub(string Name)
        {
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @"SELECT  Top(1) *
                        FROM (
                            SELECT Trainers._id, Trainers.Name, Trainers.Phone,
                                   Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd,
                                   Subscriptions.TotalAmount, Subscriptions.PaidAmount,
                                   (Subscriptions.TotalAmount - Subscriptions.PaidAmount) AS RemainingAmount,
                                   DATEDIFF(day, EnrollmentEnd, EnrollmentStart) AS DaysTillSubscriptionExpired
                            FROM Subscriptions
                            INNER JOIN Trainers ON Subscriptions.[Player_id] = Trainers._id
                             Where Name = @Name
                        ) R1
                        WHERE DaysTillSubscriptionExpired BETWEEN 31 AND -30
                        ORDER BY REnrollmentStart DESC;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        dt = null;
                        // Handle the exception appropriately
                    }

                    return dt;
                }
            }
        }

        public static DataTable GetTraineeAllSubsByName(string name)
        {
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @"SELECT Trainers._id, Trainers.Name, Trainers.Phone,
                                   Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd,
                                   Subscriptions.TotalAmount, Subscriptions.PaidAmount,
                                   (Subscriptions.TotalAmount - Subscriptions.PaidAmount) AS RemainingAmount,
                                   DATEDIFF(day, EnrollmentEnd, EnrollmentStart) AS DaysTillSubscriptionExpired
                            FROM Subscriptions
                            INNER JOIN Trainers ON Subscriptions.[Player_id] = Trainers._id
                            WHERE Trainers.Name LIKE '%' + @Name + '%'
                            ORDER BY EnrollmentStart DESC";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", name);

                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        dt = null;
                        // Handle the exception appropriately
                    }

                    return dt;
                }
            }
        }

        public static DataTable GetTraineesLastSub()
        {
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @"SELECT _id, Name, Phone,
                                   EnrollmentStart, EnrollmentEnd,
                                   TotalAmount, PaidAmount,
                                   (TotalAmount - PaidAmount) AS RemainingAmount,
                                   DATEDIFF(day, GETDATE(), EnrollmentEnd) AS DaysTillSubscriptionExpired
                            FROM (
                                SELECT Trainers._id, Trainers.Name, Trainers.Phone,
                                       Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd,
                                       Subscriptions.TotalAmount, Subscriptions.PaidAmount,
                                       ROW_NUMBER() OVER (PARTITION BY Trainers._id ORDER BY Subscriptions.EnrollmentEnd DESC) AS RowNum
                                FROM Trainers
                                INNER JOIN Subscriptions ON Trainers._id = Subscriptions.Player_id
                            ) R2
                            WHERE RowNum = 1 ";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        dt = null;
                        // Handle the exception appropriately
                    }

                    return dt;
                }
            }
        }
        public static DataTable GetTraineesAllSubs()
        {
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @"SELECT Trainers._id, Trainers.Name, Trainers.Phone,
                               Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd,
                               Subscriptions.TotalAmount, Subscriptions.PaidAmount,
                               (Subscriptions.TotalAmount - Subscriptions.PaidAmount) AS RemainingAmount,
                               DATEDIFF(day, EnrollmentEnd, EnrollmentStart) AS DaysTillSubscriptionExpired
                        FROM Subscriptions
                        INNER JOIN Trainers ON Subscriptions.[Player_id] = Trainers._id
                        ORDER BY Trainers.Name, EnrollmentStart DESC";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        dt = null;
                        // Handle the exception appropriately
                    }

                    return dt;
                }
            }
        }

        public static DataTable GetTraineesExpiredSubscription()
        {
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @"SELECT *
                            FROM (
                                SELECT Trainers._id, Trainers.Name, Trainers.Phone,
                                       Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd,
                                       Subscriptions.TotalAmount, Subscriptions.PaidAmount,
                                       (Subscriptions.TotalAmount - Subscriptions.PaidAmount) AS RemainingAmount,
                                       DATEDIFF(day, GETDATE(), Subscriptions.EnrollmentEnd) AS DaysTillSubscriptionExpired
                                FROM Subscriptions
                                INNER JOIN Trainers ON Subscriptions.[Player_id] = Trainers._id  
                            ) DateRemaining
                            WHERE DaysTillSubscriptionExpired BETWEEN 0 AND -31";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {


                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        dt = null;
                        // Handle the exception appropriately
                    }

                    return dt;
                }
            }
        }

        public static int AddNewTrainee(string Name, string Phone, string Photo)
        {
            int TrainneID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @"select PlayerID FROM 
                                 (
                                 INSERT INTO Trainers
                                    (Name, Phone, Photo )
                                    VALUES(@Name, @Phone, @Photo)
                                    SELECT SCOPE_IDENTITY()    
                                 )  ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Phone", Phone);

                    if (!string.IsNullOrEmpty(Photo))
                        command.Parameters.AddWithValue("@Photo", Photo);
                    else
                        command.Parameters.AddWithValue("@Photo", DBNull.Value);

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
                        // Handle the exception appropriately
                    }
                }
            }

            return TrainneID;
        }

        public static decimal GetBalanceByDates(DateTime startDate, DateTime endDate)
        {
            decimal totalAmount = 0;

            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @"SELECT SUM(Subscriptions.TotalAmount) As TotalAmount
                         FROM  Subscriptions 
                         WHERE Subscriptions.EnrollmentStart BETWEEN @StartDate AND @EndDate";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    try
                    {
                        connection.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && decimal.TryParse(result.ToString(),
                            out decimal value))
                        {
                            totalAmount = value;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception here or log it
                        // Return an appropriate value or rethrow the exception
                        return -1;
                    }
                }
            }
            return totalAmount;
        }
        public static decimal GetRemainingByDates(DateTime startDate, DateTime endDate)
        {
            decimal totalAmount = 0;

            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @"SELECT SUM(RemainingAmount) As TotalAmount
                                FROM (
                                    SELECT (Subscriptions.TotalAmount - Subscriptions.PaidAmount) AS RemainingAmount
                                    FROM Subscriptions
                                    WHERE Subscriptions.EnrollmentStart BETWEEN @StartDate AND @EndDate
                                    )";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    try
                    {
                        connection.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && decimal.TryParse(result.ToString(),
                            out decimal value))
                        {
                            totalAmount = value;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception here or log it
                        // Return an appropriate value or rethrow the exception
                        return -1;
                    }
                }
            }
            return totalAmount;
        }
        public static DataTable GetTraineesByDatesWithRemaining(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @"SELECT *
                FROM (
                    SELECT Trainers._id, Trainers.Name, Trainers.Phone,
                           Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd,
                           Subscriptions.TotalAmount, Subscriptions.PaidAmount,
                           (Subscriptions.TotalAmount - Subscriptions.PaidAmount) AS RemainingAmount,
                           DATEDIFF(day, EnrollmentEnd, EnrollmentStart) AS DaysTillSubscriptionExpired
                    FROM Subscriptions
                    INNER JOIN Trainers ON Subscriptions.[Player_id] = Trainers._id
                    WHERE Subscriptions.EnrollmentStart BETWEEN @StartDate AND @EndDate
                ) DateRemaining
                WHERE RemainingAmount > 0";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        dt = null;
                        // Handle the exception appropriately
                    }

                    return dt;
                }
            }
        }

        public static DataTable GetTraineesSubscriptionsByDates(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @" 
                               SELECT Trainers._id, Trainers.Name, Trainers.Phone,
                               Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd,
                               Subscriptions.TotalAmount, Subscriptions.PaidAmount,
                               (Subscriptions.TotalAmount - Subscriptions.PaidAmount) AS RemainingAmount,
                               DATEDIFF(day, GETDATE(), Subscriptions.EnrollmentEnd) AS DaysTillSubscriptionExpired
                                FROM Subscriptions
                                INNER JOIN Trainers ON Subscriptions.[Player_id] = Trainers._id
                                WHERE Subscriptions.EnrollmentStart BETWEEN @StartDate AND @EndDate";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        dt = null;
                        // Handle the exception appropriately
                    }

                    return dt;
                }
            }
        }

        public static bool UpdateTrainee(int ID, string Name, string Phone, string Photo)
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
        public static bool UpdateTraineeSubscription(int PalyerID, DateTime EnrollmentStartDate,
             DateTime EnrollmentEndDate, int totalAmount, float paidAmount)
        {

            bool success = false;
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {

                string query = @"
                               UPDATE TOP (1) Subscriptions
                               SET EnrollmentStart = @EnrollmentStartDate,
                                    EnrollmentEnd = @EnrollmentEndDate,
                                    TotalAmount = @TotalAmount,
                                    PaidAmount = @PaidAmount
                                WHERE playerid = @PlayerID
                                ORDER BY EnrollmentStart DESC;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EnrollmentStartDate", EnrollmentStartDate);
                    command.Parameters.AddWithValue("@EnrollmentEndDate", EnrollmentEndDate);
                    command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    command.Parameters.AddWithValue("@PaidAmount", paidAmount);
                    command.Parameters.AddWithValue("@PlayerID", PalyerID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            success = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        success = false;
                    }
                }
            }
            return success;
        }

        public static DataTable GetLastSubscriptionByPlayerID(int ID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @"SELECT TOP(1) Trainers._id, Trainers.Name, Trainers.Phone,
                               Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd,
                               Subscriptions.TotalAmount, Subscriptions.PaidAmount,
                               (Subscriptions.TotalAmount - Subscriptions.PaidAmount) AS RemainingAmount,
                               DATEDIFF(day, EnrollmentEnd, EnrollmentStart) AS DaysTillSubscriptionExpired
                                FROM Subscriptions
                                INNER JOIN Trainers ON Subscriptions.[Player_id] = Trainers._id
                                WHERE Trainers._id = @ID
                                ORDER BY EnrollmentStart DESC;";


                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", ID);
                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        dt = null;
                        // Handle the exception appropriately
                    }

                    return dt;
                }
            }
        }

        public static DataTable GetAllSubscriptionsByPlayerID(int PlayerID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);


            string query = @"SELECT Trainers._id, Trainers.Name, Trainers.Phone,
                                 Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd,
                                 Subscriptions.TotalAmount, Subscriptions.PaidAmount,
                                 (Subscriptions.TotalAmount - Subscriptions.PaidAmount) AS RemainingAmount,
                                 DATEDIFF(day, EnrollmentEnd, EnrollmentStart) AS DaysTillSubscriptionExpired
                            FROM Subscriptions
                            INNER JOIN Trainers ON Subscriptions.[Player_id] = Trainers._id
                            WHERE Trainers.Name = @PlayerID
                            ORDER BY EnrollmentStart DESC";
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


        public static int AddNewSubscription(int playerID, DateTime startDate, DateTime endDate,
     int totalAmount, float paidAmount)
        {
            int subscriptionID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @"INSERT INTO Subscribtions
                         (PlayerID, startDate, endDate, totalAmount, paidAmount ,
                          )
                         VALUES
                         (@playerID, @startDate, @endDate, @totalAmount, @paidAmount ,
                          )
                         SELECT SCOPE_IDENTITY()";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@playerID", playerID);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);
                    command.Parameters.AddWithValue("@totalAmount", totalAmount);
                    command.Parameters.AddWithValue("@paidAmount", paidAmount);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int value))
                        {
                            subscriptionID = value;
                        }
                    }
                    catch (Exception ex)
                    {
                        return -1;
                        // Handle the exception appropriately
                    }
                }
            }

            return subscriptionID;
        }




    }
}
