using IMS.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Plugins.EFCore;

public class IMSContext : DbContext
{
    public IMSContext(DbContextOptions<IMSContext> options) : base(options)
    {
    }
    public DbSet<Inventory> Inventories => Set<Inventory>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Inventory>().HasData(InventoryList.Make());
        base.OnModelCreating(modelBuilder);
    }
}
