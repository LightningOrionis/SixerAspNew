using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Sixerr.Models
{
    public class Profile
    {
        [Key]
        public uint Id { get; set; }
        public IdentityUser User { get; set; }
        // Not sure, it must be file, but i dont know now
        public string Avatar { get; set; }
        public string About { get; set; }
    }
}
