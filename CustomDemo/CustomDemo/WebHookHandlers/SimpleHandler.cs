using Microsoft.AspNet.WebHooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace CustomWebHook.WebHookHandlers
{
    public class SimpleHandler : WebHookHandler
    {
        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            Debug.WriteLine(receiver);
            Debug.WriteLine(context.Id);
            Debug.WriteLine(context.Request.Method);
            Debug.WriteLine(context.Actions.FirstOrDefault());
            Debug.WriteLine(context.GetDataOrDefault<JObject>());
            
            
            // context.Response = ...

            return Task.FromResult<object>(null);
        }
    }
}