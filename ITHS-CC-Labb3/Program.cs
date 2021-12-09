using HouseFB;
using House = HouseFB.House;

HouseBuilder houseBuilder = new();
House house = houseBuilder
    .SetNoOfRooms(3)
    .SetAdress("Testgatan")
    .SetNoOfWindows(6)
    .SetParkingSpotsInGarage(2)
    .HasSwimmingPool()
    .Build();

Console.WriteLine(house.ToString());