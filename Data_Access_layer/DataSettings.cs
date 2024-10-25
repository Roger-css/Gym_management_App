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
                return ConfigurationManager.ConnectionStrings[_customerDb].ConnectionString;
            }
        }
    }
}
