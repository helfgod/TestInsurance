﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TSet> GetRepository<TSet>() where TSet : class;
        DbTransaction BeginTransaction();
        int Save();
    }
}
