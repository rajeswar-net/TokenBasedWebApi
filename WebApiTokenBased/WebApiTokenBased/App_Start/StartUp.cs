namespace WebApiTokenBased
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using Owin;
    using Microsoft.Owin.Security.OAuth;
    using Microsoft.Owin;

    public partial class Startup
    {
       
        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        static Startup()
        {
            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/token"),
                Provider = new CustomOAuthProvider(),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                AllowInsecureHttp = true
            };
        }
        public void ConfigureAuth(IAppBuilder app)
        {
            app.UseOAuthAuthorizationServer(OAuthOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}