using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewProj.Data;
using NewProj.Models;

namespace NewProj.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public ActionResult Index()
        {
            
            var deals = _context.Deals.ToList();
            ViewBag.Deals = deals;
            ViewBag.IsAdminSession = User.Identity.Name == "admin@admin.com";
            return View();
        }

        [HttpGet]
        public ActionResult Settings(int id)
        {
            var deal = _context.Deals.FirstOrDefault(d => d.DealId == id);
            return View(deal);
        }

        [HttpPost]
        public ActionResult SaveSettings(Deal deal)
        {
            _context.Update(deal);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult SaveDeal(Deal deal)
        {
            deal.DealId = new Random().Next();
            _context.Deals.Add(deal);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateDeal()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SubscribeDeal(int id)
        {
            var deal = _context.Deals.FirstOrDefault(d => d.DealId == id);
            ViewBag.Details = deal;
            return View(deal);
        }
    }
}
