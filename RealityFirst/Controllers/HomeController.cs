using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RealityFirst.Models;
using RealityFirst.Servicio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace RealityFirst.Controllers
{
    public class HomeController : Controller
    {
        

        IConfiguration config;
        EventoServicio app;

        public HomeController(IConfiguration config)
        {
            this.config = config;
            string ConnectionString = config.GetConnectionString("dbRealityFirst");
            app = new EventoServicio(ConnectionString);
        }


        public IActionResult Index()
        {
            IList<Evento> lista = app.GetAll();
            return View(lista);
        }

        public IActionResult Contacto()
        {
            return View();
        }

        public IActionResult Nosotros()
        {
            return View();
        }

        public IActionResult Redes()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
