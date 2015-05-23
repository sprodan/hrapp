using System.ComponentModel.DataAnnotations;

namespace hrservice.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int IdPosition { get; set; }
        public int IdGroup { get; set; }

        public bool TestPassed { get; set; }
    }

}