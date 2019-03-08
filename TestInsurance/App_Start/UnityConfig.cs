
using Infrastructure.Data;
using Infrastructure.Data.Implementations;
using Infrastructure.Data.Interfaces;
using Infrastructure.Data.Repositories;
using Service.InsuranceTest.Service;
using System.Data.Entity;
using System.Web.Http;
using Unity;
using Unity.Lifetime;
using Unity.WebApi;
using Microsoft.Practices.Unity;

using System.Web.Mvc;

namespace TestInsurance
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IClientService, ClientService>();
            //container.RegisterType<ILogPolicyClientService, LogPolicyClientService>();
            // container.RegisterType<ILogPolicyClientRepository, LogPolicyClientRepository>();
            //container.RegisterType<IPolicyService, PolicyService>();
            //container.RegisterType<IRiskTypeService, RiskTypeService>();
            //container.RegisterType<ICoverTypeService, CoverTypeService>();
            //  container.RegisterType<IUnitOfWork, UnitOfWork(DbContext)();
            //    container.RegisterType<IUnitOfWork, IUnitOfWork >new PerResolveLifetimeManager();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));

           // GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}