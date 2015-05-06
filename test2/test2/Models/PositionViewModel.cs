using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test2.Models
{
    public class PositionViewModel
    {
        [Required]
        [Display(Name = "Название позиции")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Название позиции")]
        public int UsersCount { get; set; }

    }
}