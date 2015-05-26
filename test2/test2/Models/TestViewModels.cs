using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2.Models
{
    public class QuestionViewModel
    {
        public string LeftVariant { get; set; }
        public string RightVariant { get; set; }


    }

    public class TestViewModel
    {
        public IEnumerable<QuestionViewModel> Questions
        {
            get
            {
                return new List<QuestionViewModel>
                {
                    new QuestionViewModel
                    {
                        LeftVariant = "Систематический",
                        RightVariant = "Спонтанный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Структура",
                        RightVariant = "План"
                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Решение",
                        RightVariant = "Импульс"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "План",
                        RightVariant = "Импровизация"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Систематичность",
                        RightVariant = "Случайность"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Организованный",
                        RightVariant = "Импульсивный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Подготовка",
                        RightVariant = "Экспромт"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Решительный",
                        RightVariant = "Преданный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Твердый",
                        RightVariant = "Мягкосердечный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Твердый к критике",
                        RightVariant = "Доброжелательный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Приемущество",
                        RightVariant = "Удача"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Голова",
                        RightVariant = "Сердце"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Мысли",
                        RightVariant = "Чувства"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Анализировать",
                        RightVariant = "Симпатизировать"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Решительный",
                        RightVariant = "Преданный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Решительный",
                        RightVariant = "Преданный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Решительный",
                        RightVariant = "Преданный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Решительный",
                        RightVariant = "Преданный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Решительный",
                        RightVariant = "Преданный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Решительный",
                        RightVariant = "Преданный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Решительный",
                        RightVariant = "Преданный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Решительный",
                        RightVariant = "Преданный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Решительный",
                        RightVariant = "Преданный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Решительный",
                        RightVariant = "Преданный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Решительный",
                        RightVariant = "Преданный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Решительный",
                        RightVariant = "Преданный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Решительный",
                        RightVariant = "Преданный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Решительный",
                        RightVariant = "Преданный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Решительный",
                        RightVariant = "Преданный"

                    },
                };
            }
        } 
            
        
    }

    
}
