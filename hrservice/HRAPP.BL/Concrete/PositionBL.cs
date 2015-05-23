using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRAPP.DAL.Concrete;
using HRAPP.EF;

namespace HRAPP.BL.Concrete
{
    class PositionBL
    {
        public static int? Create(Position position)
        {
            PositionDAL.Instance.Add(position);
            return 1;
        }

        public static Position Read(int Id)
        {

            return PositionDAL.Instance.Read(Id);
        }

        public static void Update(Position group)
        {
            PositionDAL.Instance.Update(group);
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
