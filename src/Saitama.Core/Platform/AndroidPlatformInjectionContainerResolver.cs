using System.Reflection;
using Saitama.Core.Framework;

namespace Saitama.Core.Platform
{
    public abstract class AndroidPlatformInjectionContainerResolver : InjectionContainerResolverBase
    {
        protected AndroidPlatformInjectionContainerResolver(Assembly entryAssembly) : base(entryAssembly)
        {
        }

        /// <summary>
        /// Indicates the convention by which Android base injectable types are found. By default this looks for ...
        /// </summary>
        /// <returns><c>true</c>, if android convention was matchesed, <c>false</c> otherwise.</returns>
        /// <param name="typeInfo">Type info.</param>
        protected override bool MatchesConvention(TypeInfo typeInfo)
        {
            var baseType = typeInfo.BaseType;
            while (baseType != null && !baseType.Name.EndsWith("Lang.Object"))
            {
                if (baseType.Name.StartsWith("Saitama") && (baseType.Name.EndsWith("Application") || 
                    baseType.Name.EndsWith("Activity") || baseType.Name.EndsWith("Fragment") || baseType.Name.EndsWith("Provider") ||
                    baseType.Name.EndsWith("Service")))
                {
                    return true;
                }

                baseType = baseType.GetTypeInfo().BaseType;
            }

            return false;
        }
    }
}
