using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using HRAPP.EF;

namespace HRAPP.DAL.Concrete
{
    public class EmployeeDAL
    {
        #region Singleton_realization

        private static readonly Lazy<EmployeeDAL> _instance =
            new Lazy<EmployeeDAL>(() => new EmployeeDAL());

        public static EmployeeDAL Instance = _instance.Value;

        #endregion

        public void Add(Emploee employee)
        {
            using (var dbEntities = new Model1Container())
            {
                dbEntities.Emploees.Add(employee);
                dbEntities.SaveChanges();
            }
        }

        public Emploee Read(int id)
        {
            using (var dbEntities = new Model1Container())
            {
                return dbEntities.Emploees.Where(p => p.Id == id).ToList().First();
            }
        }

        public void Update(Emploee emploee)
        {
            using (var dbEntities = new Model1Container())
            {
                dbEntities.Entry(emploee).State = EntityState.Modified;
                dbEntities.SaveChanges();
            }
        }

        
    }
}
