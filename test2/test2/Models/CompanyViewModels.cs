using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public int UserId { get; set; }

        public ICollection<GroupViewModel> Groups { get; set; }

        public ICollection<PositionViewModel> Positions { get; set;}



        public ICollection<EmployeeViewModel> Employees { get; set; }


        #region TypeConverter

        public static explicit operator CompanyViewModel(Company model)
        {
            CompanyViewModel _view = new CompanyViewModel()
            {
                Groups = new Collection<GroupViewModel>(),
                Positions = new Collection<PositionViewModel>(),
                Employees = new Collection<EmployeeViewModel>(),
                Mail = model.Mail,
                Id = model.Id,
                Name = model.Name,
                Address = model.Site,
                UserId = model.UserId
            };
            if (model.Group != null)
            {
                foreach (var _group in model.Group)
                {
                    _view.Groups.Add((GroupViewModel)_group);
                }
            }
            if (model.Positions != null)
            {
                foreach (var _position in model.Positions)
                {
                    _view.Positions.Add((PositionViewModel)_position);
                }
            }
            if (model.Employee != null)
            {
                foreach (var _employee in model.Employee)
                {
                    _view.Employees.Add((EmployeeViewModel)_employee);
                }
            }

            return _view;
        }

        public static implicit operator Company(CompanyViewModel viewModel)
        {
            if (viewModel == null) return new Company { UserId = -1 };
            Company _company = new Company()
            {
                Group = new List<Group>(),
                Mail = viewModel.Mail,
                Id = viewModel.Id,
                Name = viewModel.Name,
                Site = viewModel.Address,
                UserId = viewModel.UserId
            };
            foreach (var _group in viewModel.Groups)
            {
                _company.Group.Add(_group);
            }
            return _company;
        }
        #endregion
    }



}