using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index() //chama o controlador
        {
            var list = _sellerService.FindAll(); //o controlador pega os dados da classe SellerService do método FindAll
            return View(list); //retorna essa lista em uma view
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);//vai inserir o vendedor na tabela Seller
            return RedirectToAction(nameof(Index)); //vai redirecionar para a ação Index(que vai chamar a View Index que mostra a lista de sellers)
        }
    }
}