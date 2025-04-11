using NUnit.Framework;
using RepairLibrary;

namespace RepairLibrary.UnitTests
{
    [TestFixture]
    public class DeviceUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var device = CreateTestDevice();

            Assert.That(device.Name, Is.EqualTo("Microwave"));
            Assert.That(device.Manufacturer, Is.EqualTo("Samsung"));
            Assert.That(device.SerialNumber, Is.EqualTo("SN123456"));
            Assert.That(device.RepairType, Is.EqualTo(RepairType.Paid));
            Assert.That(device.MalfunctionDescription, Is.EqualTo("Не греет"));
            Assert.That(device.RepairCost, Is.EqualTo(2500.0));
            Assert.That(device.RepairmanName, Is.EqualTo("Иванов И.И."));
        }

        [Test]
        public void GetInfoTest()
        {
            var device = CreateTestDevice();
            var info = device.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("Microwave (Samsung), серийный номер: SN123456"));
            Assert.That(info[1], Is.EqualTo("Тип ремонта: Платный. Неисправность: Не греет. Цена: 2500 руб. Мастер: Иванов И.И."));
        }

        private Device CreateTestDevice()
        {
            return new Device("Microwave", "Samsung", "SN123456", RepairType.Paid, "Не греет", 2500.0, "Иванов И.И.");
        }
    }
}
