using EntitiesTesteCandidato;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebTesteCandidato.Models;

namespace WebTesteCandidato.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Cep dados)
        {
            try
            {
                var client = new RestClient("https://localhost:44347/");
                var request = new RestRequest("api/Cadastrar", Method.POST);
                request.AddJsonBody(dados);

                var queryResult =  client.Execute(request);
                ViewBag.Class = "success";
                ViewBag.Mensagem = "Dados criado com sucesso!";

                return View(dados);
            }
            catch (Exception ex)
            {
                ViewBag.Class = "danger";
                ViewBag.Mensagem = "Erro cadastrar o endereço. Erro :"+ ex;
                return View(dados);
            }
        }
        public async Task<ActionResult> Privacy()
        {
            var client = new RestClient("https://localhost:44347/");
            var request = new RestRequest("api/BuscarLista", Method.GET);
            var result = client.Execute(request).Content;
            var queryResult = JsonConvert.DeserializeObject<List<Cep>>(result);
            return View(queryResult);
        }
    }
}
