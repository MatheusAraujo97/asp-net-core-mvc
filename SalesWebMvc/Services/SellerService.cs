using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context; //instância do banco da aplicação
        }

        public List<Seller> FindAll() //método que vai pegar todos os dados na tabela Seller
        {
            return _context.Seller.ToList(); //retorna os registros da tabela Seller em forma de lista
        }
    }
}
