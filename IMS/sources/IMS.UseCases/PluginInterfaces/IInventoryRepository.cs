using IMS.Domain;

namespace IMS.UseCases.PluginInterfaces;

public interface IInventoryRepository
{
    Task<List<Inventory>> GetInventoriesByName(string name);
}