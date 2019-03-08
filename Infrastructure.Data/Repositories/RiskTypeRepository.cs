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
   public class RiskTypeRepository : IRiskTypeRepository
    {
        private readonly IRepository<TIPO_RIESGO> _repository;
        public RiskTypeRepository(IRepository<TIPO_RIESGO> repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// obtiene todos los Riesgos
        /// </summary>
        /// <returns></returns>
        public List<TipoRiesgo> GetAllTipoRiesgo()
        {
            //var vTipoRiesgo = JsonConvert.SerializeObject(_repository.All<TIPO_CUBRIMIENTO>());
            //return JsonConvert.DeserializeObject<List<TipoRiesgo>>(vTipoRiesgo);
            return null;
        }
        /// <summary>
        /// Agrega un TipoRiesgo
        /// </summary>
        /// <param name="cliente"></param>
        public void AddTipoRiesgo(TipoRiesgo tipoRiesgo)
        {
        //    var vTipoRiesgo = JsonConvert.SerializeObject(tipoRiesgo);
        //    var response = _repository.Create(JsonConvert.DeserializeObject<TIPO_CUBRIMIENTO>(vTipoRiesgo));
        //    _repository.SaveChanges();
        }

    }
}
