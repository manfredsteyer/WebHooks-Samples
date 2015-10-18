using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace owin.security.basic
{
    public class HttpBasicTool
    {
        public static string ToBase64(string userName, string password) {
            var bytes = Encoding.UTF8.GetBytes(userName + ":" + password);
            return Convert.ToBase64String(bytes);
        }
    }
}