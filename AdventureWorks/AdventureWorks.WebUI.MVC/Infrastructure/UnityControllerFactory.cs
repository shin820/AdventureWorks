using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdventureWorks.DataAccess;
using AdventureWorks.DataAccess.Repositories;
using AdventureWorks.DataAccess.Repositories.Interfaces;
using AdventureWorks.DataAccess.UnitOfWork;
using AdventureWorks.Service;
using AdventureWorks.WebUI.MVC.Controllers;
using Microsoft.Practices.Unity;

namespace AdventureWorks.WebUI.MVC.Infrastructure
{
    public class UnityControllerFactory : DefaultControllerFactory
    {
        private readonly IUnityContainer _container;

        public UnityControllerFactory()
        {
            _container = new UnityContainer();
            AddDependencies();
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext,
                                                             Type controllerType)
        {
            return controllerType == null ? null : (IController) _container.Resolve(controllerType);
        }

        private void AddDependencies()
        {
            _container.RegisterType<IDbContext, AdventureWorksContext>(new ContainerControlledLifetimeManager(),
                                                                       new InjectionConstructor("AdventureWorks"))
                      .RegisterType<IUnitOfWork, EFUnitOfWork>(new InjectionConstructor(_container.Resolve<IDbContext>()))
                      .RegisterTypes(
                          AllClasses.FromLoadedAssemblies()
                                    .Where(t => t.Namespace == "AdventureWorks.DataAccess.Repositories.Interfaces"),
                          WithMappings.FromMatchingInterface,
                          WithName.TypeName);


            _container.RegisterType<IEmployeeService, EmployeeService>(
                new InjectionConstructor(_container.Resolve<EmployeeRepository>())
                );

            _container.RegisterType<EmployeeController>(
                new InjectionConstructor(_container.Resolve<IEmployeeService>())
                );
        }
    }
}