﻿using System;

namespace NET.S._2018.Zenovich._08.Hotel.DAL.Entities
{
    public class HotelEntity
    {
        public string Address { get; set; }

        public string Description { get; set; }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public double Rating { get; set; }

        public decimal StandardPricePerRoom { get; set; }
    }
}