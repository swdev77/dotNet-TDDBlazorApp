using IMS.Domain;
using IMS.Plugins.EFCore;
using Microsoft.EntityFrameworkCore;

namespace IMS.TestFixture;

public static class InventoryListFixture
{
    public static List<Inventory> MakeInventoryList() => new List<Inventory>()
                    {
                        new Inventory(1, "Inventory 1"),
                        new Inventory(2, "Inventory 2"),
                        new Inventory(3, "Inventory 3"),
                    };

}

public static class IMSContextFixture
{
    public static IMSContext MakeIMSContext()
    {
        var context = new IMSContext(new DbContextOptionsBuilder<IMSContext>().UseInMemoryDatabase("Test").Options);
        context.Inventories.AddRangeAsync(InventoryListFixture.MakeInventoryList());
        context.SaveChangesAsync();
        return context;
    }
}
