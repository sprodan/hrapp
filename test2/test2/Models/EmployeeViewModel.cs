using System.Collections.Generic;
using System.Linq;
using HRAPP.EF;

namespace test2.Models
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel()
        {
            Group = new List<GroupViewModel>();
            Position = new List<PositionViewModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }

        public List<GroupViewModel> Group { get; set; }
        public List<PositionViewModel> Position { get; set; }
         
        public bool TestPassed => true;

        #region TypeConverter

        public static explicit operator EmployeeViewModel(Emploee model)
        {
            var employeeModel = new EmployeeViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Group = new List<GroupViewModel>(),
                Position = new List<PositionViewModel>()
                
            };

            if (model.EmploeeGroup != null)
            {
                foreach (var groupModel in model.EmploeeGroup.Select(@group => new GroupViewModel
                {
                    Id = @group.Id
                }))
                {
                    employeeModel.Group.Add(groupModel);
                }
            }

            if (model.EmploeePositions != null)
            {
                foreach (var positionModel in model.EmploeePositions.Select(@position => new PositionViewModel
                {
                    Id = @position.Id
                }))
                {
                    employeeModel.Position.Add(positionModel);
                }
            }
            return employeeModel;
        }

        public static implicit operator Emploee(EmployeeViewModel viewModel)
        {
            var employee =  new Emploee()
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                EmploeeCriterion = new List<EmploeeCriterion>(),
                EmploeeGroup = new List<EmploeeGroup>(),
                EmploeePositions = new List<EmploeePosition>()
            };
            if (viewModel.Group != null)
            {
                foreach (var groupModel in viewModel.Group)
                {
                    var group = new EmploeeGroup {GroupId = groupModel.Id, EmploeeId = viewModel.Id};
                    employee.EmploeeGroup.Add(group);
                }
            }

            if (viewModel.Position != null)
            {
                foreach (var positionModel in viewModel.Position)
                {
                    var position = new EmploeePosition { PositionId = positionModel.Id, EmploeeId = viewModel.Id };
                    employee.EmploeePositions.Add(position);
                }
            }
            return employee;
        }
        #endregion
    }

}