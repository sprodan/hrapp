using HRAPP.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRAPP.DAL.Concrete
{
    public class CompanyDAL
    {
        static public void Add(Company company)
        {
            using (Model1Container dbEntities = new Model1Container())
            {
                dbEntities.Companies.Add(company);
                dbEntities.SaveChanges();
            }
        }

        public static Company Read(int id)
        {
            using (Model1Container dbEntities = new Model1Container())
            {
                Company company = (dbEntities.Companies.Where(p => p.Id == id)).ToList().First();

                return company;
            }
        }

        public static void Update(Company company)
        {
            using (Model1Container dbEntities = new Model1Container())
            {
                Company _company = dbEntities.Companies.Find(company.Id);
                _company = company;
                dbEntities.SaveChanges();
            }
        }
    }
}

