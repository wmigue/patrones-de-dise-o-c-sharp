using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Data;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace WebAPI
{
    public class ObtenerPedidoByIdQueryHandler : IRequestHandler<ObtenerPedidoByIdQuery, List<Pedidos>>
    {
        private readonly IWebAPIContext _context;


       public ObtenerPedidoByIdQueryHandler(IWebAPIContext context)
        {
            _context = context;
        }

        public async Task<List<Pedidos>> Handle(ObtenerPedidoByIdQuery query, CancellationToken cancellationToken)
        {
            IQueryable<Pedidos> _resultados;
            _resultados = _context.Pedidos;
            _resultados = _resultados.Where(e => e.Id==query._id);

            if (_resultados != null)
            {
                
                return await _resultados.ToListAsync();
            }
            else
            {
                return null;
            }

            
        }
    }
}
