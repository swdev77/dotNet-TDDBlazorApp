using IMS.Domain;

namespace IMS.UseCases
{
    public interface IViewInventoriesUseCase
    {
        Task<List<Inventory>> ExecuteAsynce(string name);
    }
}