﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contrato
{
    public interface ITijoloService
    {
        Array AddTijolosAndShow(Tijolo tijolo);
        Array ShowAll();
        Tijolo GetPorSerial(int serialDigitado);
        Array OrdenarTijolosPorData();
        Array OrdenarCresOuDecr(string condicao);
    }
}
