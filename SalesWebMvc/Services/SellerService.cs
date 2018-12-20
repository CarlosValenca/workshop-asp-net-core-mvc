using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        // ssbcvp - SellerService Implementation

        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            // ssbcvp - objeto Seller já está devidamente conectado ao id do departamento então
            // não é necessário a alteração provisória abaixo
            //obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }


    }
}
