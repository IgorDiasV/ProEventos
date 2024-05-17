using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public IEnumerable<Evento> _evento = new Evento [] {
            new Evento(){
                EventoId = 1,
                Tema = "Teste Tema",
                Local = "Teste Local",
                Lote = "Primeiro lote",
                QtdPessoas = 100,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "https://wwww"
            },                    
            new Evento(){
                EventoId = 2,
                Tema = "Teste Tema",
                Local = "Teste Local",
                Lote = "Primeiro lote",
                QtdPessoas = 100,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "https://wwww"
            }
        };

        public EventoController()
        {
            
        }

        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }
    }
}