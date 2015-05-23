﻿using System;
using System.Linq;
using HRAPP.EF;
using System.Data.Entity;

namespace HRAPP.DAL.Concrete
{
    public class UserDAL
    {

        #region Singleton_realization

        private static readonly Lazy<UserDAL> _instance =
            new Lazy<UserDAL>(() => new UserDAL());

        public static UserDAL Instance = _instance.Value;

        #endregion

        public void Add(User user)
        {
            using (var dbEntities = new Model1Container())
            {
                dbEntities.Users.Add(user);
                dbEntities.SaveChanges();
            }
        }

        public User Read(int id)
        {
            var dbEntities = new Model1Container();

            var user = dbEntities.Users.Where(p => p.Id == id).ToList().First();

            return user;

        }

        public void Update(User user)
        {
            using (var dbEntities = new Model1Container())
            {
                dbEntities.Entry(user).State = EntityState.Modified;
                dbEntities.SaveChanges();
            }
        }

    }
}