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
    [RoutePrefix("api/LogPolicyClient")]
    public class LogPolicyClientController : ApiController
    {
        private readonly ILogPolicyClientRepository _repositorioLogPolizaCliente;


        public LogPolicyClientController(ILogPolicyClientRepository repositorioLogPolizaCliente)
        {
            _repositorioLogPolizaCliente = repositorioLogPolizaCliente;
        }
     
        [HttpPost]
        [Route("AddClient")]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult AddClient([FromBody]LogPolizaCliente logPolizaCliente)
        {
            try
            {
                _repositorioLogPolizaCliente.AddLogPolizaCliente(logPolizaCliente);

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
        public IHttpActionResult UpdateClient([FromBody]List<LogPolizaCliente> logPolizaCliente)
        {
            try
            {

                _repositorioLogPolizaCliente.UpdateLogPolizaCliente(logPolizaCliente);


                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.StackTrace);
            }
        }

        [HttpGet]
        [Route("LogPolicyClient/{noDocumento}")]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult GetClient(string noDocumento)
        {
            try
            {
                var response = _repositorioLogPolizaCliente.GetLogPolizaClienteByNoDocumento(noDocumento);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.StackTrace);
            }
        }
    }
}
