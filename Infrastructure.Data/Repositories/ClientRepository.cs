
using Domain.InsuranceTest.InsuranceTest;
using Infrastructure.Data.Implementations;
using Infrastructure.Data.Interfaces;
using Newtonsoft.Json;

namespace Infrastructure.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly IRepository<CLIENTE> _repository;
        IUnitOfWork unitOfWork;

        public ClientRepository(IRepository<CLIENTE> repository):base()
        {

            _repository = repository;
            this.unitOfWork = new UnitOfWork<InsuranceTestEntities>();
        }

        public ClientRepository()
        {
            this.unitOfWork = new UnitOfWork<InsuranceTestEntities>();
  
        }



        /// <summary>
        /// obitene un cliente por Numero de documento
        /// </summary>
        /// <param name="noDocumento"></param>
        /// <returns></returns>
        public Cliente GetClienteByNoDocumento(string noDocumento)
        {
            IRepository<CLIENTE> client = unitOfWork.GetRepository<CLIENTE>();

           // string vCliente = JsonConvert.SerializeObject(client.Find<CLIENTE>(x => x.NO_DOCUMENTO == noDocumento));

            return null;// JsonConvert.DeserializeObject<Cliente>(vCliente);
        }
        /// <summary>
        /// Agrega un cliente
        /// </summary>
        /// <param name="cliente"></param>
        public void AddCliente(Cliente cliente)
        {
            IRepository<CLIENTE> client = unitOfWork.GetRepository<CLIENTE>();
            var vCliente = JsonConvert.SerializeObject(cliente);
            //var response = client.Create(JsonConvert.DeserializeObject<CLIENTE>(vCliente));
            //client.SaveChanges();
        }
        /// <summary>
        /// Actualiza un cliente
        /// </summary>
        /// <param name="cliente"></param>
        public void UpdateCliente(Cliente cliente)
        {
            IRepository<CLIENTE> client = unitOfWork.GetRepository<CLIENTE>();

            var vCliente = JsonConvert.SerializeObject(cliente);

            //client.Update(JsonConvert.DeserializeObject<CLIENTE>(vCliente));
            //client.SaveChanges();
        }
        /// <summary>
        /// elimina un cliente 
        /// </summary>
        /// <param name="noDocumento"></param>
        public void DeleteCliente(string noDocumento)
        {
            IRepository<CLIENTE> client = unitOfWork.GetRepository<CLIENTE>();

            //client.Delete<Cliente>(x => x.NoDocumento == noDocumento);
            //client.SaveChanges();
        }

    }
}
