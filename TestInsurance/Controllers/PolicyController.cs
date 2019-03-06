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
    [RoutePrefix("api/Policy")]
    public class PolicyController : ApiController
    {
        private readonly IPolicyRepository _repositorioPoliza;

        public PolicyController(IPolicyRepository repositorioPoliza)
        {
            _repositorioPoliza = repositorioPoliza;
        }

        [HttpPost]
        [Route("AddPolicy")]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult AddPolicy([FromBody]Poliza poliza)
        {
            try
            {
                _repositorioPoliza.AddPoliza(poliza);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.StackTrace);
            }
        }

        [HttpPost]
        [Route("UpdatePolicy")]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult UpdatePolicy([FromBody]Poliza poliza)
        {
            try
            {

                _repositorioPoliza.UpdatePoliza(poliza);


                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.StackTrace);
            }
        }

        [HttpGet]
        [Route("Policy/{noDocumento}")]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult GetPolicy(string nombre)
        {
            try
            {
                var response = _repositorioPoliza.GetPolizaByNombre(nombre);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.StackTrace);
            }
        }
    }
}
