using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRAPP.EF;

namespace test2.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }


        #region TypeConverter

        public static explicit operator UserViewModel(User model)
        {
            return new UserViewModel()
            {
                Id = model.Id,
                Name = model.Name,
                Password = model.Password
            };
        }

        public static implicit operator User(UserViewModel viewModel)
        {
            return new User()
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Password = viewModel.Password
            };
        }
        #endregion
    }
}
