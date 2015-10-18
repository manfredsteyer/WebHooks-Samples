using Microsoft.AspNet.WebHooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace WebHookDemo.WebHookHandlers
{
    public class SimpleHandler : WebHookHandler
    {
        public SimpleHandler()
        {
            // this.Receiver = "GitHub";
            // this.Order = 1;
        }

        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            Debug.WriteLine(receiver);
            Debug.WriteLine(context.Id);
            Debug.WriteLine(context.Request.Method);
            Debug.WriteLine(context.Actions.FirstOrDefault());
            Debug.WriteLine(context.GetDataOrDefault<JObject>());

            return Task.FromResult<object>(null);
        }
    }
}