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
   public class RiskTypeRepository
    {
        private readonly IRepository _repository;
        public RiskTypeRepository(IRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// obtiene todos los Riesgos
        /// </summary>
        /// <returns></returns>
        public List<TipoRiesgo> GetAllTipoRiesgo()
        {
            var vTipoRiesgo = JsonConvert.SerializeObject(_repository.All<TIPO_CUBRIMIENTO>());
            return JsonConvert.DeserializeObject<List<TipoRiesgo>>(vTipoRiesgo);
        }
        /// <summary>
        /// Agrega un TipoRiesgo
        /// </summary>
        /// <param name="cliente"></param>
        public void AddTipoRiesgo(TipoRiesgo TipoRiesgo)
        {
            var vTipoRiesgo = JsonConvert.SerializeObject(TipoRiesgo);
            var response = _repository.Create(JsonConvert.DeserializeObject<TIPO_CUBRIMIENTO>(vTipoRiesgo));
            _repository.SaveChanges();
        }

    }
}
