using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Data;
using System.Net.Http;
using Newtonsoft.Json;

namespace WebAPI
{
    public class DeletePedidoCommandHandler : IRequestHandler<DeletePedidoCommand, bool>
    {
        private readonly IWebAPIContext _context;
        public DeletePedidoCommandHandler(IWebAPIContext context)
        {
            _context = context;
        }
        public async Task<bool> Handle(DeletePedidoCommand command, CancellationToken cancellationToken)
        {
            var pedido = _context.Pedidos.FirstOrDefault(x => x.Id == command.Id);
            if (pedido != null)
            {
                _context.Pedidos.Remove(pedido);
                await _context.SaveChangesAsync();
                var entrega = _context.Entregas.FirstOrDefault(x => x.IdPedidos == command.Id);
                if (entrega != null)
                {
                    _context.Entregas.Remove(entrega);
                    await _context.SaveChangesAsync(); //elimino entrega asociada si existe.
                }          
            }

            //si logro ejecutar el request true sino false. es decir, si lo encuentra en base de datos no lo eliminó.
            if (_context.Pedidos.Contains(pedido))
               return false;
            else
               return true;




        }
    }
}
