using IMS.Domain;
using IMS.UseCases.Interfaces;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases;

public class EditInventoryUseCase : IEditInventoryUseCase
{
    private readonly IInventoryRepository repository;

    public EditInventoryUseCase(IInventoryRepository repository)
    {
        this.repository = repository;
    }
    public async Task ExecuteAsync(Inventory inventory)
    {
        await this.repository.UpdateInventoryAsync(inventory);
    }
}
