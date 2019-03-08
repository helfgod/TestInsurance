using System.Collections.Generic;
using Domain.InsuranceTest.InsuranceTest;

namespace Service.InsuranceTest.Service
{
    public interface ICoverTypeService
    {
        void AddTipoCubrimiento(TipoCubrimiento tipoCubrimiento);
        List<TipoCubrimiento> GetAllTipoCubrimiento();
    }
}