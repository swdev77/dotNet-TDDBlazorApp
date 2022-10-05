﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Domain;

public record Inventory(int Id, string Name, int Quantity, decimal Price)
{
}
