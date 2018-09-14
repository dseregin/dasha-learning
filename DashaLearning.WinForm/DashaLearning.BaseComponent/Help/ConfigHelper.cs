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

        #region Настройки email
        /// <summary>
        /// хост
        /// </summary>
        public static string EmailHost { get; set; }
        /// <summary>
        /// порт
        /// </summary>
        public static int EmailPort { get; set; }
        /// <summary>
        /// адрес
        /// </summary>
        public static string EmailUserName { get; set; }
        /// <summary>
        /// пароль
        /// </summary>
        public static string EmailPassword { get; set; }
        /// <summary>
        /// хз
        /// </summary>
        public static bool EmailSSLEnabled { get; set; }
        #endregion

        static ConfigHelper()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();

            ConnectionString = config["Data:ConnectionString"];

            #region Настройки email
            EmailHost = config["MailSettings:emailHost"];
            EmailPort = int.Parse(config["MailSettings:emailPort"]);
            EmailUserName = config["MailSettings:emailUserName"];
            EmailPassword = config["MailSettings:emailPassword"];
            EmailSSLEnabled = bool.Parse(config["MailSettings:emailSSLEnabled"]);
            #endregion
        }
    }
}
