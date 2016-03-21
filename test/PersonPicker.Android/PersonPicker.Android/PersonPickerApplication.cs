using System;
using System.Reflection;
using Android.App;
using Android.Runtime;
using Autofac;
using PersonPicker.Android.Services;
using PersonPicker.Android.Services.Impl;
using Saitama.Android;
using Saitama.Container.Autofac.Android;
using Saitama.Core.Framework;

namespace PersonPicker.Android
{
    [Application]
    public class PersonPickerApplication : SaitamaApplication
    {
        public PersonPickerApplication(IntPtr ptr, JniHandleOwnership transfer) : base(ptr, transfer)
        {
        }

        protected override InjectionContainerResolverBase GetInjectionContainerResolver()
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<OnePunchHeroPersonService>().As<IPersonService>();

            return new AutofacInjectionContainerResolver(cb, Assembly.GetExecutingAssembly());
        }
    }
}