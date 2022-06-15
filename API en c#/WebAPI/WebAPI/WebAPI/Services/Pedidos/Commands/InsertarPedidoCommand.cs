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
    public class InsertarPedidoCommand : IRequest<Pedidos>
    {
       
        public int Id { get; set; }
        public int IdLibros { get; set; }
        public string Fecha { get; set; }
        public bool Entregado { get; set; }
        public InsertarPedidoCommand(int idLibro)
        {
            
            IdLibros = idLibro;
            Fecha = DateTime.Now.ToString("yyyy'-'MM'-'ddTHH':'mm':'ss");
            Entregado = false;
        }

    }
}
