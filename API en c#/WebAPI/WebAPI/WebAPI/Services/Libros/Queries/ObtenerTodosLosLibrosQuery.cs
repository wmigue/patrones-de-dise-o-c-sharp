
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;

namespace WebAPI
{
    public class ObtenerTodosLosLibrosQuery : IRequest<List<Libros>>
    {
    }
}
