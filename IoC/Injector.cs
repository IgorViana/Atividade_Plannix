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

            // EXEMPLO DE ADIÇÃO DE INDEPENDÊNCIA
            // container.RegisterSingleton<INTERFACE_AQUI, CLASSE_REFERENTE_A_INTERFACE>();

            var container = new Container();



            return container;
        }
    }
}
