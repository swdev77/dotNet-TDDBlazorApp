using IMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Plugins.EFCore;

public static class InventoryList
{
    public static List<Inventory> Make() =>
        new() {
            new Inventory(1, "Gas Engine", 1, 1000),
            new Inventory(2, "Body", 2, 500),
            new Inventory(3, "Seat", 10, 50),
            new Inventory(4, "Wheel", 5, 200), 
            new Inventory(5, "Electric Engine", 2, 8000), 
            new Inventory(6, "Battery", 5, 400), 
        };
}
