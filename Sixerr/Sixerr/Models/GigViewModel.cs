using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sixerr.Models
{
    public class GigViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public uint Price { get; set; }
        public string Photo { get; set; }
        public bool Status { get; set; }
        public Profile User { get; set; }
        public CategoriesEnum Category { get; set; }
        public IFormFile GigImage { get; set; }
    }
}
