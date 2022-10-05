using IMS.Domain;
using IMS.TestFixture;
using Microsoft.EntityFrameworkCore;
using NSubstitute;

namespace IMS.Plugins.EFCore.Tests
{
    public class InventoryRepositoryTests
    {
        private IMSContext context;
        private InventoryRepository repository;

        public InventoryRepositoryTests()
        {
            context = IMSContextFixture.MakeIMSContext();
            repository = new InventoryRepository(context);
        }

        [Fact]
        public async Task GetInventoryListByName_ShouldReturnAllInventories_WhenSearchNameIsEmpty()
        {
            
            var result = await repository.GetInventoriesByName(string.Empty);
            result.Should().HaveCount(3);
        }

        [Fact]
        public async void GetInventoryListByName_ShouldReturnEmptyList_WhenInventoryNotFound()
        {

            var result = await repository.GetInventoriesByName("Nothing");
            result.Should().BeEmpty();
        }

        [Fact]
        public async void GetInventoryListByName_ShoudReturnInventories_WhenFound()
        {
            var result = await repository.GetInventoriesByName("Inventory");
            result.Should().Contain(InventoryList.Make());
        }

        [Fact]
        public async void GetInventoryListByName_ShouldReturnInventory_WhenInventoryFound()
        {
            var result = await repository.GetInventoriesByName("Inventory 1");
            result.Should().ContainSingle(x => x.Name == "Inventory 1");
        }
    }
}