using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Przeglady.Data;

namespace Przeglady.Controllers
{
    [Authorize]
    public class MapController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MapController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
        
            return View();
        }
        public double[][] GetPoints()
        {
           
            var list = new List<double[]>();

            foreach (var montaz in _context.Montaz.Where(s=>s.Longitude!=0))
            {
                list.Add(new []{montaz.Longitude,montaz.Latitude});
            }

            return list.ToArray();
        }

       
    }
}