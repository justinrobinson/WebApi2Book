using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Ninject;

namespace Aent.Web.Common
{
    /// <summary>
    ///     An <see cref="IDependencyResolver" /> implemented using the Ninject DI container.
    /// </summary>
    public sealed class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _container;

        public NinjectDependencyResolver(IKernel container)
        {
            _container = container;
        }

        public IKernel Container
        {
            get { return _container; }
        }

        // delegate to the Ninject container to get object instances for the requested service types
        public object GetService(Type serviceType)
        {
            return _container.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.GetAll(serviceType);
        }

        public IDependencyScope BeginScope()
        {
            return this;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}