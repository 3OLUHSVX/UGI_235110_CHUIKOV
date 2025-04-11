using System;

namespace RepairLibrary
{
    public enum RepairType
    {
        Warranty,
        Paid
    }

    public class Device
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string MalfunctionDescription { get; set; }
        public double RepairCost { get; set; }
        public string RepairmanName { get; set; }

        public readonly string SerialNumber;
        public readonly RepairType RepairType;

        public Device(string name, string manufacturer, string serialNumber,
                      RepairType repairType, string malfunctionDescription,
                      double repairCost, string repairmanName)
        {
            Name = name;
            Manufacturer = manufacturer;
            SerialNumber = serialNumber;
            RepairType = repairType;
            MalfunctionDescription = malfunctionDescription;
            RepairCost = repairCost;
            RepairmanName = repairmanName;
        }

        public virtual string[] GetInfo()
        {
            var info = new string[2];
            string repairTypeStr = RepairType == RepairType.Warranty ? "Гарантийный" : "Платный";

            info[0] = $"{Name} ({Manufacturer}), серийный номер: {SerialNumber}";
            info[1] = $"Тип ремонта: {repairTypeStr}. Неисправность: {MalfunctionDescription}. Цена: {RepairCost} руб. Мастер: {RepairmanName}";

            return info;
        }
    }
}
