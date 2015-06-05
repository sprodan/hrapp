using System;
using System.Collections.Generic;
using HRAPP.DAL.Concrete;
using HRAPP.EF;

namespace HRAPP.BL.Concrete
{
    public class GroupBL
    {

        public static int? Create(Group group)
        {
            GroupDAL.Instance.Add(group);
            return 1;
        }

        public static Group Read(int Id)
        {

            return GroupDAL.Instance.Read(Id);
        }

        public static void Update(Group group)
        {
            GroupDAL.Instance.Update(group);
        }

        public static IEnumerable<Group> ReadByCompany(int companyId)
        {
            return GroupDAL.Instance.ReadByCompany(companyId);
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
