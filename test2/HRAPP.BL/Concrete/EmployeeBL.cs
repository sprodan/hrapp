using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRAPP.DAL.Concrete;
using HRAPP.EF;

namespace HRAPP.BL.Concrete
{
    public class EmployeeBL
    {
        public static int? Create(Emploee emploee)
        {
            EmployeeDAL.Instance.Add(emploee);
            return 1;
        }

        public static Emploee Read(int Id)
        {

            return EmployeeDAL.Instance.Read(Id);
        }

        public static void Update(Emploee employee)
        {
            EmployeeDAL.Instance.Update(employee);
        }

        

        public bool Delete()
        {
            throw new NotImplementedException();
        }


        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
