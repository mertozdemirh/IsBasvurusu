using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IsBasvurusu.Models.entity
{
    public class Kisi
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Ad { get; set; }
        [Required, MaxLength(50)]
        public string Soyad { get; set; }
        public ICollection<Sehir> Sehirler { get; set; }
    }
}
