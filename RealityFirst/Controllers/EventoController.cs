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
    public class EventoController : Controller
    {
        IConfiguration config;
        EventoServicio app;

        public EventoController(IConfiguration config)
        {
            this.config = config;
            string ConnectionString = config.GetConnectionString("dbRealityFirst");
            app = new EventoServicio(ConnectionString);
        }
    
        public IActionResult eventos()
        {
            IList<Evento> lista = app.GetAll();

            return View("Eventos",lista);
        }

        public IActionResult ficha(int id)
        {
            Evento obj = app.Get(id);

            return View("ficha",obj);
        }

        public IActionResult Filtrar(string id)
        {
            IList<Evento> eventos = app.FiltrarPorArtista(id);
            return View(eventos);
        }
    }
}
