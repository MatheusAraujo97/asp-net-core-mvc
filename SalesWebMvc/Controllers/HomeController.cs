using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() //IActionResult é o resultado de uma ação
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Sales Web MVC App from C# Course"; //passou o valor para a chave message do viewData
            ViewData["Student"] = "Matheus";
            return View(); 
            //vai retornar a view de acordo com o método, nesse caso o framework vai procurar na pasta views
            // na subpasta Home(nome do controller) pela view About
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
