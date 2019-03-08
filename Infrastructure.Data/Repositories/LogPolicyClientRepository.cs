using Domain.InsuranceTest.InsuranceTest;
using Infrastructure.Data.Implementations;
using Infrastructure.Data.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class LogPolicyClientRepository : ILogPolicyClientRepository
    {
        private readonly IRepository<LOG_POLIZA_CLIENTE> _repository;
        IUnitOfWork unitOfWork;

        public LogPolicyClientRepository(IRepository<LOG_POLIZA_CLIENTE> repository)
        {
            _repository = repository;
            this.unitOfWork = new UnitOfWork<InsuranceTestEntities>();
        }
        /// <summary>
        /// Consulta por noDocumento las polizas por nodocumento
        /// </summary>
        /// <param name="noDocumento"></param>
        /// <returns></returns>
        public List<LogPolizaCliente> GetLogPolizaClienteByNoDocumento(string noDocumento)
        {
            //var vIdCliente = _repository.Find<CLIENTE>(x => x.NO_DOCUMENTO == noDocumento);

            //var vLogPolizaCliente = JsonConvert.SerializeObject(_repository.Find<LOG_POLIZA_CLIENTE>(x => x.ID_CLI == vIdCliente.ID_CLI));

            //return JsonConvert.DeserializeObject<List<LogPolizaCliente>>(vLogPolizaCliente);
            return null;
        }
        /// <summary>
        /// agrega una polizaa un cliente
        /// </summary>
        /// <param name="logPolizaCliente"></param>
        public void AddLogPolizaCliente(LogPolizaCliente logPolizaCliente)
        {
            //var vLogPolizaCliente = JsonConvert.SerializeObject(logPolizaCliente);
            //var response = _repository.Create(JsonConvert.DeserializeObject<LOG_POLIZA_CLIENTE>(vLogPolizaCliente));
            //_repository.SaveChanges();
        }

        /// <summary>
        /// Actualiza un o varias polizas
        /// </summary>
        /// <param name="cliente"></param>
        public void UpdateLogPolizaCliente(List<LogPolizaCliente> logPolizaClientes)
        {
            //foreach (LogPolizaCliente item in logPolizaClientes)
            //{
            //    var vCliente = JsonConvert.SerializeObject(item);

            //    _repository.Update(JsonConvert.DeserializeObject<LOG_POLIZA_CLIENTE>(vCliente));
            //}
            //_repository.SaveChanges();

        }

    }
}
