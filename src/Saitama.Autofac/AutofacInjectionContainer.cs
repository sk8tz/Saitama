using Autofac;
using Saitama.Core.Framework;

namespace Saitama.Container.Autofac
{
    public class AutofacInjectionContainer : IInjectionContainer
    {
        private readonly IContainer _container;

        public AutofacInjectionContainer(ContainerBuilder builder)
        {
            _container = builder.Build();
        }

        public void InjectForInstance(object instance)
        {
            _container.InjectProperties(instance);
        }

        public T Get<T>()
        {
            return (T)_container.Resolve(typeof (T));
        }
    }
}
