using FishWebConnection.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FishWebConnection.Controllers
{
    public class FisksController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Fisk> fiskar = new List<Fisk>();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("http://localhost:55936/api/Fisks");
            string jsonresponse = await response.Content.ReadAsStringAsync();
            fiskar = JsonConvert.DeserializeObject<List<Fisk>>(jsonresponse);

            // TRY CATCH OMDIRIGERAR TILL FULSIDA VID ERROR
            try
            {
                return View(fiskar);  
            }
            catch (Exception)
            {
                return RedirectToAction("EnFulErrorSida");
            }

           
        }
    }
}
