using Domain.InsuranceTest.InsuranceTest;
using Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InsuranceTest.Service
{
   public  class LogPolicyClientService : ILogPolicyClientService
    {
        private readonly ILogPolicyClientRepository _logPolicyClientRepository;

        public LogPolicyClientService(ILogPolicyClientRepository logPolicyClientRepository)
        {
            _logPolicyClientRepository = logPolicyClientRepository;
        }

        public List<LogPolizaCliente> GetLogPolizaClienteByNoDocumento(string noDocumento)
        {
            return _logPolicyClientRepository.GetLogPolizaClienteByNoDocumento(noDocumento);
        }
        public void AddLogPolizaCliente(LogPolizaCliente logPolizaCliente)
        {
            _logPolicyClientRepository.AddLogPolizaCliente(logPolizaCliente);
        }
        public void UpdateLogPolizaCliente(List<LogPolizaCliente> logPolizaClientes)
        {
            _logPolicyClientRepository.UpdateLogPolizaCliente(logPolizaClientes);
        }

        }
}
