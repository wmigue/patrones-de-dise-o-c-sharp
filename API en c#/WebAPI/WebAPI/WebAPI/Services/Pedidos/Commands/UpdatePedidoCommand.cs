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
    public class UpdatePedidoCommand : IRequest<Pedidos>
    {
        public int Id { get; set; }

        public UpdatePedidoCommand(int idPedido)
        {
            Id = idPedido;
       
        }

    }
}
