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
using System.Net.Http;
using Newtonsoft.Json;

namespace WebAPI
{
    public class ObtenerTodasLasEntregasQueryHandler : IRequestHandler<ObtenerTodasLasEntregasQuery, List<EntregasPedidosLibros>> 
    {
        private readonly IWebAPIContext _context;

        public ObtenerTodasLasEntregasQueryHandler(IWebAPIContext context)
        {
            _context = context;   

        }
        public async Task<List<EntregasPedidosLibros>> Handle(ObtenerTodasLasEntregasQuery query, CancellationToken cancellationToken)
        {
            List<EntregasPedidosLibros> entregasPedidosLista = new List<EntregasPedidosLibros>();
            EntregasPedidosLibros epl;

            foreach(var e in _context.Entregas)
            {
                //PRIMERA FORMA DE RESOLVERLO: agregar a la cadena de conexion esto: MultipleActiveResultSets = true; (de stackoverflow)
                var pedido = _context.Pedidos.Where(x => x.Id == e.IdPedidos).FirstOrDefault(); //traigo pedido relacionado a cada entrega
                var libro = _context.Libros.Where(x => x.Id == pedido.IdLibros).FirstOrDefault(); //traigo libro relacionado a cada entrega

                //SEGUNDA FORMA, pero tarda mas tiempo en resolver el response. 
                // HttpClient client = new HttpClient();
                //HttpResponseMessage response;
                //response = await client.GetAsync("https://localhost:5001/api/Pedidos/" + e.IdPedidos.ToString());
                //var json = await response.Content.ReadAsStringAsync();
                //var pedidos = JsonConvert.DeserializeObject<List<Pedidos>>(json); //devuelve <List<pedidos>>
                //var pedido = pedidos.Where(x => x.Id == e.IdPedidos).FirstOrDefault();  //un solo pedido.

                //response = await client.GetAsync("https://localhost:5001/api/Libros/" + pedido.IdLibros.ToString());
                //json = await response.Content.ReadAsStringAsync();
                //var libros = JsonConvert.DeserializeObject<List<Libros>>(json); //devuelve <List<libros>>
                //var libro = libros.Where(x => x.Id == pedido.IdLibros).FirstOrDefault();  //un solo libro.

                epl = new EntregasPedidosLibros
                {
                    IdEntregas = e.Id,
                    FechaEntrega = e.Fecha,
                    IdPedidos = pedido.Id,
                    PedidoEntregado = pedido.Entregado,
                    FechaPedido = pedido.Fecha,
                    LibroTematica = libro.Tematica,
                    LibroAutor = libro.Autor,
                };

                entregasPedidosLista.Add(epl);                
            }
            return entregasPedidosLista;      
        }
    }
}
