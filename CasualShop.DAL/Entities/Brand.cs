﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CasualShop.DAL.Entities
{
    [Table("Brands_tbl")]
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Clothes> Clotheses { get; set; }
        public Brand()
        {
            Clotheses = new List<Clothes>();
        }

    }
}
