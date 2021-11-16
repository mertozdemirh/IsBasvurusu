using IsBasvurusu.Models.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsBasvurusu.Models
{
    public class HomeViewModel
    {
        public Kisi Kisi { get; set; }
        public List<SehirlerModel> sehirlerModel { get; set; }
    }
}
