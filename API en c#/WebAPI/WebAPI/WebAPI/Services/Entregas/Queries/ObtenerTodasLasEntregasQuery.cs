
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;

namespace WebAPI
{
    public class ObtenerTodasLasEntregasQuery : IRequest<List<EntregasPedidosLibros>>
    {
    }
}
