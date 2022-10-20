using IMS.Domain;

namespace IMS.UseCases.PluginInterfaces;

public interface IInventoryRepository
{
    Task AddInventoryAsync(Inventory inventory);
    Task<List<Inventory>> GetInventoriesByName(string name);
    Task<Inventory?> GetInventoryByIdAsync(int inventoryId);
    Task UpdateInventoryAsync(Inventory inventory);
}