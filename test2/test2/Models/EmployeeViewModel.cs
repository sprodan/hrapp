using System.Collections.Generic;
using System.Linq;
using HRAPP.EF;

namespace test2.Models
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel()
        {
            GroupId = new List<int>();
            PositionId = new List<int>();
        }

        public int Id { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }

        public List<int> GroupId { get; set; }
        public List<int> PositionId { get; set; }
         
        public bool TestPassed => true;

        #region TypeConverter

        public static explicit operator EmployeeViewModel(Emploee model)
        {
            var employeeModel = new EmployeeViewModel
            {
                Id = model.Id,
                Name = model.Name,
                LastName = model.LastName,
                GroupId = new List<int>(),
                PositionId = new List<int>()
                
            };

            if (model.EmploeeGroup != null)
            {
                foreach (var groupModel in model.EmploeeGroup.Select(@group => new GroupViewModel
                {
                    Id = @group.Id
                }))
                {
                    employeeModel.GroupId.Add(groupModel.Id);
                }
            }

            if (model.EmploeePositions != null)
            {
                foreach (var positionModel in model.EmploeePositions.Select(@position => new PositionViewModel
                {
                    Id = @position.Id
                }))
                {
                    employeeModel.PositionId.Add(positionModel.Id);
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
                LastName = viewModel.LastName,
                EmploeeCriterion = new List<EmploeeCriterion>(),
                EmploeeGroup = new List<EmploeeGroup>(),
                EmploeePositions = new List<EmploeePosition>()
            };
            if (viewModel.GroupId != null)
            {
                foreach (var groupId in viewModel.GroupId)
                {
                    var group = new EmploeeGroup {GroupId = groupId, EmploeeId = viewModel.Id};
                    employee.EmploeeGroup.Add(group);
                }
            }

            if (viewModel.PositionId != null)
            {
                foreach (var positionId in viewModel.PositionId)
                {
                    var position = new EmploeePosition { PositionId = positionId, EmploeeId = viewModel.Id };
                    employee.EmploeePositions.Add(position);
                }
            }
            return employee;
        }
        #endregion
    }

}