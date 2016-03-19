using System;
using Saitama.Core.Framework;

namespace Saitama.Apple.Framework
{
    public sealed class SaitamaContext
    {
        private static IInjectionContainer _container;

        /// <summary>
        /// This method is responsible for returning our IInjectionContainer reference. Because of its importance the user cannot be allowed
        /// to mess with this. Thus a Get method is used inf favor of a getter property
        /// </summary>
        /// <returns>The IInjectionContainer instance that was created by the bootstrap class for the platform</returns>
        public static IInjectionContainer GetContainer()
        {
            if (_container == null)
                throw new InvalidOperationException("Your Injection container is not instantiated. Please implement the appropriate bootstrap class");

            return _container;
        }

        /// <summary>
        /// This method assigns the IInjectionContainer. It is only ever called from the bootstrap class of the corresponding platform. It is listed
        /// as internal to enable ONLY the Saitama framework to call it
        /// </summary>
        /// <param name="container"></param>
        internal static void SetInjectionContainer(IInjectionContainer container)
        {
            _container = container;
        }
    }
}
