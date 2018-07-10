using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NLLingadConstruction.Startup))]
namespace NLLingadConstruction
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
