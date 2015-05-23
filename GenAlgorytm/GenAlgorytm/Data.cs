using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenAlgorytm
{
    public class Data
    {
        public List<PersonModel> GetPersons()
        {
            return new List<PersonModel>
            {
                new PersonModel {Id = 1, Name = "Stas", TestPassed = true,
                    CaracteristicList = new List<CaracteristicModel>
                    {
                        new CaracteristicModel
                        {
                            Id = 0,
                            Name = "Проницательность",
                            Value = 0.8
                        },
                        new CaracteristicModel
                        {
                            Id = 1,
                            Name = "Внимательность",
                            Value = 9
                        }
                    }
                }, 
                new PersonModel {Id = 2, Name = "Ann", TestPassed = true,
                    CaracteristicList = new List<CaracteristicModel>
                    {
                           new CaracteristicModel
                        {
                            Id = 0,
                            Name = "Проницательность",
                            Value = 4
                        },
                        new CaracteristicModel
                        {
                            Id = 1,
                            Name = "Внимательность",
                            Value = 2
                        }
                    }
                }
            };
        }

        public List<CriterionModel> GetCriterias()
        {
            return new List<CriterionModel>
            {
                new CriterionModel
                {
                    Id = 1,
                    Name = "Профессиональное обучение"
                },
                new CriterionModel
                {
                    Id = 2,
                    Name = "Треннинг"
                },
                new CriterionModel
                {
                    Id = 3,
                    Name = "Теннис"
                }
            };
        }

        public List<FactorModel> GetFactors()
        {
            return new List<FactorModel>
            {
                new FactorModel
                {
                    Id = 1,
                    Name = "Обучение"

                }
            };
        }
    }
}
