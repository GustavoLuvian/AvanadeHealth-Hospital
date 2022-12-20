using AvanadeHealth.Models;
using Microsoft.EntityFrameworkCore;

namespace AvanadeHealth.Repository.Context
{
    public interface IDatabaseContext
    {
        DbSet<Hospital> Hospital { get; set; }
    }
}
