using Owin;
using OwinSample.BasicAuthMiddleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Extensions;

namespace Owin
{
    public static class HttpBasicAuthenticationExtensions
    {
        public static void UseHttpBasic(this IAppBuilder app, HttpBasicAuthenticationOptions options) {
            app.Use(typeof(HttpBasicAuthenticationMiddleware), options);
        }

    }
}