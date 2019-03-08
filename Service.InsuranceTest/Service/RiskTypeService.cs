using Domain.InsuranceTest.InsuranceTest;
using Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InsuranceTest.Service
{
    public class RiskTypeService : IRiskTypeService
    {
        IRiskTypeRepository _riskTypeRepository;

        public RiskTypeService(IRiskTypeRepository riskTypeRepository)
        {
            _riskTypeRepository = riskTypeRepository;
        }
        public List<TipoRiesgo> GetAllTipoRiesgo()
        {
           return _riskTypeRepository.GetAllTipoRiesgo();
        }
        public void AddTipoRiesgo(TipoRiesgo tipoRiesgo)
        {
            _riskTypeRepository.AddTipoRiesgo(tipoRiesgo);
        }
    }
}
