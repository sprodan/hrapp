﻿using System;
using System.Collections.Generic;
using HRAPP.DAL.Concrete;
using HRAPP.EF;

namespace HRAPP.BL.Concrete
{
    class GroupBL
    {

        public int? Create(Group group)
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