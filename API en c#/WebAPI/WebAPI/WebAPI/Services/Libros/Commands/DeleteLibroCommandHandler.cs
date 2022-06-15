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
    public class DeleteLibroCommandHandler : IRequestHandler<DeleteLibroCommand, Libros>
    {
        private readonly IWebAPIContext _context;
        
        public DeleteLibroCommandHandler(IWebAPIContext context)
        {
            _context = context;
         
        }
        public async Task<Libros> Handle(DeleteLibroCommand command, CancellationToken cancellationToken)
        {
            
            var _buscado = _context.Libros.Find(command._id);
            if (_buscado!=null)
            {
                _context.Libros.Remove(_buscado);
                await _context.SaveChangesAsync();
                return _buscado;
            }
            else
            {
                return null;
            }


        }
    }
}


