using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdventureWorks.DataAccess;
using AdventureWorks.DataAccess.Repositories;
using AdventureWorks.DataAccess.Repositories.Interfaces;
using AdventureWorks.DataAccess.UnitOfWork;
using AdventureWorks.Service;
using Microsoft.Practices.Unity;

namespace AdventureWorks.WebUI.MVC.Context
{
    public sealed class ApplicationContext
    {
        private static readonly object _sync = new object();
        private static volatile ApplicationContext _currentInstance;

        private readonly IUnityContainer _container;

        private ApplicationContext()
        {
            _container = new UnityContainer();
            AdventureWorksContext context = new AdventureWorksContext("AdventureWorks");
            _container.RegisterInstance(context);

            _container.RegisterType<IUnitOfWork, EFUnitOfWork>(
                new InjectionFactory((c, t, s) => new EFUnitOfWork(
                                                      _container.Resolve<AdventureWorksContext>()
                                                      )));

            _container.RegisterType<IEmployeeRepository, EmployeeRepository>(
                new InjectionFactory((c, t, s) => new EmployeeRepository(
                                                      _container.Resolve<AdventureWorksContext>(),
                                                      _container.Resolve<IUnitOfWork>()
                                                      )));

            _container.RegisterType<IEmployeeService, EmployeeService>(
                new InjectionFactory((c, t, s) => new EmployeeService(
                                                      _container.Resolve<IEmployeeRepository>()
                                                      )));
        }

        public static ApplicationContext Current
        {
            get
            {
                if (_currentInstance == null)
                {
                    lock (_sync)
                    {
                        if (_currentInstance == null)
                            _currentInstance = new ApplicationContext();
                    }
                }
                return _currentInstance;
            }
        }

        public IUnityContainer Container
        {
            get { return _container; }
        }
    }
}