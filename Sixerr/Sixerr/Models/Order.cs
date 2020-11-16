using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sixerr.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Profile Executor { get; set; }
        public Profile Orderer { get; set; }
    }
}
