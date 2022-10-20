using IMS.Domain;

namespace IMS.UseCases.Interfaces
{
    public interface IViewInventoriesUseCase
    {
        Task<List<Inventory>> ExecuteAsynce(string name);
    }
}