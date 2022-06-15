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
    public class DeleteLibroCommand : IRequest<Libros>
    {
        public int _id { get; set; }

        public DeleteLibroCommand(int id)
        {
            _id = id;
 
        }

    }
}
