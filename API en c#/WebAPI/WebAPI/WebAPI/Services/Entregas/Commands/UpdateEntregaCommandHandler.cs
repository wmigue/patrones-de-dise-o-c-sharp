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
    public class UpdateEntregaCommandHandler : IRequestHandler<UpdateEntregaCommand, Entregas>
    {
        private readonly IWebAPIContext _context;
        public UpdateEntregaCommandHandler(IWebAPIContext context)
        {
            _context = context;
        }
        public async Task<Entregas> Handle(UpdateEntregaCommand command, CancellationToken cancellationToken)
        {

            var _buscado = _context.Entregas.Where(x => x.Id == command.Id).FirstOrDefault();
            if (_buscado != null)
            {       
                var fecha = DateTime.Now.ToString("yyyy'-'MM'-'ddTHH':'mm':'ss");
                _buscado.Fecha = fecha;
                _context.Entregas.Update(_buscado);
                await _context.SaveChangesAsync();
                Console.WriteLine("updateado en entregas...");
                return _buscado;
            }
            else
            {
                Console.WriteLine("no se encontro entrega a updatear... error.");
                return null;
            }
        }
    }
}
