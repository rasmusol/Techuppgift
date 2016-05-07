using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc.Rendering;

namespace ArbetsprovV2.Models.ViewModels
{
    public class MoodViewModel
    {
 
            [Required]
            [Display(Name = "Name")]
            public string Name { get; set; }

            // This property will hold a state, selected by user
            [Required]
            [Display(Name = "Mood")]
            public string State { get; set; }

            // This property will hold all available states for selection
            public IEnumerable<SelectListItem> Moods { get; set; }
        }
}
