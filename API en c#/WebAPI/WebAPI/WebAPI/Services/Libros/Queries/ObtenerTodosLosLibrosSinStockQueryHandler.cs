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
    public class ObtenerTodosLosLibrosSinStockQueryHandler : IRequestHandler<ObtenerTodosLosLibrosSinStockQuery, List<Libros>>
    {
        private readonly IWebAPIContext _context;
        
        public ObtenerTodosLosLibrosSinStockQueryHandler(IWebAPIContext context)
        {
            _context = context;   

        }
        public async Task<List<Libros>> Handle(ObtenerTodosLosLibrosSinStockQuery query, CancellationToken cancellationToken)
        {            
            var librosSinStock = _context.Libros.Where(t => t.Stock == 0);
            return await librosSinStock.ToListAsync();  
        }
    }
}
