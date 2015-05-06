using System;
using System.Collections.Generic;
using HRAPP.DAL.Concrete;
using HRAPP.EF;

namespace HRAPP.BL.Concrete
{
    public class CompanyBL
    {
        public int? Create()
        {
            throw new NotImplementedException();
        }
        public int? Create(Company company)
        {
            CompanyDAL.Add(company);
            return 1;
        }

        public IEnumerable<Company> Read()
        {
            throw new NotImplementedException();
        }
        public static Company Read(int Id)
        {
            return CompanyDAL.Read(Id);
        }

        public static void Update(Company company)
        {
            CompanyDAL.Update(company);
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
