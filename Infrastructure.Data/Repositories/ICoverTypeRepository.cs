using System.Collections.Generic;
using Domain.InsuranceTest.InsuranceTest;

namespace Infrastructure.Data.Repositories
{
    public interface ICoverTypeRepository
    {
        void AddTipoCubrimiento(TipoCubrimiento tipoCubrimiento);
        List<TipoCubrimiento> GetAllTipoCubrimiento();
    }
}