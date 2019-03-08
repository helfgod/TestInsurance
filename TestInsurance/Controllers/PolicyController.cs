using Domain.InsuranceTest.InsuranceTest;
using Service.InsuranceTest.Service;
using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace TestInsurance.Controllers
{
    [RoutePrefix("api/Policy")]
    public class PolicyController : ApiController
    {
        private readonly IPolicyService _servicioPoliza;

        public PolicyController(IPolicyService servicioPoliza)
        {
            _servicioPoliza = servicioPoliza;
        }

        [HttpPost]
        [Route("AddPolicy")]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult AddPolicy([FromBody]Poliza poliza)
        {
            try
            {
                _servicioPoliza.AddPoliza(poliza);

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

                _servicioPoliza.UpdatePoliza(poliza);


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
                var response = _servicioPoliza.GetPolizaByNombre(nombre);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.StackTrace);
            }
        }
    }
}
