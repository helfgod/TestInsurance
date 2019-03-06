using System.Collections.Generic;
using Domain.InsuranceTest.InsuranceTest;

namespace Infrastructure.Data.Repositories
{
    public interface IRiskTypeRepository
    {
        void AddTipoRiesgo(TipoRiesgo TipoRiesgo);
        List<TipoRiesgo> GetAllTipoRiesgo();
    }
}