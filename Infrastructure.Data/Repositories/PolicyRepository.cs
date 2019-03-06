using Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class PolicyRepository
    {
        private readonly IRepository _repository;

        public PolicyRepository(IRepository repository)
        {
            _repository = repository;
        }

      
    }
}
