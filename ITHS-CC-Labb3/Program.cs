using HouseFB;
using ITHS_CC_Labb3;
using House = HouseFB.House;


//House house = new House(2, 2, "Benkes gränd 4", false, 0);

//Console.WriteLine(house);

HouseBuilder houseBuilder = new HouseBuilder();
House house = houseBuilder
    .SetNoOfRooms(3)
    .SetAdress("Testgatan")
    .SetNoOfWindows(6)
    .SetParkingSpotsInGarage(2)
    .HasSwimmingPool()
    .Build();

Console.WriteLine(house.ToString());