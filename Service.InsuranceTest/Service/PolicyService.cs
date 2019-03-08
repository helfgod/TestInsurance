using Domain.InsuranceTest.InsuranceTest;
using Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InsuranceTest.Service
{
    public class PolicyService : IPolicyService
    {
        private IPolicyRepository _policyRepository;

        public PolicyService(IPolicyRepository policyRepository)
        {
            _policyRepository = policyRepository;
        }

        public Poliza GetPolizaByNombre(string nombre)
        {
            return _policyRepository.GetPolizaByNombre(nombre);
        }

        public void AddPoliza(Poliza poliza)
        {
            _policyRepository.AddPoliza(poliza);
        }
        public void UpdatePoliza(Poliza poliza)
        {
            _policyRepository.UpdatePoliza(poliza);
        }

        public void DeletePoliza(string nombre)
        {
            _policyRepository.DeletePoliza(nombre);
        }

    }
}
