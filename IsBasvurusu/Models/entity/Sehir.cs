using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IsBasvurusu.Models.entity
{
    public class Sehir
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Ad { get; set; }
        public ICollection<Kisi> Kisiler { get; set; }
    }
}
