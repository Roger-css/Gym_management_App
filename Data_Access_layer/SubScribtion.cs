using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GymDataAccesLayer
{
    public class clsSubScribtionDataAccses
    {

        public static bool GetSubscribtionInfoByID(int ID, ref int playerID, ref DateTime startDate,
            ref DateTime endDate, ref int totalAmount, ref float paidAmount,
            ref float remainingAmount, ref int daysTillSubscribtionEnds)
        {
            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            bool isFound = false;
            // Here Become Your Trun Wolfy
            string query = "Select * From Subscribtions Where SubScribtionID = @ID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@SubScribtionID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    playerID = (int)reader["playerID"];
                    startDate = (DateTime)reader["startDate"];
                    endDate = (DateTime)reader["endDate"];
                    totalAmount = (int)reader["totalAmount"];
                    paidAmount = (float)reader["paidAmount"];
                    remainingAmount = (float)reader["remainingAmount"];
                    daysTillSubscribtionEnds = (int)reader["daysTillSubscribtionEnds"];
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

        public static bool GetLastSubscribtionByPlayerID(ref int ID,  int playerID, ref DateTime startDate,
           ref DateTime endDate, ref int totalAmount, ref float paidAmount,
           ref float remainingAmount, ref int daysTillSubscribtionEnds)
        {
            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            bool isFound = false;
            // Here Become Your Trun Wolfy
            string query = @"Select TOP 1 * From Subscribtions Where 
                                PlayerID = @PlayerID ORDER BY startDate DESC;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PlayerID", playerID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["ID"];
                    startDate = (DateTime)reader["startDate"];
                    endDate = (DateTime)reader["endDate"];
                    totalAmount = (int)reader["totalAmount"];
                    paidAmount = (float)reader["paidAmount"];
                    remainingAmount = (float)reader["remainingAmount"];
                    daysTillSubscribtionEnds = (int)reader["daysTillSubscribtionEnds"];
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

        public static DataTable GetAllSubscribtions()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            string query = "Select * From SubScribtions";
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

        public static DataTable GetSubscribtionBetweenDates(DateTime from, DateTime to)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataBaseSettings.ConnectionString);

            string query = @"Select * From Subscribtions
                                    Where startDate >= @from && endDate <= @to ";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@from", from);
            cmd.Parameters.AddWithValue("@to", to);


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
