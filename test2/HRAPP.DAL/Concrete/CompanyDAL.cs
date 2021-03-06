﻿using System;
using HRAPP.EF;
using System.Data.Entity;
using System.Linq;

namespace HRAPP.DAL.Concrete
{
    public class CompanyDAL
    {

        #region Singleton_realization

        private static readonly Lazy<CompanyDAL> _instance =
            new Lazy<CompanyDAL>(() => new CompanyDAL());

        public static CompanyDAL Instance = _instance.Value;

        #endregion

        public Company Add(Company company)
        {
            using (var dbEntities = new Model1Container())
            {
                dbEntities.Companies.Add(company);
                dbEntities.SaveChanges();
                return company;
            }
        }

        public Company Read(int id)
        {
            var dbEntities = new Model1Container();

            var company = new Company();
            try
            {
                company = dbEntities.Companies.First(p => p.UserId == id);
            }
            catch
            {
                return null;
            }

            return company;

        }

        public void Update(Company company)
        {
            using (var dbEntities = new Model1Container())
            {
                dbEntities.Entry(company).State = EntityState.Modified;
                dbEntities.SaveChanges();
            }
        }
    }
}

