using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Domain;
using IMS.Plugins.EFCore;
using IMS.TestFixture;
using IMS.UseCases;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Tests;

public class ViewInventoriesUseCaseTests
{
    private readonly IMSContext context;
    private readonly IInventoryRepository repository;
    private readonly ViewInventoriesUseCase useCase;

    public ViewInventoriesUseCaseTests()
    {
        context = IMSContextFixture.MakeIMSContext();
        repository = new InventoryRepository(context);
        
        useCase = new ViewInventoriesUseCase(repository);
    }

    [Fact]
    public async void ShouldReturnAllInvetories_WhenSearchNameIsEmpty()
    {
        var result = await useCase.ExecuteAsynce(string.Empty);
        result.Should().HaveCount(InventoryList.Make().Count());
    }

    [Fact]
    public async void ShouldReturnEmptyList_WhenInventoryNotFound()
    {
        var result = await useCase.ExecuteAsynce("Nothing");
        result.Should().BeEmpty();
    }

    [Fact]
    public async void ShouldReturnInventory_WhenSearchNameIsValid()
    {
        var result = await useCase.ExecuteAsynce("Engine");
        result.Should().ContainSingle(x => x.Name == "Engine");
    }
}

