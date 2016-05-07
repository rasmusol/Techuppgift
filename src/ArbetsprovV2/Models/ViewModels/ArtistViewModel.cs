using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArbetsprovV2.Models.ViewModels
{
    public class ArtistViewModel
    {
        [Display(Name = "Name of genre")]
        public string Name { get; set; }
      //  public string Hotness { get; set; }
    }
}
