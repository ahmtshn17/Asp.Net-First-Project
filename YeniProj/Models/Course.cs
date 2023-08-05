using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YeniProj.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string?  Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }

        public string[]? Tags { get; set; }
        public bool IsActive { get; set; }
        public bool IsHome { get; set; }
    }
}