using Business.Contrato;
using Business.Servicos;
using DataAccess.Contrato;
using DataAccess.Servicos;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class Injector
    {
        /// <summary>
        /// Realiza configuraçães para injeção de dependência.
        /// </summary>
        /// <returns>Retorna o container DI.</returns>
        public static Container RegisterContainers()
        {

            var container = new Container();
            
            // EXEMPLO DE ADIÇÃO DE DEPENDÊNCIA
            // container.RegisterSingleton<INTERFACE_AQUI, CLASSE_REFERENTE_A_INTERFACE>();
            container.RegisterSingleton<ITijoloService, TijoloService>();
            container.RegisterSingleton<ITijoloRepository, TijoloRepository>();


            container.RegisterSingleton<IObrasRepository, ObrasRepositoy>();
            container.RegisterSingleton<IObrasService, ObrasService>();

            return container;
        }
    }
}
