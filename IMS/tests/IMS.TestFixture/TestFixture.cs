using IMS.Domain;
using IMS.Plugins.EFCore;
using Microsoft.EntityFrameworkCore;

namespace IMS.TestFixture;

public static class IMSContextFixture
{
    public static IMSContext MakeIMSContext()
    {
        var context = new IMSContext(new DbContextOptionsBuilder<IMSContext>().UseInMemoryDatabase("Test").Options);
        context.Inventories.AddRangeAsync(InventoryList.Make());
        context.SaveChangesAsync();
        return context;
    }
}
