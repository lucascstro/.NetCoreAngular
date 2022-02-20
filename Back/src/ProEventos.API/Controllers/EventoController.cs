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
    public class EventosController : ControllerBase
    {
        public EventosController()
        {

        }

        public IEnumerable<Evento> evento = new Evento[]
        {
            new Evento(){
                    id = 1,
                    Tema = "Angular 11 e .Net 5",
                    Local = "Pará",
                    Lote = "1",
                    QtdPessoas = 250,
                    DetaEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
            new Evento(){
                    id = 2,
                    Tema = "Angular 11 e .Net 5",
                    Local = "Pará",
                    Lote = "2",
                    QtdPessoas = 350,
                    DetaEvento = DateTime.Now.AddDays(6).ToString("dd/MM/yyyy")
                }
        };
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return evento;
        }

         [HttpGet ("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return evento.Where(x=>x.id == id) ;
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "Exemplo de Put com id " + id;
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Exemplo de Delete com id " + id;
        }
    }
}
