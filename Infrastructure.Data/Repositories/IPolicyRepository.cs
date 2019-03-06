using Domain.InsuranceTest.InsuranceTest;

namespace Infrastructure.Data.Repositories
{
    public interface IPolicyRepository
    {
        void AddPoliza(Poliza Poliza);
        void DeletePoliza(string nombre);
        Poliza GetPolizaByNombre(string nombre);
        void UpdatePoliza(Poliza Poliza);
    }
}