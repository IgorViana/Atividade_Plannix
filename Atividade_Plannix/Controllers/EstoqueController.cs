using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Atividade_Plannix.Controllers
{
    public class EstoqueController : ApiController
    {
       public  Tijolo[] tijolos = new Tijolo[10];
       
        [HttpGet]
        public Tijolo GetTijoloPorSerial(int serialDigitado)
        {
            Tijolo tijoloPorSerial = tijolos.FirstOrDefault((t) => t.serial == this.serialDigitado);
            return tijoloPorSerial;
        }


        [HttpPost]
        public List<Tijolo> AddTijolo(Tijolo tijolo)
        {

            int index = tijolos.Length;
            tijolos[index] = tijolo;

            return tijolos;
        }

        public List<Tijolo> RetornarTijolos()
        {
            Tijolo temp;
            for (int i = 0; i < tijolos.Length; i++)
            {
                temp = tijolos[i];
                

            }
            foreach (Tijolo a in tijolos)
            {
                return a;
            }
        }
    }
}
