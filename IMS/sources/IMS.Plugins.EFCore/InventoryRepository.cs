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
    public async Task<List<Inventory>> GetInventoriesByName(string name)
    {
        var result = string.IsNullOrEmpty(name)
            ? context.Inventories.ToList()
            : context.Inventories.Where(x => x.Name.Contains(name)).ToList();

        return await Task.FromResult(result);
    }
}
