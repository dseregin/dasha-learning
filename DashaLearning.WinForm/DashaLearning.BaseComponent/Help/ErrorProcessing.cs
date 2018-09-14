using System;
using System.Text;

namespace DashaLearning.BaseComponent.Help
{
    /// <summary>
    /// Класс для получения детальной информаци об ошибке
    /// </summary>
    public static class ErrorProcessing
    {
        /// <summary>
        /// Получение детальной информации об ошибке
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="appendStackTrace">Отобразить стек вызовов</param>
        /// <returns></returns>
        public static string ExceptionMessageToString(Exception exception, bool appendStackTrace = true)
        {
            StringBuilder messageBuilder = new StringBuilder();
            GetExceptinMessageRecursive(messageBuilder, exception);
            if (appendStackTrace)
            {
                messageBuilder.AppendLine();
                messageBuilder.Append(exception.StackTrace);
            }
            return messageBuilder.ToString();
        }

        private static void GetExceptinMessageRecursive(StringBuilder messageBuilder, Exception exception)
        {
            if (exception.InnerException == null)
            {
                messageBuilder.Append(exception.Message);
            }
            else
            {
                messageBuilder.AppendLine(exception.Message);
                GetExceptinMessageRecursive(messageBuilder, exception.InnerException);
            }
        }
    }
}
