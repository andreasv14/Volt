using Microsoft.EntityFrameworkCore;
using Volt.Domain.Entities;

namespace Volt.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    public DbSet<Category> Categories { get; set; }
}
