namespace HouseF
{
    public class HouseFactory
    {
        private readonly Dictionary<string, Type> _houses;
        public HouseFactory()
        {
            _houses = LoadHouses();
        }
        public House CreateHouse(string houseType)
        {
            return GetHouseFromDictionary(houseType);
        }

        private static Dictionary<string, Type> LoadHouses()
        {
            Dictionary<string, Type> availableHouses = new()
            {
                { "smallhouse", typeof(SmallHouse) },
                { "mediumhouse", typeof(MediumHouse) },
                { "largehouse", typeof(LargeHouse) }
            };

            return availableHouses;
        }
        private House GetHouseFromDictionary(string house)
        {
            try
            {
                Type type = _houses[house.ToLower()];
                return (House)Activator.CreateInstance(type);
            }
            catch
            {
                throw new KeyNotFoundException($"Housetype \"{house}\" not found in factory.");
            }
        }
    }
}
