using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Sixerr.Models
{
    public class Gig
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public uint Price { get; set; }
        // Not sure, it must be file, but i dont know now
        public string Photo { get; set; }
        public bool Status { get; set; }
        public DateTime CreateTime { get; set; }
        public Profile User { get; set; }
        public CategoriesEnum Category { get; set; }
    }

    public enum CategoriesEnum
    {
        GraphicsAndDesign = 1,
        Marketing,
        Videoprocessing,
        MusicAndAudio,
        IT
    }
}
