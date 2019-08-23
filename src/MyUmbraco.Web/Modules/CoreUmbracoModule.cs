using LightInject;

namespace MyUmbraco.Web.Modules
{
    public class CoreUmbracoModule : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
//            serviceRegistry.Register(factory => UmbracoContext.Current).RegisterInstance(new PerScopeLifetime());
//            serviceRegistry.Register(factory => new UmbracoHelper(UmbracoContext.Current)).RegisterInstance(new PerScopeLifetime());
//            serviceRegistry.Register(factory => ApplicationContext.Current.Services.DataTypeService).RegisterInstance(new PerScopeLifetime());
        }
    }
}