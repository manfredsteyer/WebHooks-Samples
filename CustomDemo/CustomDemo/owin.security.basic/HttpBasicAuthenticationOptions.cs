using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace OwinSample.BasicAuthMiddleware
{
    public class HttpBasicAuthenticationOptions : AuthenticationOptions
    {
        public HttpBasicAuthenticationOptions(string authenticationType) : base(authenticationType)
        {
        }

        public HttpBasicAuthenticationOptions()
            : base("Basic")
        {
        }


        public Func<string, string, bool> ValidateCredentials { get; set; }
    }
}
