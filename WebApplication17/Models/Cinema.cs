using System;
using System.Collections.Generic;

namespace WebApplication17.Models
{
    public partial class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
        public string Owner { get; set; }
        public int? HallNo { get; set; }
    }
}
