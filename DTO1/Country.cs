using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
   public  class Country
    {
        public int CountryId { get; set; }
        //FK
        public int CurrencyId { get; set; }

        [Required]
        public string CountryName { get; set; }

        //Navigation Property
        public Currency Currency { get; set; }
    }
}
