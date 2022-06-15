using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Data;
using System.Net.Http;
using Newtonsoft.Json;

namespace WebAPI
{
    public class InsertarPedidoCommandHandler : IRequestHandler<InsertarPedidoCommand, Pedidos>
    {
        private readonly IWebAPIContext _context;
        public InsertarPedidoCommandHandler(IWebAPIContext context)
        {
            _context = context;
        }
        public async Task<Pedidos> Handle(InsertarPedidoCommand command, CancellationToken cancellationToken)
        {
            IStrategyCadena _estrategiaCadena = new Dominio2Strategy(); //puerto 5001
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(_estrategiaCadena.GetConexion()+"api/Libros/"+command.IdLibros.ToString());
            var json = await response.Content.ReadAsStringAsync();
            var libros = JsonConvert.DeserializeObject <List<Libros>>(json); //lista de libros
            Libros e = libros.Where(e => e.Id == command.IdLibros && e.Stock > 0).FirstOrDefault(); //un libro, default = null
            if (e != null)
            {
                var pedido = new Pedidos();
                pedido.Fecha = command.Fecha.ToString();
                pedido.IdLibros = command.IdLibros;
                pedido.Entregado = command.Entregado;
                _context.Pedidos.Add(pedido);
                await _context.SaveChangesAsync();
                Console.WriteLine("pedido insertado.");
                return pedido;
            }
            else
            {
                Console.WriteLine($"no se pudo generar el pedido, ese libro con id: {command.IdLibros} no existe / no hay stock suficiente.");
                return null;
            }
        }
    }
}
