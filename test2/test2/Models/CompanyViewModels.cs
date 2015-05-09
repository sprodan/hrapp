using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HRAPP.EF;

namespace test2.Models
{
    public class CompanyViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Название компании")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Сайт")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Почта компании")]
        public string Mail { get; set; }

        public ICollection<GroupViewModel> Groups =>  new List<GroupViewModel>
            {
                new GroupViewModel {Name = "Компания 1"},
                new GroupViewModel { Name = "Компания 2"},
                new GroupViewModel { Name = "Компания 3"},
                new GroupViewModel { Name = "Компания 4"},
                new GroupViewModel { Name = "Компания 5"},

            };

        public IEnumerable<PositionViewModel> Positions { get; set; }

        #region TypeConverter

        public static explicit operator CompanyViewModel(Company model)
        {
            return new CompanyViewModel()
            {
                //Groups = model.Group,
                Mail = model.Mail,
                Id = model.Id,
                Name = model.Name,
                Address = model.Site
            };
        }

        public static implicit operator Company(CompanyViewModel viewModel)
        {
            return new Company()
            {
                //Group = viewModel.Groups,
                Mail = viewModel.Mail,
                Id = viewModel.Id,
                Name = viewModel.Name,
                Site = viewModel.Address
            };
        }
        #endregion
    }

   

}