using System;
using HRAPP.EF;
using System.Data.Entity;
using System.Linq;

namespace HRAPP.DAL.Concrete
{
    public class GroupDAL
    {
        #region Singleton_realization

        private static readonly Lazy<GroupDAL> _instance =
            new Lazy<GroupDAL>(() => new GroupDAL());

        public static GroupDAL Instance = _instance.Value;

        #endregion

        public void Add(Group group)
        {
            using (var dbEntities = new Model1Container())
            {
                dbEntities.Groups.Add(group);
                dbEntities.SaveChanges();
            }
        }

        public Group Read(int id)
        {
            var dbEntities = new Model1Container();

            var group = dbEntities.Groups.Where(p => p.Id == id).ToList().First();

            return group;

        }

        public void Update(Group group)
        {
            using (var dbEntities = new Model1Container())
            {
                dbEntities.Entry(group).State = EntityState.Modified;
                dbEntities.SaveChanges();
            }
        }
    }
}
