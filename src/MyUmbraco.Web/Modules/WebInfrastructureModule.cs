using LightInject;

namespace MyUmbraco.Web.Modules
{
    public class WebInfrastructureModule : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.RegisterControllers();
            serviceRegistry.RegisterApiControllers();
        }
    }
}