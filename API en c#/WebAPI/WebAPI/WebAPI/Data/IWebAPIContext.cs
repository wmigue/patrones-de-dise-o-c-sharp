using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public interface IWebAPIContext
    {
        DbSet<Libros> Libros { get; set; }
        DbSet<Pedidos> Pedidos { get; set; }
        DbSet<Entregas> Entregas { get; set; }

        Task<int> SaveChangesAsync();
    }
}