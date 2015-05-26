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
                        LeftVariant = "Фактический",
                        RightVariant = "Теоретический"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Приминение на практике",
                        RightVariant = "Поиск скрытого смысла"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Опыт",
                        RightVariant = "Теории"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Рассудительный",
                        RightVariant = "Удивительный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Практик",
                        RightVariant = "Фантазер"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Реалист",
                        RightVariant = "Мечтатель"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Реальность",
                        RightVariant = "Перспективность"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Шумный",
                        RightVariant = "Тихий"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Оживительный",
                        RightVariant = "Спокойный"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Общительность",
                        RightVariant = "Сосредоточенность"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Расходование энергии",
                        RightVariant = "Сохранение энергии"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Ориентированный во внешний мир",
                        RightVariant = "Ориентированный внутрь себя"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Высказатхься вслух",
                        RightVariant = "Пеёреживать в себе"

                    },
                    new QuestionViewModel
                    {
                        LeftVariant = "Отважный",
                        RightVariant = "Хладнокровный"

                    },
                    
                };
            }
        } 
            
        
    }

    
}
