using System.Collections.Generic;

namespace WebApplication3.Models.Interfaces
{
    public interface IHouseRepository
    {
        int AddHouse(House house);
        List<House> GetAllHouses();
        House GetHouse(int houseId);
    }
}
