using IMS.Domain;
using IMS.UseCases.Interfaces;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases;

public class ViewInventoryByIdUseCase : IViewInventoryByIdUseCase
{
    private readonly IInventoryRepository repository;

    public ViewInventoryByIdUseCase(IInventoryRepository repository)
    {
        this.repository = repository;
    }
    public async Task<Inventory?> ExecuteAsync(int inventoryId)
    {
        return await repository.GetInventoryByIdAsync(inventoryId);
    }
}
