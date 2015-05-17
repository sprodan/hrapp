using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRAPP.EF;
using System.Data.Entity;

namespace HRAPP.DAL.Concrete
{
    public class PositionDAL
    {
        #region Singleton_realization

        private static readonly Lazy<PositionDAL> _instance =
            new Lazy<PositionDAL>(() => new PositionDAL());

        public static PositionDAL Instance = _instance.Value;

        #endregion

        public void Add(Position position)
        {
            using (var dbEntities = new Model1Container())
            {
                dbEntities.Positions.Add(position);
                dbEntities.SaveChanges();
            }
        }

        public Position Read(int id)
        {
            var dbEntities = new Model1Container();

            var position = dbEntities.Positions.Where(p => p.Id == id).ToList().First();

            return position;

        }

        public void Update(Position position)
        {
            using (var dbEntities = new Model1Container())
            {
                dbEntities.Entry(position).State = EntityState.Modified;
                dbEntities.SaveChanges();
            }
        }

    }
}
