using Domain.InsuranceTest.InsuranceTest;
using Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InsuranceTest.Service
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
      

        public Cliente GetClienteByNoDocumento(string noDocumento)
        {
            return _clientRepository.GetClienteByNoDocumento(noDocumento);
        }
        public void AddCliente(Cliente cliente)
        {
            _clientRepository.AddCliente(cliente);
        }

        public void UpdateCliente(Cliente cliente)
        {
            _clientRepository.UpdateCliente(cliente);
        }

        public void DeleteCliente(string noDocumento)
        {
            _clientRepository.DeleteCliente(noDocumento);
        }


        }
}
