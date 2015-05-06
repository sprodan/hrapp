using HRAPP.EF;
using System.Data.Entity;
using System.Linq;

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
            Model1Container dbEntities = new Model1Container();

            var company = dbEntities.Companies.Where(p => p.Id == id).ToList().First();

            return company;

        }

        public static void Update(Company company)
        {
            using (Model1Container dbEntities = new Model1Container())
            {
                dbEntities.Entry(company).State = EntityState.Modified;
                dbEntities.SaveChanges();
            }
        }
    }
}

