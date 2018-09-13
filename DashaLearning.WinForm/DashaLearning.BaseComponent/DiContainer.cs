using NLog;
using StructureMap;
using StructureMap.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashaLearning.BaseComponent
{
    public static class DiContainer
    {
        public static IContainer GetContainer()
        {
            var container = new Container();

            container.Configure(config =>
            {
                config.Scan(_ =>
                {
                    _.WithDefaultConventions();

                    config.For<ILogger>().LifecycleIs<SingletonLifecycle>().Use(x => LogManager.GetCurrentClassLogger());
                });
            });

            return container;
        }
    }
}
