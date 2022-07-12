using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealityFirst.Servicio;
using RealityFirst.Models;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace RealityFirst.Controllers
{
    public class NoticiaController : Controller
    {
        IConfiguration config;
        NoticiaServicio app;

        public NoticiaController(IConfiguration config)
        {
            this.config = config;
            string ConnectionString = config.GetConnectionString("dbRealityFirst");
            app = new NoticiaServicio (ConnectionString);
        }
        public IActionResult Noticia()
        {
            IList<Noticia> lista = app.GetAll();
            return View("Noticia",lista);
        }

        public IActionResult FichaNoticia(int id) {
            Noticia obj = app.Get(id);
            return View("FichaNoticia",obj);
        }
    }
}
