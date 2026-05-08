using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDesingPatterns.Creational.Singleton_Demo3
{
    public sealed class ConfigurationManager
    {
        // The single instance is lazily initialized.
        private static readonly Lazy<ConfigurationManager> _lazyInstance =
            new Lazy<ConfigurationManager>(() => new ConfigurationManager());

        // Private constructor prevents external instantiation.
        private ConfigurationManager()
        {
            // Load configuration settings here, perhaps from a file.
            Console.WriteLine("ConfigurationManager initialized.");
        }

        // Public static property for global access.
        public static ConfigurationManager Instance
        {
            get
            {
                return _lazyInstance.Value;
            }
        }

        public string GetSetting(string key)
        {
            // Simple logic to retrieve a setting
            return $"Value for {key} loaded from Singleton.";
        }
    }

    // Usage:
    public class Client
    {
        public static void Main()
        {
            // Access the single instance globally
            ConfigurationManager config = ConfigurationManager.Instance;
            Console.WriteLine(config.GetSetting("DatabaseConnection"));
        }
    }
}
