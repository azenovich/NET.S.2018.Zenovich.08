﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NET.S._2018.Zenovich._08.Hotel.BLL.DTO;

namespace NET.S._2018.Zenovich._08.Hotel.BLL.Infrastructure.API
{
    public interface IArrayUtils
    {
        void BubbleSort<T>(T[] items, IReflectorUtils reflectorUtils);

        HotelDto FindByTag(HotelDto[] hotelDTOs, IHotelDTOEquatable equatable);
    }
}
