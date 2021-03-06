﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRAPP.DAL.Concrete;
using HRAPP.EF;

namespace HRAPP.BL.Concrete
{
    public class UserBL
    {
        public static User Create(User user)
        {
            return UserDAL.Instance.Add(user);
        }

        public static User Read(int Id)
        {

            return UserDAL.Instance.Read(Id);
        }

        public static List<User> ReadAll()
        {
            return UserDAL.Instance.ReadAll();
        }

        public static void Update(User group)
        {
            UserDAL.Instance.Update(group);
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
