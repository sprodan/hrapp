using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace test2.Models
{
    public class CompanyViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Название компании")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Почта компании")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Сайт")]
        public string Address { get; set; }

        // тут должны быть групы а не стринги
        // стинги тип заглушка
        public IEnumerable<string> Groups { get; set; }
    }

}