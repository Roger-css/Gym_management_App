using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
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
        /// <param name="Phone"></param>s
        /// <param name="Photo"></param>
        /// <param name="EnrollmentStartDate"></param>
        /// <param name="EnrollmentEndDate"></param>
        /// <returns>True if Found False If Not</returns>
        public static bool GetTraineeInfoByID(int ID,
            ref string Name, ref string Phone, ref string Photo)
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



        public static DataTable GetTraineeLastSub(string Name)
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
                    WHERE Trainers.Name LIKE '%' + @Name + '%'
                ) R2
                WHERE R2.RowNum = 1";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
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
                string query = "SELECT Trainers._id, Trainers.Name, Trainers.Phone, Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd, Subscriptions.TotalAmount, Subscriptions.PaidAmount, (Subscriptions.TotalAmount - Subscriptions.PaidAmount) AS RemainingAmount, DATEDIFF(day, GETDATE(), EnrollmentEnd) AS DaysTillSubscriptionExpired FROM Subscriptions INNER JOIN Trainers ON Subscriptions.Player_id = Trainers._id WHERE Trainers.Name COLLATE Arabic_CI_AI LIKE N'%' + @Name + N'%' ORDER BY EnrollmentStart DESC";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", name);

                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
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
                            if (reader.HasRows)
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
                string query = "SELECT Trainers._id, Trainers.Name, Trainers.Phone,Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd,Subscriptions.TotalAmount, Subscriptions.PaidAmount,(Subscriptions.TotalAmount - Subscriptions.PaidAmount) AS RemainingAmount,DATEDIFF(day, GETDATE(), EnrollmentEnd) AS DaysTillSubscriptionExpired FROM Subscriptions INNER JOIN Trainers ON Subscriptions.[Player_id] = Trainers._id ORDER BY Trainers.Name";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess))
                        {

                            if (reader.HasRows)
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
                string query = @"SELECT _id, Name, Phone,
                                   EnrollmentStart, EnrollmentEnd,
                                   TotalAmount, PaidAmount,
                                   (TotalAmount - PaidAmount) AS RemainingAmount,
                                    DaysTillSubscriptionExpired
                            FROM (
                                SELECT Trainers._id, Trainers.Name, Trainers.Phone,
                                       Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd,
                                       Subscriptions.TotalAmount, Subscriptions.PaidAmount,
                                    DATEDIFF(day, GETDATE(), EnrollmentEnd) AS DaysTillSubscriptionExpired,                              
                                       ROW_NUMBER() OVER (PARTITION BY Trainers._id ORDER BY Subscriptions.EnrollmentEnd DESC) AS RowNum
                                FROM Trainers
                                INNER JOIN Subscriptions ON Trainers._id = Subscriptions.Player_id
                            ) R2
                            WHERE RowNum = 1  And DaysTillSubscriptionExpired Between -31 And 0;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {


                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
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
                string query = @"
                            INSERT INTO Trainers (Name, Phone, Photo)
                            VALUES (@Name, @Phone, @Photo);
                            SELECT SCOPE_IDENTITY();
                                                    ";
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
        public static decimal GetPaidByDates(DateTime startDate, DateTime endDate)
        {
            decimal totalAmount = 0;

            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @"SELECT SUM(Subscriptions.PaidAmount) As PaidAmount
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
                            if (reader.HasRows)
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
        public static DataTable GetTraineesWithRemaining()
        {
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @"SELECT *
                FROM (
                    SELECT Trainers._id, Trainers.Name, Trainers.Phone,
                           Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd,
                           Subscriptions.TotalAmount, Subscriptions.PaidAmount,
                           (Subscriptions.TotalAmount - Subscriptions.PaidAmount) AS RemainingAmount,
                           DATEDIFF(day, GETDATE(), EnrollmentEnd) AS DaysTillSubscriptionExpired
                    FROM Subscriptions
                    INNER JOIN Trainers ON Subscriptions.[Player_id] = Trainers._id
                ) DateRemaining
                WHERE RemainingAmount > 0";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {

                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
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
                            if (reader.HasRows)
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

            string query = @"UPDATE Trainers
                 SET Name = @Name,
                     Phone = @Phone,
                     Photo = @Photo
                 WHERE _id = @TraineeID";
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
             DateTime EnrollmentEndDate, float totalAmount, float paidAmount)
        {

            bool success = false;
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {

                string query = @"WITH LatestSubscription AS (
                                    SELECT TOP (1) *
                                    FROM Subscriptions
                                    WHERE Player_id = @PlayerID
                                    ORDER BY EnrollmentStart DESC
                                )
                                UPDATE LatestSubscription
                                SET EnrollmentStart = @EnrollmentStartDate,
                                     EnrollmentEnd = @EnrollmentEndDate,
                                    TotalAmount = @TotalAmount,
                                    PaidAmount = @PaidAmount;";

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
                string query = @"SELECT TOP(1) Trainers._id, Trainers.Name, Trainers.Phone,Trainers.Photo,
                               Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd,
                               Subscriptions.TotalAmount, Subscriptions.PaidAmount,
                               (Subscriptions.TotalAmount - Subscriptions.PaidAmount) AS RemainingAmount,
                               DATEDIFF(day, GETDATE(), Subscriptions.EnrollmentEnd) AS DaysTillSubscriptionExpired
                                FROM Subscriptions
                                INNER JOIN Trainers ON Subscriptions.[Player_id] = Trainers._id
                                WHERE Trainers._id = @ID
                                ORDER BY EnrollmentStart DESC";


                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
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
                                 DATEDIFF(day, GETDATE(), Subscriptions.EnrollmentEnd) AS DaysTillSubscriptionExpired
                            FROM Subscriptions
                            INNER JOIN Trainers ON Subscriptions.[Player_id] = Trainers._id
                            WHERE Trainers._id = @PlayerID
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
                string query = @"INSERT INTO Subscriptions
                         (Player_id, EnrollmentStart, EnrollmentEnd, TotalAmount, PaidAmount )
                         VALUES
                         (@playerID, @startDate, @endDate, @totalAmount, @paidAmount)
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
        public static DataTable GetTraineeLastSubByPhone(string phone)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @"SELECT _id, Name, Phone,
                                   EnrollmentStart, EnrollmentEnd,
                                   TotalAmount, PaidAmount,
                                   (TotalAmount - PaidAmount) AS RemainingAmount,
                                    DaysTillSubscriptionExpired
                            FROM (
                                SELECT Trainers._id, Trainers.Name, Trainers.Phone,
                                       Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd,
                                       Subscriptions.TotalAmount, Subscriptions.PaidAmount,
                                    DATEDIFF(day, GETDATE(), EnrollmentEnd) AS DaysTillSubscriptionExpired,                              
                                       ROW_NUMBER() OVER (PARTITION BY Trainers._id ORDER BY Subscriptions.EnrollmentEnd DESC) AS RowNum
                                FROM Trainers
                                INNER JOIN Subscriptions ON Trainers._id = Subscriptions.Player_id
                            ) R2
                            WHERE RowNum = 1 and R2.Phone like '%' + @Phone + '%'"
;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Phone", phone);
                    try
                    {
                        connection.Open();

                        using (SqlDataReader result = command.ExecuteReader())
                        {
                            if (result.HasRows)
                            {
                                dt.Load(result);
                            }
                            result.Close();
                            connection.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        return dt;
                        // Handle the exception appropriately
                    }
                }
            }
            return dt;
        }
        public static DataTable GetTraineeAllSubByPhone(string phone)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @"select r1._id, r1.Name, r1.Phone,
                                 r1.EnrollmentStart, r1.EnrollmentEnd,
                                 r1.TotalAmount, r1.PaidAmount,
                                (r1.TotalAmount - r1.PaidAmount) AS RemainingAmount,
                                DATEDIFF(day, GETDATE(), EnrollmentEnd) AS DaysTillSubscriptionExpired
                                from (SELECT Trainers._id, Trainers.Name,
                                Trainers.Phone, Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd,
                                Subscriptions.TotalAmount, Subscriptions.PaidAmount
                                FROM   Subscriptions INNER JOIN
                                Trainers ON Subscriptions.Player_id = Trainers._id) r1
                                where r1.Phone like '%' + @Phone + '%'
                                order by r1.EnrollmentEnd desc";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Phone", phone);
                    try
                    {
                        connection.Open();

                        using (SqlDataReader result = command.ExecuteReader())
                        {
                            if (result.HasRows)
                            {
                                dt.Load(result);
                            }
                            result.Close();
                            connection.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        // Handle the exception appropriately
                    }
                }
            }
            return dt;
        }
        public static DataTable GetLastSubscriptionByPlayerIDWithoutPhoto(int ID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @"SELECT TOP(1) Trainers._id, Trainers.Name, Trainers.Phone,
                               Subscriptions.EnrollmentStart, Subscriptions.EnrollmentEnd,
                               Subscriptions.TotalAmount, Subscriptions.PaidAmount,
                               (Subscriptions.TotalAmount - Subscriptions.PaidAmount) AS RemainingAmount,
                               DATEDIFF(day, GETDATE(), Subscriptions.EnrollmentEnd) AS DaysTillSubscriptionExpired
                                FROM Subscriptions
                                INNER JOIN Trainers ON Subscriptions.[Player_id] = Trainers._id
                                WHERE Trainers._id = @ID
                                ORDER BY EnrollmentStart DESC";


                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
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

        public static DataTable GetPlayersWithOutSubs()
        {
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @" SELECT _id, Name, Phone
                                    FROM Trainers
                                    WHERE NOT EXISTS (
                                        SELECT 1
                                        FROM Subscriptions
                                        WHERE Trainers._id = Subscriptions.Player_id
                                    )
                                    ORDER BY Name;";


                using (SqlCommand cmd = new SqlCommand(query, connection))
                {

                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
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
        public static DataTable GetPlayersWithOutSubsByName(string Name)
        {
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @" SELECT _id, Name, Phone
                                    FROM Trainers
                                    WHERE NOT EXISTS (
                                        SELECT 1
                                        FROM Subscriptions
                                        WHERE Trainers._id = Subscriptions.Player_id 
                                    )AND Trainers.Name COLLATE Arabic_CI_AI LIKE N'%' + @Name + N'%'           
                                    ORDER BY Name;";


                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);

                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
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
        public static DataTable GetPlayersWithOutSubsByID(int ID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @" SELECT _id, Name, Phone
                                    FROM Trainers
                                    WHERE NOT EXISTS (
                                        SELECT 1
                                        FROM Subscriptions
                                        WHERE Trainers._id = Subscriptions.Player_id 
                                    )AND Trainers._id =   @ID         
                                    ORDER BY Name;";


                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);

                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
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

        public static bool DeletePlayerSub(int playerID)
        {
            bool Success  = false;
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @"DELETE FROM Subscriptions
                                WHERE Subscriptions._id IN (
                                    SELECT TOP(1) s._id
                                    FROM Subscriptions s
                                    INNER JOIN Trainers  ON s.Player_id = Trainers._id
                                    WHERE Trainers._id = @ID
                                    ORDER BY s.EnrollmentStart DESC
                                );";


                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", playerID);
                    try
                    {
                        connection.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                         {
                            Success = true;
                         }
                        
                    }
                    catch (Exception)
                    {
                        Success = false;
                        // Handle the exception appropriately
                    }

                    return Success;
                }
            }
        }

        public static bool IsTraineeNameExists(string palyerName)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString))
            {
                string query = @"select 1 from Trainers where Trainers.Name = @palyerName";


                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@palyerName", palyerName);
                    try
                    {
                        connection.Open();

                        object scalar = cmd.ExecuteScalar();

                        if (scalar != null)
                        {
                            int result = Convert.ToInt32(scalar);
                            IsFound = true;
                            // Perform the desired action with the result
                        }
                    }
                    catch (Exception)
                    {
                        IsFound = false;
                        // Handle the exception appropriately
                    }
                    return IsFound;
                }
            }
        }

    }
}
