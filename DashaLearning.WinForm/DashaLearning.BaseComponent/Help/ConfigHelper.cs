using Microsoft.Extensions.Configuration;

namespace DashaLearning.BaseComponent.Help
{
    /// <summary>
    /// Класс для получения значений из файла конфигурации
    /// </summary>
    public static class ConfigHelper
    {
        /// <summary>
        /// Строка подключения к БД
        /// </summary>
        public static string ConnectionString { get; set; }

        static ConfigHelper()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();

            ConnectionString = config["Data:ConnectionString"];
        }
    }
}
