using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Saitama.Core.Framework;

namespace Saitama.Core.Platform
{
    public abstract class ApplePlatformInjectionContainerResolver : InjectionContainerResolverBase
    {
        protected ApplePlatformInjectionContainerResolver(Assembly entryAssembly) : base(entryAssembly)
        {
        }

        /// <summary>
        /// Indicates the convention by which to match found types and determine if they are injectable base tyes. By default this looks for classes which have a base
        /// class starting with 'Saitama' and ending with either 'Controller' or 'Delegate'
        /// </summary>
        /// <returns><c>true</c>, if OS convention was matched, <c>false</c> otherwise.</returns>
        /// <param name="typeInfo">The concrete typeinfo class for a found type</param>
        /// <remarks>>
        /// If you decide to use a different convention you may override this method. Will get called from with the ScanForInjectableTypes call
        /// </remarks>
        protected override bool MatchesConvention(TypeInfo typeInfo)
        {
            var baseType = typeInfo.BaseType;
            while (baseType != null && !baseType.Name.EndsWith("NSObject"))
            {
                if (baseType.Name.StartsWith("Saitama") && (baseType.Name.EndsWith("Controller") || baseType.Name.EndsWith("Delegate")))
                {
                    return true;
                }

                baseType = baseType.GetTypeInfo().BaseType;
            }

            return false;
        }
    }
}
