using System;
using System.Collections.Generic;

namespace DTO
{
    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Rate { get; set; }
        public ICollection<Country> Countries { get; set; }
    }
}
