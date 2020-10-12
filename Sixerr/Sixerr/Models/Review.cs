using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sixerr.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public Profile Author { get; set; }
        public Gig Gig { get; set; }
        public string Text { get; set; }
    }
}
