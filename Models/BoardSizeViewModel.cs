using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameOfLife.Models
{
    public class BoardSizeViewModel
    {
        [Display(Name = "Length of X Axis")]
        [Range(3, 10, ErrorMessage = "Length of X axis should be between 3 and 10.")]
        [Required(ErrorMessage = "Length of X axis is required.")]
        public int LenX { get; set; }

        [Display(Name = "Length of Y Axis")]
        [Range(3, 10, ErrorMessage = "Length of Y axis should be between 3 and 10.")]
        [Required(ErrorMessage = "Length of Y axis is required.")]
        public int LenY { get; set; }
    }
}
