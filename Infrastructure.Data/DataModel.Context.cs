﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infrastructure.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class InsuranceTestEntities : DbContext
    {
        public InsuranceTestEntities()
            : base("name=InsuranceTestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CLIENTE> CLIENTEs { get; set; }
        public DbSet<LOG_POLIZA_CLIENTE> LOG_POLIZA_CLIENTE { get; set; }
        public DbSet<POLIZA> POLIZAs { get; set; }
        public DbSet<TIPO_CUBRIMIENTO> TIPO_CUBRIMIENTO { get; set; }
        public DbSet<TIPO_RIESGO> TIPO_RIESGO { get; set; }
    }
}
