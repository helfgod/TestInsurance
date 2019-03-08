using Domain.InsuranceTest.InsuranceTest;
using Infrastructure.Data.Implementations;
using Infrastructure.Data.Interfaces;
using Infrastructure.Data;
using Service.InsuranceTest.Service;
using System;
using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;
using System.Linq;
using System.Net.Http;
using System.Net;

namespace TestInsurance.Controllers
{
    [RoutePrefix("api/Client")]
    public class ClientController : ApiController
    {

        IUnitOfWork unitOfWork;
        public ClientController()
        {

            this.unitOfWork = new UnitOfWork<InsuranceTestEntities>();
        }




        [HttpPost]
        [Route("AddClient")]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult AddClient([FromBody]Cliente cliente)
        {
            try
            {
                var client = unitOfWork.GetRepository<CLIENTE>();
                var vCliente = JsonConvert.SerializeObject(cliente);
                client.Insert(JsonConvert.DeserializeObject<CLIENTE>(vCliente));
                unitOfWork.Save();

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
                var client = unitOfWork.GetRepository<CLIENTE>();
                var vCliente = JsonConvert.SerializeObject(cliente);
                client.Update(JsonConvert.DeserializeObject<CLIENTE>(vCliente));
                unitOfWork.Save();
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
        public HttpResponseMessage GetClient(string noDocumento)
        {
            try
            {
                var client = unitOfWork.GetRepository<CLIENTE>();
                var response = client.Get(x => x.NO_DOCUMENTO.Equals(noDocumento)).FirstOrDefault();
                if (response != null)
                {
                    Cliente result = new Cliente();
                    result.Nombres = response.NOMBRES;
                    result.NoDocumento = response.NO_DOCUMENTO;
                    result.Telefono = response.TELEFONO;

                    //JsonConvert.DeserializeObject<CLIENTE>(response);
                    return Request.CreateResponse(HttpStatusCode.OK, result);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "No hay registros");
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.StackTrace);
            }
        }
    }
}
