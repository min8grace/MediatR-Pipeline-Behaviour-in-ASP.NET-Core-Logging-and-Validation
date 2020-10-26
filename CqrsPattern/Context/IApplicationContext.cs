using CqrsPattern.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CqrsPattern.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChanges();
    }
}