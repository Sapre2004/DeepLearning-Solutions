<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_DbContext.Models
=======
namespace Lab1_ORM.Models
>>>>>>> 237a21da9881cd0bdcf609dff39dedce277563cc
{
    public class Product
    {
        public int Id { get; set; }
<<<<<<< HEAD
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = new Category();
=======
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
>>>>>>> 237a21da9881cd0bdcf609dff39dedce277563cc
    }
}
