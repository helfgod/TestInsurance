//using Infrastructure.Data.Implementations.EntityFramework;
using Infrastructure.Data.Implementations.EntityFramework;
using Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.InsuranceTest.InsuranceTest;
using Newtonsoft.Json;

namespace Infrastructure.Data.Repositories
{
    public class ClientRepository
    {
        private readonly IRepository _repository;

        public ClientRepository(IRepository repository)
        {

            _repository = repository;
        }

        public Cliente GetClienteByNoDocumento(string noDocumento)
        {
            var vCliente = JsonConvert.SerializeObject(_repository.Find<CLIENTE>(x => x.NO_DOCUMENTO == noDocumento));

            return JsonConvert.DeserializeObject<Cliente>(vCliente);
        }

    }
}
