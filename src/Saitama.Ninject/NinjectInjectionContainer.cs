using System;
using Saitama.Core.Framework;
using Ninject;
using Ninject.Parameters;

namespace Saitama.Container.Ninject
{
    public class NinjectInjectionContainer : IInjectionContainer
    {
        private readonly IKernel _theKernel;

        public NinjectInjectionContainer(IKernel kernel)
        {
            _theKernel = kernel;
        }

        #region IInjectionContainer implementation

        public void InjectForInstance(object instance)
        {
            _theKernel.Inject(instance, new IParameter[0]);
        }

        public T Get<T>()
        {
            return (T)_theKernel.Get(typeof (T));
        }

        #endregion
    }
}

