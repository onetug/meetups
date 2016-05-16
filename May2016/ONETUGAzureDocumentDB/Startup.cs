using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ONETUGAzureDocumentDB.Startup))]
namespace ONETUGAzureDocumentDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
