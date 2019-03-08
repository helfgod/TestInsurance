using Domain.InsuranceTest.InsuranceTest;
using Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InsuranceTest.Service
{
    public class CoverTypeService : ICoverTypeService
    {
        ICoverTypeRepository _coverTypeRepository;

        public CoverTypeService(ICoverTypeRepository coverTypeRepository)
        {
            _coverTypeRepository = coverTypeRepository;
        }
        public List<TipoCubrimiento> GetAllTipoCubrimiento()
        {
            return _coverTypeRepository.GetAllTipoCubrimiento();
        }
        public void AddTipoCubrimiento(TipoCubrimiento tipoCubrimiento)
        {
            _coverTypeRepository.AddTipoCubrimiento(tipoCubrimiento);
        }
    }

}
