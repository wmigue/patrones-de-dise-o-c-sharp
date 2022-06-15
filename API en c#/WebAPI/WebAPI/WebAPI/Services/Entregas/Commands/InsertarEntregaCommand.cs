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
    public class InsertarEntregaCommand : IRequest<Entregas>
    {
      
        public int IdPedidos { get; set; }
        public string Fecha { get; set; }

        public InsertarEntregaCommand(int id)
        {
            IdPedidos = id;
            Fecha = DateTime.Now.ToString("yyyy'-'MM'-'ddTHH':'mm':'ss");        
        }

    }
}
