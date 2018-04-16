using System.Configuration;

namespace MagZamotane4.DataAccess
{
    public class Helper
    {
        public static string ConnectionString(string name)
        { 
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
