﻿using System.Collections.Generic;

namespace NET.S._2018.Zenovich._08.Hotel.FileSystem.API
{
    public interface IDataAccessObject<T>
    {
        List<T> GetEntities();

        void PostEntities(List<T> entities);
    }
}