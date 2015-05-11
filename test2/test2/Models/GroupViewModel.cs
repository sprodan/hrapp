using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using HRAPP.EF;


namespace test2.Models
{
    public class GroupViewModel
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        [Required]
        [Display(Name = "Название команды")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Кол-во человек")]
        public int EmployeeCount { get; set; }


        #region TypeConverter

        public static explicit operator GroupViewModel(Group model)
        {
            return new GroupViewModel
            {
               Id = model.Id,
               Name = model.Name
 
            };
        }

        public static implicit operator Group(GroupViewModel viewModel)
        {
            return new Group()
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                
            };
        }
        #endregion
    }
}