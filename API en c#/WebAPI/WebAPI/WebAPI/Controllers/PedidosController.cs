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
    public class PedidosController : ControllerBase
    { 
        private readonly IMediator _mediator;

        public PedidosController(IMediator mediator)
        {
            _mediator = mediator;
        }


        //GET: api/pedidos/id  
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id) =>
             Ok(await _mediator.Send(new ObtenerPedidoByIdQuery(id)));


        //POST /api/pedidos/idlibro //agregar nuevo
        [HttpPost]
        [Route("{idLibro}")]
        public async Task<IActionResult> InsertPedido(int idLibro)
        {
            
            return Ok(await _mediator.Send(new InsertarPedidoCommand(idLibro)));
        }

        //UPDATE PUT: api/pedidos/update/id  
        [HttpPut]
        [Route("update/{id}")]
        public async Task<IActionResult> UpdateById(int id) =>
             Ok(await _mediator.Send(new UpdatePedidoCommand(id)));

        //DELETE /api/pedidos/delete/id   //deletear
        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> DeletePedido(int id) =>
           Ok(await _mediator.Send(new DeletePedidoCommand(id)));


    }
}
