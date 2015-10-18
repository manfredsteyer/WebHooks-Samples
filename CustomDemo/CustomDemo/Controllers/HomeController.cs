using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CustomDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // Rolle: Produzent
        public async Task<ActionResult> SendEvent()
        {
            var result = await this.NotifyAsync("statusUpdated", new { status = "information available", date = DateTime.Now });
            ViewBag.Message = "Status-Update gesendet! Anzahl: " + result;

            return View();
        }

        private string ToBase64(string userName, string password)
        {
            var bytes = Encoding.UTF8.GetBytes(userName + ":" + password);
            return Convert.ToBase64String(bytes);
        }

        // Rolle: Konsument
        public async Task<ActionResult> Register()
        {
        var client = new HttpClient();
            
        var credentials = ToBase64("me@office.com", "P@ssw0rd");
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);

        var url = "http://localhost:8798/api/webhooks/registrations";

        var body = new
        {
            WebHookUri = "http://localhost:8798/api/webhooks/incoming/custom",
            Secret = "1234567890abcdefghijklmnopqrstuvwxyz",
            Description = "Demo-Abbo"
        };

        var response = await client.PostAsJsonAsync(url, body);

        ViewBag.Message = "Antwort: " + response.StatusCode;

            return View();
        }


    }
}