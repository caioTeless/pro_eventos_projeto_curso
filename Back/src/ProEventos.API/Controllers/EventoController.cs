using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> Eventos = new Evento[]{
            new Evento()
                {
                    EventoId = 1,
                    Tema = "Angular ...",
                    local = "SP",
                    Lote = "1234",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImageUrl = "teste.png"
                },
            new Evento()
                {
                    EventoId = 2,
                    Tema = "Angular2 ...",
                    local = "SP2",
                    Lote = "12342",
                    QtdPessoas = 2520,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImageUrl = "teste.png222"
                }
        };

        public EventoController(ILogger<EventoController> logger)
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return Eventos;
        }

        // Passa ID como parâmetro
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id){
            return Eventos.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Value";
        }
    }
}
