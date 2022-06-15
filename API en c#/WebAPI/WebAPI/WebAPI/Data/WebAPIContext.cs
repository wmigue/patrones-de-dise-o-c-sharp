using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class WebAPIContext : DbContext, IWebAPIContext
    {
       
        public WebAPIContext(DbContextOptions<WebAPIContext> options)
            : base(options)
        {
        }
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Entregas> Entregas { get; set; }
        public async Task<int> SaveChangesAsync()
        {
            
            return await base.SaveChangesAsync();
        }
    }
}
