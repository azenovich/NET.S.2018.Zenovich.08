﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET.S._2018.Zenovich._08.Hotel.BLL.DTO;

namespace NET.S._2018.Zenovich._08.Hotel.BLL.Infrastructure.API
{
    public abstract class HotelDtoEquatable<T> : IHotelDTOEquatable
    {
        private T _value;

        public HotelDtoEquatable(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            _value = value;
        }

        protected T Value
        {
            get { return _value; }
        }

        public abstract bool Equals(HotelDto hotelDTO);
    }
}
