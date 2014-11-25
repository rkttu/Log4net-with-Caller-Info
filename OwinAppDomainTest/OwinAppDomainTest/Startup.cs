using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OwinAppDomainTest.Startup))]

namespace OwinAppDomainTest
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
