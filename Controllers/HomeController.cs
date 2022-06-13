using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EduHome_BE.DAL;
using EduHome_BE.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace EduHome_BE.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //IEnumerable<HomeVM> homeVM = new IEnumerable<HomeVM>();

            //homeVM.

            return View();
            //return View(homeVM);
        }
    }
}
