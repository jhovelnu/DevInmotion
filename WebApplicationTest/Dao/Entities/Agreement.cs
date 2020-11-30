using System;
using System.Collections.Generic;

#nullable disable

namespace Dao.Entities
{
    public partial class Agreement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
    }
}
