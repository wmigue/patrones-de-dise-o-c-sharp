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
    public class DeleteEntregaCommandHandler : IRequestHandler<DeleteEntregaCommand, string>
    {
        private readonly IWebAPIContext _context;
   
        public DeleteEntregaCommandHandler(IWebAPIContext context)
        {
            _context = context;
        }
        public async Task<string> Handle(DeleteEntregaCommand command, CancellationToken cancellationToken)
        {
            IDecorador _pordefault = new PorDefault();
            _pordefault = new Decorador1(_pordefault); //decorador1

            var entrega = _context.Entregas.FirstOrDefault(x => x.Id == command.Id);
            if (entrega != null)
            {
                _context.Entregas.Remove(entrega); //elimino entrega
                await _context.SaveChangesAsync();
                var pedido = _context.Pedidos.FirstOrDefault(x => x.Id == entrega.IdPedidos);
                if (pedido != null)
                {
                    pedido.Entregado = false;
                    _context.Pedidos.Update(pedido);
                    await _context.SaveChangesAsync(); //entregado en tabla libros = false 
                }
                return _pordefault.Retornar(true);
            }
            else
            {
                return _pordefault.Retornar(false);
            }
        }
    }
}
