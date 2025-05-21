using RepairServices;

namespace RepaireService.UnitTests
{
    [TestFixture]
    public class DeviceTests
    {
        [Test]
        public void Device_Creation_Test()
        {
            // Создаем устройство
            var device = new Device("Холодильник", "Samsung", "SN-12345");

            // Проверяем, что поля заполнены
            Assert.AreEqual("Холодильник", device.Name);
            Assert.AreEqual("Samsung", device.Manufacturer);
            Assert.AreEqual("SN-12345", device.SerialNumber);
        }

        [Test]
        public void GetInfo_Returns_Correct_Data()
        {
            // Создаем и настраиваем устройство
            var device = new Device("Стиральная машина", "LG", "SN-67890")
            {
                RepairType = RepairType.Paid,
                FaultDescription = "Не сливает воду",
                RepairCost = 4500m,
                TechnicianFullName = "Петров А.С."
            };

            // Получаем информацию
            var info = device.GetInfo();

            // Проверяем результат
            StringAssert.Contains("LG", info[0]);  // Производитель в первой строке
            StringAssert.Contains("Не сливает воду", info[1]);  // Описание во второй строке
        }
    }
}