using Business.Contrato;
using DataAccess.Contrato;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Servicos
{
    public class TijoloService : ITijoloService
    {
        private readonly ITijoloRepository repositorio;

        public TijoloService (ITijoloRepository repositorio)
        {
            this.repositorio = repositorio;
        }
        public Array AddTijolosAndShow(Tijolo tijolo)
        {
            return repositorio.AddTijolosAndShow(tijolo);

        }

        public Tijolo GetPorSerial (int serialDigitado)
        {
            return repositorio.GetTijoloPorSerial(serialDigitado);
        }


        public Array OrdenarTijolosPorData()
        {
            return repositorio.OrdenarTijolosPorData();
        }
    }
}
