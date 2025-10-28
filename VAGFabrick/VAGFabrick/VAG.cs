using System.Windows.Forms;

namespace VAGFabric
{
    public class VAG
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int TankVolume { get; set; }
        public string CarCase { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public VAG() { }

        public VAG(string name, int quantity, int tankVolume, string carCase, double fuelQuantity, double fuelConsumption)
        {
            Name = name;
            Quantity = quantity;
            TankVolume = tankVolume;
            CarCase = carCase;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
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
            this.FuelQuantity = this.FuelQuantity - this.FuelConsumption;
            string logMessage;
            if (this.FuelQuantity <= 0)
            {
                logMessage = $"[LOG] В машине {this.Name} закончилось топливо!!!";
            }
            else
            {
                logMessage = $"[LOG] Машина {this.Name} проехала 100 км и израсходовала {this.FuelConsumption}. Остаток топлива={this.FuelQuantity}.";
            }
            listBox.Items.Add(logMessage);
        }
    }
}