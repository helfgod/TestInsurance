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
    public class CoverTypeRepository : ICoverTypeRepository
    {
        private readonly IRepository<TIPO_CUBRIMIENTO> _repository;
        public CoverTypeRepository(IRepository<TIPO_CUBRIMIENTO> repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// obtiene todos los cubrimientos
        /// </summary>
        /// <returns></returns>
        public List<TipoCubrimiento> GetAllTipoCubrimiento()
        {
            //var vTipoCubrimiento = JsonConvert.SerializeObject(_repository.All<TIPO_CUBRIMIENTO>());
            //return JsonConvert.DeserializeObject<List<TipoCubrimiento>>(vTipoCubrimiento);
            return null;
        }
        /// <summary>
        /// Agrega un TipoCubrimiento
        /// </summary>
        /// <param name="cliente"></param>
        public void AddTipoCubrimiento(TipoCubrimiento tipoCubrimiento)
        {
            //var vTipoCubrimiento = JsonConvert.SerializeObject(tipoCubrimiento);
            //var response = _repository.Create(JsonConvert.DeserializeObject<TIPO_CUBRIMIENTO>(vTipoCubrimiento));
            //_repository.SaveChanges(); 
        }

    }
}
