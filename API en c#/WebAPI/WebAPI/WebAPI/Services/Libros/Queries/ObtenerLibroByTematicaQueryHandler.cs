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
    public class ObtenerLibroByTematicaQueryHandler : IRequestHandler<ObtenerLibroByTematicaQuery, List<Libros>>
    {
        private readonly IWebAPIContext _context;
        AbstraccionSearch _abstraccionSearch;

       public ObtenerLibroByTematicaQueryHandler(IWebAPIContext context)
        {
            _context = context;
        }

        public async Task<List<Libros>> Handle(ObtenerLibroByTematicaQuery query, CancellationToken cancellationToken)
        {
            IQueryable<Libros> _resultados;
            _abstraccionSearch = new AbstraccionSearch(query.Tematica);

            _resultados = _context.Libros;
            _resultados = _resultados.Where(e => e.Tematica.Contains(_abstraccionSearch.Ejecutar()));

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
