using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Lesson : BaseEntity
    {
        public required string Title { get; set; }
        public string? Description { get; set; }

    }
}
