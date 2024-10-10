using System.Configuration;

namespace GymDataAccesLayer
{
    internal static class ClsDataBaseSettings
    {
        private const string _myDb = "PersonalConnectionString";
        private const string _customerDb = "CustomerConnectionString";
        public static string ConnectionString
        {
            get
            {
                return GetConnectionStringFromConfigFile();
            }
        }
        private static string GetConnectionStringFromConfigFile()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[_myDb].ConnectionString;
            return connectionString;
        }
    }
}
