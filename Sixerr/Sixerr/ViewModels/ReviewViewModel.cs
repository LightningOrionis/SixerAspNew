﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sixerr.ViewModels
{
    public class ReviewViewModel
    {
        [Required]
        public string Text { get; set; }
    }
}
