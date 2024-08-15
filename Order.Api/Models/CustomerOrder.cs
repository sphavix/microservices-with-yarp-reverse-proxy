using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Api.Models
{
    public record CustomerOrder(int id, string customerName, string productName);
}