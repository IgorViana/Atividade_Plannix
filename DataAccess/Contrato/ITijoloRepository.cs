﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contrato
{
    public interface ITijoloRepository
    {
        
        Array AddTijolosAndShow(Tijolo tijolo);
        Array ShowAll();
        Tijolo GetTijoloPorSerial(int serialDigitado);
        Array OrdenarTijolosPorData();
        Array OrdenarCresOuDecr(string condicao);
    }
}
