
namespace Saitama.Core.Framework
{
    public interface IInjectionContainer
    {
        /// <summary>
        /// Resolves all matching dependencies present on <param name="instance">instance</param>.
        /// </summary>
        /// <param name="instance">The instance whose properties we wish to hydrate</param>
        void InjectForInstance(object instance);

        /// <summary>
        /// Return a type registered in the container
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T Get<T>();
    }
}
