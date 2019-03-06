using System.Collections.Generic;
using Domain.InsuranceTest.InsuranceTest;

namespace Infrastructure.Data.Repositories
{
    public interface ILogPolicyClientRepository
    {
        void AddLogPolizaCliente(LogPolizaCliente logPolizaCliente);
        List<LogPolizaCliente> GetLogPolizaClienteByNoDocumento(string noDocumento);
        void UpdateLogPolizaCliente(List<LogPolizaCliente> logPolizaClientes);
    }
}