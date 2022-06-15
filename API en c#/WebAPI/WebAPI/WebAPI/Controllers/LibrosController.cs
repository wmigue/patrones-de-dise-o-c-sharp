using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;
using Microsoft.AspNetCore.Cors;
using MediatR;
using Microsoft.Extensions.Logging;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("permitir")]
    public class LibrosController : ControllerBase
    { 
        private readonly IMediator _mediator;

        public LibrosController(IMediator mediator)
        {
            _mediator = mediator;

        }

        //GET ALL /api/libros
        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new ObtenerTodosLosLibrosQuery()));


        //GET ALL /api/libros
        [HttpGet]
        [Route("sinStock/")]
        public async Task<IActionResult> GetAllSinStock() => Ok(await _mediator.Send(new ObtenerTodosLosLibrosSinStockQuery()));



        // GET: api/libros/tematica  //tiene un patron de diseño asociado para validar errores de tipeo de los usuarios y traer el posible resultado.
        [HttpGet]
        [Route("tematica/{tematica}")]
        public async Task<IActionResult> GetByTematica(string tematica) =>
             Ok(await _mediator.Send(new ObtenerLibroByTematicaQuery(tematica)));

        // GET: api/libros/id 
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id) =>
             Ok(await _mediator.Send(new ObtenerLibroByIdQuery(id)));


        //POST /api/Libros //agregar nuevo
        [HttpPost]
        public async Task<IActionResult> InsertLibro(Libros libro)=>
           Ok(await _mediator.Send(new InsertarLibroCommand(libro)));

        //PUT /api/Libros/   //updatear
        [HttpPut]
        public async Task<IActionResult> UpdateLibro(Libros libro) =>
           Ok(await _mediator.Send(new UpdateLibroCommand(libro)));

        //DELETE /api/Libros/id   //deletear
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteLibro(int id) =>
           Ok(await _mediator.Send(new DeleteLibroCommand(id)));
    }
}
