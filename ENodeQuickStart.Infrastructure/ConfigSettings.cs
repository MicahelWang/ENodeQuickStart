using System.Configuration;

namespace ENodeQuickStart.Infrastructure
{
    public class ConfigSettings
    {
        public static string ENodeQuickStartConnectionString { get; set; }
        public static string ENodeConnectionString { get; set; }

        public static void Initialize()
        {
            ENodeQuickStartConnectionString = ConfigurationManager.ConnectionStrings["ENodeQuickStart"].ConnectionString;
            ENodeConnectionString = ConfigurationManager.ConnectionStrings["ENode"].ConnectionString;
        }
    }
}