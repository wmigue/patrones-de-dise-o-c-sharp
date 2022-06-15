
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;

namespace WebAPI
{
    public class ObtenerPedidoByIdQuery : IRequest<List<Pedidos>>
    {
        public int _id { get; }
        public ObtenerPedidoByIdQuery(int id)
        {
            _id=id;
        }
    }
}
