using System.Collections.Generic;
using Domain.InsuranceTest.InsuranceTest;

namespace Service.InsuranceTest.Service
{
    public interface ILogPolicyClientService
    {
        void AddLogPolizaCliente(LogPolizaCliente logPolizaCliente);
        List<LogPolizaCliente> GetLogPolizaClienteByNoDocumento(string noDocumento);
        void UpdateLogPolizaCliente(List<LogPolizaCliente> logPolizaClientes);
    }
}