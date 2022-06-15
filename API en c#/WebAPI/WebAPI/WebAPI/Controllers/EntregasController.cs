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
    public class EntregasController : ControllerBase
    { 
        private readonly IMediator _mediator;

        public EntregasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //GET ALL /api/entregas
        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new ObtenerTodasLasEntregasQuery()));


        //POST /api/entregas/idpedido //agregar nueva
        [HttpPost, HttpPut]
        [Route("{idPedido}")]
        public async Task<IActionResult> InsertEntrega(int idPedido)
        {
            return Ok(await _mediator.Send(new InsertarEntregaCommand(idPedido)));
        }


        //PUT /api/entregas/update/idEntrega //actualizar
        [HttpPut]
        [Route("update/{idEntrega}")]
        public async Task<IActionResult> PutEntrega(int idEntrega)
        {
            return Ok(await _mediator.Send(new UpdateEntregaCommand(idEntrega)));
        }



        //DELETE /api/entregas/delete/id   //deletear
        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> DeletePedido(int id) =>
           Ok(await _mediator.Send(new DeleteEntregaCommand(id)));



    }
}
