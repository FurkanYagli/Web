﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime GuncellenmeTarihi { get; set; }
    }
}