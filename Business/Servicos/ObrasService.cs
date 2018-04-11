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
    public class ObrasService : IObrasService
    {
        private readonly IObrasRepository repositorio;

        public ObrasService(IObrasRepository repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Inserir(Obra obra)
        {
            repositorio.Inserir(obra);
        }

        public List<Obra> ShowObra()
        { 
            return repositorio.ShowObra();
        }

        public void Update(Obra obra)
        {
           repositorio.Update(obra);
        }
        public void DeletePorCodigo(int codigoObra)
        {
            repositorio.DeletePorCodigo(codigoObra);
        }




    }
}
