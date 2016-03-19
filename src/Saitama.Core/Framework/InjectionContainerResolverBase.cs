using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace Saitama.Core.Framework
{
    public abstract class InjectionContainerResolverBase
    {
        private readonly Assembly _entryAssembly;

        /// <summary>
        /// Constructor for InjectionContainerResolve. Must be provided the EntryAssembly to scan for Injectable tyoes
        /// </summary>
        /// <param name="entryAssembly">Entry assembly.</param>
        protected InjectionContainerResolverBase(Assembly entryAssembly)
        {
            _entryAssembly = entryAssembly;
        }

        /// <summary>
        /// Register the injectable types with the container defined in the child implementation.
        /// </summary>
        /// <remarks>"Injectable Type" refers to a class where Injection begins</remarks>
        public void RegisterInjectableTypes()
        {
            if (_entryAssembly == null)
                throw new InvalidOperationException("Entry Assembly cannot be set as null");

            RegisterInjectableTypes(_entryAssembly);
        }

        #region Abstract Methods

        /// <summary>
        /// Hook to register the base injectable types (where injection begins)
        /// </summary>
        /// <param name="entryAssembly"></param>
        protected abstract void RegisterInjectableTypes(Assembly entryAssembly);

        /// <summary>
        /// Returns an instance implementing IInjectionContainer. This class will be used to fulfill injection using Saitama style base classes
        /// </summary>
        /// <returns></returns>
        public abstract IInjectionContainer GetInjectionContainer();

        /// <summary>
        /// Identifies the convention used to match Injectable base types when scanning the provided assembly. Default are identified in Apple and Android
        /// Platform Injection specific classes (Saitama.Core)
        /// </summary>
        /// <param name="typeInfo">Information about a type that is found in the provided assembly</param>
        /// <returns></returns>
        protected abstract bool MatchesConvention(TypeInfo typeInfo);

        #endregion

        /// <summary>
        /// Scans for injectable types.
        /// </summary>
        /// <returns>A list of types match the provided convention</returns>
        protected IList<Type> ScanForInjectableTypes()
        {
            return _entryAssembly.DefinedTypes
                .Where(x => MatchesConvention(x))
                .Select(x => x.AsType())
                .ToList();
        }
    }
}
