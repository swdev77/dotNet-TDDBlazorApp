using IMS.Domain;
using IMS.UseCases.Interfaces;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Inventories;

public class EditInventoryUseCase : IEditInventoryUseCase
{
    private readonly IInventoryRepository repository;

    public EditInventoryUseCase(IInventoryRepository repository)
    {
        this.repository = repository;
    }
    public async Task ExecuteAsync(Inventory inventory)
    {
        await repository.UpdateInventoryAsync(inventory);
    }
}
