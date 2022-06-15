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
    public class InsertarLibroCommand : IRequest<Libros>
    {
        public string Autor { get; set; }
        public string Tematica { get; set; }
        public int Stock { get; set; }
        public InsertarLibroCommand(Libros l)
        {
            Autor = l.Autor;
            Tematica = l.Tematica;
            Stock = l.Stock;
        }

    }
}
