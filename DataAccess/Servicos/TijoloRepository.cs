using DataAccess.Contrato;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Servicos
{
    public class TijoloRepository : ITijoloRepository
    {

        Tijolo[] arrayDeTijolos = new Tijolo[10];


        private int i = 0; // indice array

        public Array AddTijolosAndShow(Tijolo tijolo)
        {
            arrayDeTijolos[i] = new Tijolo(tijolo);
            i++;
            return arrayDeTijolos;
        }

        public Tijolo GetTijoloPorSerial(int serialDigitado)
        {
            Tijolo tijoloPorSerial = arrayDeTijolos.FirstOrDefault((t) => t.serial == serialDigitado);
            return tijoloPorSerial;
        }

        public Array OrdenarTijolosPorData()
        {
            Tijolo repos;
            //percorrer array
            for (int i = 0; i < arrayDeTijolos.Length - 1; i++)
            {
                for (int j = 0; j < arrayDeTijolos.Length - (i + 1); j++)
                {
                    //Confere ano
                    if (arrayDeTijolos[j].date.Year < arrayDeTijolos[j + 1].date.Year)
                    {
                        repos = arrayDeTijolos[j];
                        arrayDeTijolos[j] = arrayDeTijolos[j + 1];
                        arrayDeTijolos[j + 1] = repos;
                    }
                    //Confere mes
                    else if (arrayDeTijolos[j].date.Month < arrayDeTijolos[j + 1].date.Month)
                    {
                        repos = arrayDeTijolos[j];
                        arrayDeTijolos[j] = arrayDeTijolos[j + 1];
                        arrayDeTijolos[j + 1] = repos;
                    }
                    //Confere dia
                    else if (arrayDeTijolos[j].date.Day < arrayDeTijolos[j + 1].date.Day)
                    {
                        repos = arrayDeTijolos[j];
                        arrayDeTijolos[j] = arrayDeTijolos[j + 1];
                        arrayDeTijolos[j + 1] = repos;
                    }
                }
            }
            return arrayDeTijolos;
        }

        public Array OrdenarCresOuDecr(string condicao)
        {
            Tijolo repos;
            Tijolo[] arrayDeTijolosOrdenado = arrayDeTijolos;
            if (condicao.Equals("Cres"))
            {
                //percorrer array
                for (int i = 0; i < arrayDeTijolosOrdenado.Length - 1; i++)
                {
                    for (int j = 0; j < arrayDeTijolosOrdenado.Length - (i + 1); j++)
                    {
                        //Confere ano
                        if (arrayDeTijolosOrdenado[j].serial < arrayDeTijolosOrdenado[j + 1].serial)
                        {
                            repos = arrayDeTijolosOrdenado[j];
                            arrayDeTijolosOrdenado[j] = arrayDeTijolosOrdenado[j + 1];
                            arrayDeTijolosOrdenado[j + 1] = repos;
                        }
                    }
                }
                return arrayDeTijolosOrdenado;
            }
            else if (condicao.Equals("Decr"))
            {
                //percorrer array
                for (int i = 0; i < arrayDeTijolosOrdenado.Length - 1; i++)
                {
                    for (int j = 0; j < arrayDeTijolosOrdenado.Length - (i + 1); j++)
                    {
                        //Confere ano
                        if (arrayDeTijolosOrdenado[j].serial < arrayDeTijolosOrdenado[j + 1].serial)
                        {
                            repos = arrayDeTijolosOrdenado[j];
                            arrayDeTijolosOrdenado[j] = arrayDeTijolosOrdenado[j + 1];
                            arrayDeTijolosOrdenado[j + 1] = repos;
                        }
                    }
                }
                return arrayDeTijolosOrdenado;
            }
            return null;
        }
    }
}
