using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Infrastructure;

namespace OwinSample.BasicAuthMiddleware
{
    class HttpBasicAuthenticationMiddleware : AuthenticationMiddleware<HttpBasicAuthenticationOptions>
    {
        public HttpBasicAuthenticationMiddleware(OwinMiddleware next, HttpBasicAuthenticationOptions options) : base(next, options)
        {
        }

        protected override AuthenticationHandler<HttpBasicAuthenticationOptions> CreateHandler()
        {
            return new HttpBasicAuthenticationHandler();
        }
    }
}
