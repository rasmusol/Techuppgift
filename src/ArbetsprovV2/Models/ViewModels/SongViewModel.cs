using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArbetsprovV2.Models.ViewModels
{
    public class SongViewModel
    {

       [Display(Name ="Name of artist")]
        public string ArtistName { get; set; }
        [Display(Name = "Title of the song")]
        public string Title { get; set; }
    }
}
