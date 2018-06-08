using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(WebApiTokenBased.Startup))]

namespace WebApiTokenBased
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //var config = new HttpConfiguration();
            ConfigureAuth(app);

            //WebApiConfig.Register(config);
            //app.UseWebApi(config);
            
            //GlobalConfiguration.Configure(WebApiConfig.Register);
            
        }
    }
}
