
using Domain.InsuranceTest.InsuranceTest;
using Infrastructure.Data.Interfaces;
using Newtonsoft.Json;

namespace Infrastructure.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly IRepository _repository;

        public ClientRepository(IRepository repository)
        {

            _repository = repository;
        }
        /// <summary>
        /// obitene un cliente por Numero de documento
        /// </summary>
        /// <param name="noDocumento"></param>
        /// <returns></returns>
        public Cliente GetClienteByNoDocumento(string noDocumento)
        {
            string vCliente = JsonConvert.SerializeObject(_repository.Find<CLIENTE>(x => x.NO_DOCUMENTO == noDocumento));

            return JsonConvert.DeserializeObject<Cliente>(vCliente);
        }
        /// <summary>
        /// Agrega un cliente
        /// </summary>
        /// <param name="cliente"></param>
        public void AddCliente(Cliente cliente)
        {
            var vCliente = JsonConvert.SerializeObject(cliente);
            var response = _repository.Create(JsonConvert.DeserializeObject<CLIENTE>(vCliente));
            _repository.SaveChanges();
        }
        /// <summary>
        /// Actualiza un cliente
        /// </summary>
        /// <param name="cliente"></param>
        public void UpdateCliente(Cliente cliente)
        {
            var vCliente = JsonConvert.SerializeObject(cliente);

            _repository.Update(JsonConvert.DeserializeObject<CLIENTE>(vCliente));
            _repository.SaveChanges();
        }
        /// <summary>
        /// elimina un cliente 
        /// </summary>
        /// <param name="noDocumento"></param>
        public void DeleteCliente(string noDocumento)
        {
            _repository.Delete<Cliente>(x => x.NoDocumento == noDocumento);
            _repository.SaveChanges();
        }

    }
}
