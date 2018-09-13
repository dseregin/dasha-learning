using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashaLearning.BaseComponent.Help
{
    public static class ErrorProcessing
    {
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
