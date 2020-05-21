using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Location : ILocation
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public int ID { get; set; }
    }
}
