using Domain.InsuranceTest.InsuranceTest;
using Infrastructure.Data.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class PolicyRepository : IPolicyRepository
    {
        private readonly IRepository<POLIZA> _repository;

        public PolicyRepository(IRepository<POLIZA> repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// obitene un Poliza por Numero de documento
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public Poliza GetPolizaByNombre(string nombre)
        {
            //string vPoliza = JsonConvert.SerializeObject(_repository.Find<POLIZA>(x => x.NOMBRE == nombre));

            //return JsonConvert.DeserializeObject<Poliza>(vPoliza);
            return null;
        }
        /// <summary>
        /// Agrega un Poliza
        /// </summary>
        /// <param name="Poliza"></param>
        public void AddPoliza(Poliza poliza)
        {
            //var vPoliza = JsonConvert.SerializeObject(poliza);
            //var response = _repository.Create(JsonConvert.DeserializeObject<POLIZA>(vPoliza));
            //_repository.SaveChanges();
        }
        /// <summary>
        /// Actualiza un Poliza
        /// </summary>
        /// <param name="Poliza"></param>
        public void UpdatePoliza(Poliza poliza)
        {
            //var vPoliza = JsonConvert.SerializeObject(poliza);

            //_repository.Update(JsonConvert.DeserializeObject<POLIZA>(vPoliza));
            //_repository.SaveChanges();
        }
        /// <summary>
        /// elimina un Poliza 
        /// </summary>
        /// <param name="noDocumento"></param>
        public void DeletePoliza(string nombre)
        {
            //_repository.Delete<POLIZA>(x => x.NOMBRE == nombre);
            //_repository.SaveChanges();
        }
    }
}
