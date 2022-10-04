using IMS.Domain;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases
{
    public class ViewInventoriesUseCase
    {
        private readonly IInventoryRepository repository;

        public ViewInventoriesUseCase(IInventoryRepository repository)
        {
            this.repository = repository;
        }
        public async Task<List<Inventory>> ExecuteAsynce(string name)
        {
            return await repository.GetInventoriesByName(name); 
        }
    }
}
