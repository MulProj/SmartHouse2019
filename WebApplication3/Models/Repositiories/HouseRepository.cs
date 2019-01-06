﻿using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication3.Models.Database;
using WebApplication3.Models.Interfaces;

namespace WebApplication3.Models.Repositiories
{
    public class HouseRepository : IHouseRepository
    {
        private readonly DatabaseContext _databaseContext;
        public HouseRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public int AddHouse(House house)
        {
            if (house == null)
            {
                throw new Exception("House object cannot be null");
            }

            _databaseContext.Houses.Add(house);
            _databaseContext.SaveChanges();

            return house.HouseId;
        }

        public List<House> GetAllHouses()
        {
            return _databaseContext.Houses.ToList();
        }

        public House GetHouse(int houseId)
        {
            if (houseId <= 0)
            {
                throw new Exception("Id cannot be less than 0");
            }

            return _databaseContext.Houses.FirstOrDefault(house => house.HouseId == houseId);
        }
    }
}
