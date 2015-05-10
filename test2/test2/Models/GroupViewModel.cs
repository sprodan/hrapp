using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRAPP.EF;


namespace test2.Models
{
    public class GroupViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int EmployeeCount
        {
            get { return 5; }
        }
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