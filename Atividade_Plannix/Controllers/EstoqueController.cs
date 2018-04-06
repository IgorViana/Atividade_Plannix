using Business.Contrato;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Atividade_Plannix.Controllers
{
    [RoutePrefix("api/controlador")]
    public class EstoqueController : ApiController
    {

        private readonly ITijoloService service;

        public EstoqueController(ITijoloService service)
        {
            this.service = service;
        }
        [HttpPost]
        public IHttpActionResult Add (Tijolo tijolo)
        {
            service.AddTijolosAndShow(tijolo);
            return null;
        }
       
        [HttpGet]
        public IHttpActionResult GetPorSerial (int serialDigitado)
        {
             service.GetPorSerial(serialDigitado);
            return null;
            
        }

        [HttpGet]
        public IHttpActionResult OrdenarPorData()
        {
            service.OrdenarTijolosPorData();
            return null;
        }



        
    }
}
