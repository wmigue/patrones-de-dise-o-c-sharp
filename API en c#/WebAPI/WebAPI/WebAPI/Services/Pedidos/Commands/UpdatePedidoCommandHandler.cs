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
    public class UpdatePedidoCommandHandler : IRequestHandler<UpdatePedidoCommand, Pedidos>
    {
        private readonly IWebAPIContext _context;
        public UpdatePedidoCommandHandler(IWebAPIContext context)
        {
            _context = context;
        }
        public async Task<Pedidos> Handle(UpdatePedidoCommand command, CancellationToken cancellationToken)
        {

            var _buscado = _context.Pedidos.Where(x => x.Id == command.Id).FirstOrDefault();
            if (_buscado != null)
            {
                var pedido = new Pedidos();
                _buscado.Entregado = true;
                _context.Pedidos.Update(_buscado);
                await _context.SaveChangesAsync();
                Console.WriteLine("pedido updateado...");
                return _buscado;
            }
            else
            {
                Console.WriteLine("no se encontro el pedido a updatear... error.");
                return null;
            }
        }
    }
}
