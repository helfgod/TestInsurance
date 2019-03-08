using Domain.InsuranceTest.InsuranceTest;

namespace Service.InsuranceTest.Service
{
    public interface IPolicyService
    {
        void AddPoliza(Poliza poliza);
        void DeletePoliza(string nombre);
        Poliza GetPolizaByNombre(string nombre);
        void UpdatePoliza(Poliza poliza);
    }
}