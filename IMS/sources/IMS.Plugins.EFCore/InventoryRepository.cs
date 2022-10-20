using IMS.Domain;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Plugins.EFCore;

public class InventoryRepository : IInventoryRepository
{
    private readonly IMSContext context;

    public InventoryRepository(IMSContext context)
    {
        this.context = context;
    }

    public async Task AddInventoryAsync(Inventory inventory)
    {
        if (context.Inventories.Any(x => x.Name.Equals(inventory.Name, StringComparison.OrdinalIgnoreCase))) return;

        context.Inventories.Add(inventory);
        await context.SaveChangesAsync();
    }

    public async Task<List<Inventory>> GetInventoriesByName(string name)
    {
        var result = string.IsNullOrEmpty(name)
            ? context.Inventories.ToList()
            : context.Inventories.Where(x => x.Name.Contains(name)).ToList();

        return await Task.FromResult(result);
    }

    public async Task<Inventory?> GetInventoryByIdAsync(int inventoryId)
    {
        return await context.Inventories.FindAsync(inventoryId);
    }

    public async Task UpdateInventoryAsync(Inventory inventory)
    {
        if (context.Inventories.Any(x => x.Id != inventory.Id && x.Name.Equals(inventory.Name, StringComparison.OrdinalIgnoreCase))) return;

        var inv = await context.Inventories.FindAsync(inventory.Id);

        if (inv == null) return;

        inv.Name = inventory.Name;
        inv.Price = inventory.Price;
        inv.Quantity = inventory.Quantity;

        await context.SaveChangesAsync();
    }
}
