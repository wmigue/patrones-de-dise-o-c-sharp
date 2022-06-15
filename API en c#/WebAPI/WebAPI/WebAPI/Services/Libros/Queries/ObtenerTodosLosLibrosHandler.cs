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
    public class ObtenerTodosLosLibrosHandler : IRequestHandler<ObtenerTodosLosLibrosQuery, List<Libros>>
    {
        private readonly IWebAPIContext _context;
        
        public ObtenerTodosLosLibrosHandler(IWebAPIContext context)
        {
            _context = context;   

        }
        public async Task<List<Libros>> Handle(ObtenerTodosLosLibrosQuery query, CancellationToken cancellationToken)
        {
            IQueryable<Libros> _query;
            _query = _context.Libros;
            _query.Select(t => t).OrderBy(x => x.Id).ToList();
            return await _query.ToListAsync();


           
        }
    }
}
