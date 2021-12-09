using NUnit.Framework;
using System.Collections.Generic;

namespace HouseF.Tests
{
    public class HouseFactoryTests
    {
        HouseFactory _houseFactory;
        House _smallHouse;
        House _mediumHouse;
        House _largeHouse;
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _houseFactory = new HouseFactory();
            _smallHouse = _houseFactory.CreateHouse("smallhouse");
            _mediumHouse = _houseFactory.CreateHouse("mediumhouse");
            _largeHouse = _houseFactory.CreateHouse("largehouse");
        }
        [Test]
        public void CreateHouse_GivenSmallHouse_ReturnsCorrectType()
        {
            Assert.That(_houseFactory.CreateHouse("smallhouse"), Is.TypeOf<SmallHouse>());
        }
        [Test]
        public void CreateHouse_GivenMediumHouse_ReturnsCorrectType()
        {
            Assert.That(_houseFactory.CreateHouse("mediumhouse"), Is.TypeOf<MediumHouse>());
        }
        [Test]
        public void CreateHouse_GivenLargeHouse_ReturnsCorrectType()
        {
            Assert.That(_houseFactory.CreateHouse("largehouse"), Is.TypeOf<LargeHouse>());
        }
        [TestCase("notahouse")]
        public void CreateHouse_GivenIncorrectHouse_ThrowsKeyNotFoundException(string house)
        {
            Assert.Throws<KeyNotFoundException>(() => _houseFactory.CreateHouse(house));
        }
        [Test]
        public void CreateHouse_LargeHouse_HasGarageAndPool()
        {
            Assert.That(_largeHouse.HasGarage && _largeHouse.HasSwimmingPool, Is.True);
        }
        [Test]
        public void CreateHouse_MediumHouse_HasGarageButNoPool()
        {
            Assert.That(_mediumHouse.HasGarage && !_mediumHouse.HasSwimmingPool, Is.True);
        }
        [Test]
        public void CreateHouse_SmallHouse_HasNoGarageOrPool()
        {
            Assert.That(_smallHouse.HasGarage && _smallHouse.HasSwimmingPool, Is.False);
        }
        [Test]
        public void CreateHouse_LargeHouse_NoOfRoomsIsFifteen()
        {
            Assert.That(_largeHouse.NoOfRooms, Is.EqualTo(15));
        }
        [Test]
        public void CreateHouse_LargeHouse_NoOfWindowsIsThirty()
        {
            Assert.That(_largeHouse.NoOfWindows, Is.EqualTo(30));
        }
        [Test]
        public void CreateHouse_MediumHouse_NoOfRoomsIsFour()
        {
            Assert.That(_mediumHouse.NoOfRooms, Is.EqualTo(4));
        }
        [Test]
        public void CreateHouse_LargeHouse_NoOfWindowsIsEight()
        {
            Assert.That(_mediumHouse.NoOfWindows, Is.EqualTo(8));
        }
        [Test]
        public void CreateHouse_SmallHouse_NoOfRoomsIsOne()
        {
            Assert.That(_smallHouse.NoOfRooms, Is.EqualTo(1));
        }
        [Test]
        public void CreateHouse_SmallHouse_NoOfWindowsIsThree()
        {
            Assert.That(_smallHouse.NoOfWindows, Is.EqualTo(3));
        }
        [Test]
        public void CreateHouse_LargeHouse_ParkingSpotsInGarageIsFive()
        {
            Assert.That(_largeHouse.ParkingSpotsInGarage, Is.EqualTo(5));
        }
        [Test]
        public void CreateHouse_MediumHouse_ParkingSpotsInGarageIsOne()
        {
            Assert.That(_mediumHouse.ParkingSpotsInGarage, Is.EqualTo(1));
        }
    }
}