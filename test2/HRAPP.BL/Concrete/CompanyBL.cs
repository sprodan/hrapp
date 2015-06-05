using System;
using System.Collections.Generic;
using HRAPP.DAL.Concrete;
using HRAPP.EF;

namespace HRAPP.BL.Concrete
{
    public class CompanyBL
    {
        public static int? Create(User user)
        {
            var company = new Company
            {
                UserId = user.Id,
                Name = "",
                Mail = ""
            };
            CompanyDAL.Instance.Add(company);
            return 1;
        }

        public IEnumerable<Company> Read()
        {
            throw new NotImplementedException();
        }

        public static Company Read(int Id)
        {
            
            return CompanyDAL.Instance.Read(Id);
        }

        public static void Update(Company company)
        {
            CompanyDAL.Instance.Update(company);
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
