using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using HRAPP.EF;

namespace test2.Models
{
    public class PositionViewModel
    {

        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Название позиции")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Название позиции")]
        public int UsersCount { get; set; }

        #region TypeConverter

        public static explicit operator PositionViewModel(Position model)
        {
            return new PositionViewModel
            {
                Id = model.Id,
                Name = model.Name

            };
        }

        public static implicit operator Position(PositionViewModel viewModel)
        {
            return new Position()
            {
                Id = viewModel.Id,
                Name = viewModel.Name,

            };
        }
        #endregion

    }
}