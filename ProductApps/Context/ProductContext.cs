﻿using ProductApps.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductApps.Context
{
    public class NewContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}