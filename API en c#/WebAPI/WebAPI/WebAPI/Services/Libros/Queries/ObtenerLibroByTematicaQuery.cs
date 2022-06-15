
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;

namespace WebAPI
{
    public class ObtenerLibroByTematicaQuery : IRequest<List<Libros>>
    {
        public string Tematica { get; }
        public ObtenerLibroByTematicaQuery(string t)
        {
            Tematica = t;
        }
    }
}
