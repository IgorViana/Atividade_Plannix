using Business.Contrato;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

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
        [HttpPost, Route("add")]

        public IHttpActionResult Add (Tijolo tijolo)
        {
         
            return Ok(service.AddTijolosAndShow(tijolo)); 
        }
       
        [HttpGet, Route("getserial")]
        public IHttpActionResult GetPorSerial (int serialDigitado)
        {
           //  service.GetPorSerial(serialDigitado);
            
            return Ok(service.GetPorSerial(serialDigitado));

        }

        [HttpGet, Route("getOrdenado")]
        public IHttpActionResult OrdenarPorData()
        {
            //service.OrdenarTijolosPorData();
           
            return Ok(service.OrdenarTijolosPorData());
        }

        [HttpGet, Route("getOrdenadadoCres")]
        public IHttpActionResult OrdenarCresOuDecr(string condicao)
        {
            //service.OrdenarTijolosPorData();

            return Ok(service.OrdenarCresOuDecr(condicao));
        }
    }
}
