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

        public ICollection<GroupViewModel> Groups
        {
            get
            {
                return new List<GroupViewModel>
        {
            new GroupViewModel {Name = "Компания 1", Id = 1},
            new GroupViewModel { Name = "Компания 2", Id = 2},
            new GroupViewModel { Name = "Компания 3", Id = 3},
            new GroupViewModel { Name = "Компания 4", Id = 4},
            new GroupViewModel { Name = "Компания 5", Id = 5},

        };
            }
        } 

        public IEnumerable<PositionViewModel> Positions
        {
            get
            {
                return new List<PositionViewModel>
                {
                    new PositionViewModel {Name = ".net Dev", UsersCount = 10, Id = 1},
                    new PositionViewModel {Name = "php Dev", UsersCount = 12, Id = 2},
                    new PositionViewModel {Name = "front-end dev", UsersCount = 30, Id = 3},
                    new PositionViewModel {Name = "designer", UsersCount = 5, Id = 4},

                };
            }
        }



        public IEnumerable<EmployeeViewModel> Employees
        {
            get
            {
                return new List<EmployeeViewModel>
                {
                    new EmployeeViewModel {Name = "Иванов Иван", IdGroup = 1, IdPosition = 1, TestPassed = true},
                    new EmployeeViewModel {Name = "Николаев Николай", IdGroup = 1, IdPosition = 2},
                    new EmployeeViewModel {Name = "Евгений Евгеньевич", IdGroup = 1, IdPosition = 3, TestPassed = true},
                    new EmployeeViewModel {Name = "Светлана Сватовна", IdGroup = 1, IdPosition = 4, TestPassed = true},
                    new EmployeeViewModel {Name = "Денис Денисов", IdGroup = 1, IdPosition = 1},
                    new EmployeeViewModel {Name = "Анна Ановна", IdGroup = 2, IdPosition = 2},
                };
            }
        }


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