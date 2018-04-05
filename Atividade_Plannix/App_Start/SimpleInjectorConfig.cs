using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using IoC;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;

namespace Atividade_Plannix.App_Start
{
    public class SimpleInjectorConfig
    {
        /// <summary>
        /// Executa todas as configurações da injeção de dependencia realizada na camada IoC
        /// </summary>
        public static void Config()
        {
            var container = Injector.RegisterContainers();

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}