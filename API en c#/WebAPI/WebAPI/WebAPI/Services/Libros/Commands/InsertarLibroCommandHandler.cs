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
    public class InsertarLibroCommandHandler : IRequestHandler<InsertarLibroCommand, Libros>
    {
        private readonly IWebAPIContext _context;
        public InsertarLibroCommandHandler(IWebAPIContext context)
        {
            _context = context;
        }
        public async Task<Libros> Handle(InsertarLibroCommand command, CancellationToken cancellationToken)
        {
            var libro = new Libros();
            libro.Autor = command.Autor;
            libro.Tematica = command.Tematica;
            libro.Stock = command.Stock;
            _context.Libros.Add(libro);
            await _context.SaveChangesAsync();
            return libro;
        }
    }
}
