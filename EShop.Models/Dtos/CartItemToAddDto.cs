﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Models.Dtos
{
    public class CartItemToAddDto
    {
        public int CartItemId { get; set; } 
        public int Qty { get; set; }
    }
}
