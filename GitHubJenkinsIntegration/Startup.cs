using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubJenkinsIntegration.Startup))]
namespace GitHubJenkinsIntegration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

        }
    }
}
