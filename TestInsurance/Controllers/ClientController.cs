using Domain.InsuranceTest.InsuranceTest;
using Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace TestInsurance.Controllers
{
    [RoutePrefix("api/Client")]
    public class ClientController : ApiController
    {
        private readonly IClientRepository _repositorioCliente;

        public ClientController(IClientRepository repositorioCliente)
        {
            _repositorioCliente = repositorioCliente;
        }


        [HttpPost]
        [Route("AddClient")]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult AddClient([FromBody]Cliente cliente)
        {
            try
            {
                _repositorioCliente.AddCliente(cliente);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.StackTrace);
            }
        }

        [HttpPost]
        [Route("UpdateClient")]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult UpdateClient([FromBody]Cliente cliente)
        {
            try
            {

                _repositorioCliente.UpdateCliente(cliente);


                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.StackTrace);
            }
        }

        [HttpGet]
        [Route("Client/{noDocumento}")]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult GetClient(string noDocumento)
        {
            try
            {
                var response = _repositorioCliente.GetClienteByNoDocumento(noDocumento);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.StackTrace);
            }
        }
    }
}
