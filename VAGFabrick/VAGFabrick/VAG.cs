using System;
using System.Xml.Linq;
using System.Collections.Generic;
using VAGFabric;
using System.Windows.Forms;

namespace VAGFabric
{
    class VAG
    {
        private readonly string _name;
        private int _quantity;
        private readonly int _tankVolume;
        private readonly string _carCase;
        private double _fuelQuantity;
        private double _fuelConsumption;
        public string Name {get { return _name; }}
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public int TankVolume{get { return _tankVolume; }}
        public string CarCase{get { return _carCase; }}
        public double FuelQuantity
        {
            get { return _fuelQuantity; }
            set { _fuelQuantity = value; }
        }
        public double FuelConsumtion{get { return _fuelConsumption; }}
        public VAG(string name, int quantity, int tankVolume, string carCase, double fuelQuantity, double fuelConsumption)
        {
            _name = name;
            _quantity = quantity;
            _tankVolume = tankVolume;
            _carCase = carCase;
            _fuelQuantity = fuelQuantity;
            _fuelConsumption = fuelConsumption;
        }
        public override string ToString()
        {
            return $"[LOG] Модель: {Name}, Кол-во: {Quantity}, Объём бака={TankVolume}, Кузов: {CarCase}.";
        }
        public static void AddVagToListBox(VAG vehicle, ListBox listBox)
        {
            string displayString = vehicle.ToString();
            listBox.Items.Add(displayString);
        }
        public void AddOneUnit(ListBox listBox)
        {
            this.Quantity++;
            string logMessage = $"[LOG] На склад поступила 1 единица {this.Name}. Новое количество: {this.Quantity}.";
            listBox.Items.Add(logMessage);
        }
        public void CarDrive(ListBox listBox)
        {
            this.FuelQuantity = this.FuelQuantity - this.FuelConsumtion;
            string logMessage;
            if (this.FuelQuantity < 0 || this.FuelQuantity == 0)
            {
                logMessage = $"[LOG] В машине {this.Name} закончилось топливо!!!";
            }
            else
            {
                logMessage = $"[LOG] Машина {this.Name} проехала 100 км и израсходовала {this.FuelConsumtion}. Остаток топлива={this.FuelQuantity}.";
            }
            listBox.Items.Add(logMessage);
        }
    }
}