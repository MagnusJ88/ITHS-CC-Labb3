using NUnit.Framework;
using System;

namespace HouseFB.Tests
{
    public class HouseFluentBuilderTests
    {
        private HouseBuilder _houseBuilder;
        [SetUp]
        public void SetUp()
        {
            _houseBuilder = new HouseBuilder();
        }
        [TestCase(3)]
        [TestCase(100)]
        public void SetNumberOfRooms_GivenPositiveInt_ReturnsCorrectNumber(int rooms)
        {
            House house = _houseBuilder.SetNoOfRooms(rooms).Build();
            Assert.That(house.NoOfRooms, Is.EqualTo(rooms));
            Assert.That(_houseBuilder.SetNoOfRooms(rooms), Is.TypeOf<HouseBuilder>());

        }
        [TestCase(-3)]
        public void SetNumberOfRooms_GivenNegativeInt_ThrowsArgumentException(int rooms)
        {

            Assert.Throws<ArgumentException>(() => _houseBuilder.SetNoOfRooms(rooms).Build());
        }
        [TestCase(3)]
        [TestCase(100)]
        public void SetNumberOfWindows_GivenInt_ReturnsCorrectNumber(int windows)
        {
            House house = _houseBuilder.SetNoOfWindows(windows).Build();
            Assert.That(house.NoOfWindows, Is.EqualTo(windows));
        }
        [TestCase(-3)]
        public void SetNumberOfWindows_GivenNegativeInt_ThrowsArgumentException(int windows)
        {
            Assert.Throws<ArgumentException>(() => _houseBuilder.SetNoOfWindows(windows).Build());
        }
        [TestCase(3)]
        [TestCase(100)]
        public void SetParkingSpotsInGarage_GivenInt_ReturnsCorrectNumber(int parkingSpots)
        {
            House house = _houseBuilder.SetParkingSpotsInGarage(parkingSpots).Build();
            Assert.That(house.ParkingSpotsInGarage, Is.EqualTo(parkingSpots));
        }
        [TestCase(-3)]
        public void SetParkingSpotsInGarage_GivenNegativeInt_ThrowsArgumentException(int parkingSpots)
        {
            Assert.Throws<ArgumentException>(() => _houseBuilder.SetParkingSpotsInGarage(parkingSpots).Build());
        }
        [TestCase(3)]
        public void HasGarage_GivenPositiveInt_IsTrue(int parkingSpots)
        {
            House house = _houseBuilder.SetParkingSpotsInGarage(parkingSpots).Build();
            Assert.That(house.HasGarage, Is.True);
        }
        [TestCase("Testvägen 23")]
        public void SetAdress_GivenString_ReturnsCorrectString(string adress)
        {
            House house = _houseBuilder.SetAdress(adress).Build();
            Assert.That(house.StreetAdress, Is.EqualTo(adress));
        }
        [Test]
        public void HasSwimmingPool_GivenNull_IsTrue()
        {
            House house = _houseBuilder.HasSwimmingPool().Build();
            Assert.That(house.HasSwimmingPool, Is.True);
        }
        [Test]
        public void Build_ReturnsHouse()
        {
            Assert.That(_houseBuilder.Build(), Is.TypeOf<House>());
        }
    }
}