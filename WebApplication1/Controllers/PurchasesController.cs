using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PurchasesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PurchasesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Purchase> purchases = await _context
                .Purchases
                .Include(purchase => purchase.Book)
                .Include(purchase => purchase.Customer)
                .ToListAsync();

            return View(purchases);
        }

        //[HttpGet]
        //public IActionResult Buy(int? bookId)
        //{
        //    ViewBag.BookId = bookId ?? 0;
        //    return View();
        //}

        //[HttpPost]
        //public string Buy(Purchase purchase)
        //{
        //    purchase.Date = DateTime.Now;

        //    _context.Purchases.Add(purchase);
        //    _context.SaveChanges();
        //    return $"Дякуємо, {purchase.Person}, за купівлю!";
        //}
    }
}
