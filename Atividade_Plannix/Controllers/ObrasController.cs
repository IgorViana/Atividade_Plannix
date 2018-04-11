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
    [RoutePrefix("api/controladorObras")]
    public class ObrasController : ApiController
    {
        private readonly IObrasService service;

        public ObrasController (IObrasService service)
        {
            this.service = service;
        }

        [HttpPost, Route("add")]
        public IHttpActionResult Inserir(Obra obra)
        {
            try
            {
                service.Inserir(obra);
            }
            catch
            {
                throw;
            }
            return null;
        }

        [HttpGet, Route("getall")]
        public IHttpActionResult ShowObra()
        { 
            return Ok(service.ShowObra());
        }

        [HttpPut, Route("att")]
        public IHttpActionResult Atualizar(Obra obra)
        {
            try
            {
                service.Update(obra);
            }
            catch
            {
                throw;
            }
            return null;
        }

        [HttpDelete, Route("del")]
        public IHttpActionResult DeletarPorCodigo(int codigoObra)
        {
            try
            {
                service.DeletePorCodigo(codigoObra);
            }
            catch
            {
                throw;
            }
            return null;
        }

    }
}
