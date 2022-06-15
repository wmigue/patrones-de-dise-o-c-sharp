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
    public class UpdateCommandHandler : IRequestHandler<UpdateLibroCommand, Libros>
    {
        private readonly IWebAPIContext _context;
        
        public UpdateCommandHandler(IWebAPIContext context)
        {
            _context = context;
         
        }
        public async Task<Libros> Handle(UpdateLibroCommand command, CancellationToken cancellationToken)
        {
            Libros libro =_context.Libros.Where(x => x.Id == command.libro.Id).FirstOrDefault();
            if (libro != null)
            {
                libro.Autor = command.libro.Autor;
                libro.Tematica = command.libro.Tematica;
                libro.Stock = command.libro.Stock;
                _context.Libros.Update(libro);
                await _context.SaveChangesAsync();

                return libro;
            }
            else
            {
                Console.WriteLine("no se puede actualizar, ese id libro no existe...");
                return null;
            }    
        }
    }
}


