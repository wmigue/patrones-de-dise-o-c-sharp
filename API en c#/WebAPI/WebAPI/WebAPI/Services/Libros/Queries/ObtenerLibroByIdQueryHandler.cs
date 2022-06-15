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
    public class ObtenerLibroByIdQueryHandler : IRequestHandler<ObtenerLibroByIdQuery, List<Libros>>
    {
        private readonly IWebAPIContext _context;

       public ObtenerLibroByIdQueryHandler(IWebAPIContext context)
        {
            _context = context;
        }

        public async Task<List<Libros>> Handle(ObtenerLibroByIdQuery query, CancellationToken cancellationToken)
        {
            IQueryable<Libros>  _resultados;
            _resultados = _context.Libros;
            _resultados = _resultados.Where(e => e.Id == query.Id);

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
