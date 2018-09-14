using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DashaLearning.BaseComponent.Help
{
    /// <summary>
    /// Расширение для логирования входа/выхода в/из метод(а)
    /// </summary>
    public static class LogMethodHelper
    {
        public static ILogger Logger { get; set; }

        /// <summary>
        /// Логирование входа в метод
        /// </summary>
        /// <param name="source"></param>
        /// <param name="memberName"></param>
        public static void LogOnMethodEnter(this object source, [CallerMemberName]string memberName = "")
        {
            Logger?.Debug($"Вход в метод: {source.GetType().Name}.{memberName}");
        }

        /// <summary>
        /// Логирование выхода из метода
        /// </summary>
        /// <param name="source"></param>
        /// <param name="memberName"></param>
        public static void LogOnMethodExit(this object source, [CallerMemberName]string memberName = "")
        {
            Logger?.Debug($"Выход из метода: {source.GetType().Name}.{memberName}");
        }

        /// <summary>
        /// Логирование выхода из метода с результатом 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <param name="result">Возвращаемый результат</param>
        /// <param name="memberName"></param>
        /// <returns></returns>
        public static TResult LogOnReturn<TResult>(this object source, TResult result, [CallerMemberName]string memberName = "")
        {
            var jsonResult = result == null ? null : JsonConvert.SerializeObject(result);

            Logger?.Debug($"Выход из метода {source.GetType().Name}.{memberName} с результатом: {jsonResult}");
            return result;
        }
    }
}
