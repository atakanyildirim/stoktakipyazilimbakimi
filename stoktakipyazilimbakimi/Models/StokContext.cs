﻿using stoktakipyazilimbakimi.Models;
using System.Data.Entity;

namespace stoktakipyazilimbakimi.Controllers
{
    public class StokContext:DbContext
    {
        public DbSet<Personel> Personel { get; set; }

        public StokContext() : base("StokContext")
        {
        }
    }
}