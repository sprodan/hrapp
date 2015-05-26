using HRAPP.EF;

namespace test2.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int IdPosition { get; set; }
        public int IdGroup { get; set; }
        public bool TestPassed { get { return true; } }
        #region TypeConverter

        public static explicit operator EmployeeViewModel(Emploee model)
        {
            return new EmployeeViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        public static implicit operator Emploee(EmployeeViewModel viewModel)
        {
            return new Emploee()
            {
                Id = viewModel.Id,
                Name = viewModel.Name
            };
        }
        #endregion
    }

}