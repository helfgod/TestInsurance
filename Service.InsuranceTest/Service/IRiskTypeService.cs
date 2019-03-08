using System.Collections.Generic;
using Domain.InsuranceTest.InsuranceTest;

namespace Service.InsuranceTest.Service
{
    public interface IRiskTypeService
    {
        void AddTipoRiesgo(TipoRiesgo tipoRiesgo);
        List<TipoRiesgo> GetAllTipoRiesgo();
    }
}