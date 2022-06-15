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
    public class InsertarEntregaCommandHandler : IRequestHandler<InsertarEntregaCommand, Entregas>
    {
        private readonly IWebAPIContext _context;
        public InsertarEntregaCommandHandler(IWebAPIContext context)
        {
            _context = context;
        }
        public async Task<Entregas> Handle(InsertarEntregaCommand command, CancellationToken cancellationToken)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            Pedidos pedido = _context.Pedidos.Where(e => e.Id == command.IdPedidos && e.Entregado == false).FirstOrDefault(); //un pedido, default = null
            Console.WriteLine(command.IdPedidos);
            if (pedido != null )
            {
                
                var request = new HttpRequestMessage(HttpMethod.Put, "https://localhost:5001/api/pedidos/update/" + command.IdPedidos.ToString()); // en pedios, entregado=true     
                var httpClient = new HttpClient();
                await httpClient.SendAsync(request);
                response = await client.GetAsync("https://localhost:5001/api/libros/" + pedido.IdLibros.ToString()); // busco el autor del libro entregado y lo muestro por consola, también resto 1 al stock.
                var json = await response.Content.ReadAsStringAsync();
                var libros = JsonConvert.DeserializeObject<List<Libros>>(json); //devuelve <List<Libros>>
                Libros libro = libros.Where(x => x.Id == pedido.IdLibros).FirstOrDefault();  //un solo libro.
                libro.Stock = libro.Stock - 1;
                _context.Libros.Update(libro);
                var Entrega = new Entregas();
                Entrega.Fecha = command.Fecha;
                Entrega.IdPedidos = command.IdPedidos;
                _context.Entregas.Add(Entrega);
                await _context.SaveChangesAsync();
                Console.WriteLine($"entrega insertada con éxito. \n Autor del libro: {libro.Autor}");
                return Entrega;
            }
            else
            {
                Console.WriteLine($"no se pudo generar la entrega, el pedido con id: {command.IdPedidos} no existe. O quizas ese pedido ya figura como ENTREGADO=TRUE");
                return null;
            }
        }
    }
}
