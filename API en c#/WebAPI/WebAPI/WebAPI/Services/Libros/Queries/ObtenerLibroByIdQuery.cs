
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;

namespace WebAPI
{
    public class ObtenerLibroByIdQuery : IRequest <List<Libros>>
    {
        public int Id { get; }
        public ObtenerLibroByIdQuery(int id)
        {
            Id = id;
        }
    }
}
