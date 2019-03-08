using Domain.InsuranceTest.InsuranceTest;

namespace Service.InsuranceTest.Service
{
    public interface IClientService
    {
        void AddCliente(Cliente cliente);
        void DeleteCliente(string noDocumento);
        Cliente GetClienteByNoDocumento(string noDocumento);
        void UpdateCliente(Cliente cliente);
    }
}