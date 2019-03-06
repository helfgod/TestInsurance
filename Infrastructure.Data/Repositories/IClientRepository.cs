using Domain.InsuranceTest.InsuranceTest;

namespace Infrastructure.Data.Repositories
{
    public interface IClientRepository
    {
        void AddCliente(Cliente cliente);
        void DeleteCliente(string noDocumento);
        Cliente GetClienteByNoDocumento(string noDocumento);
        void UpdateCliente(Cliente cliente);
    }
}