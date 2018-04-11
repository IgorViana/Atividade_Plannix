using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contrato
{
    public interface IObrasService
    {
        void Inserir(Obra obra);
        List<Obra> ShowObra();
        void Update(Obra obra);
        void DeletePorCodigo(int codigoObra);
    }
}
