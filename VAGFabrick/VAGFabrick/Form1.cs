using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using VAGFabric;
using System.Diagnostics;

namespace VAGFabric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SeedData();
        }

        private void SeedData()
        {
            using (var db = new ApplicationDbContext())
            {
                if (db.Volkswagen.Any() || db.AUDI.Any())
                {
                    return;
                }

                var volkswagens = new List<Volkswagen>
                {
                    new Volkswagen("Volkswagen Touareg", 300, 116, "Кроссовер", 116, 10.9),
                    new Volkswagen("Volkswagen Passat", 1200, 59, "Универсал", 59, 7.6),
                    new Volkswagen("Volkswagen Polo", 900, 55, "Седан", 55, 7),
                    new Volkswagen("Volkswagen Arteon", 500, 80, "Лифтбэк", 80, 8.5),
                    new Volkswagen("Volkswagen Tiguan", 800, 63, "Кроссовер", 63, 7.5),
                    new Volkswagen("Volkswagen Golf", 1500, 50, "Хэтчбэк", 50, 6.3),
                };
                var audis = new List<AUDI>{
                    new AUDI("AUDI A3", 1100, 50, "Хэтчбэк", 50, 5.7),
                    new AUDI("AUDI A4", 100, 54, "Седан", 54, 7.1),
                    new AUDI("AUDI A5", 500, 54, "Купе", 54, 7.6),
                    new AUDI("AUDI A6", 400, 87, "Универсал", 87, 8.2),
                    new AUDI("AUDI A7", 1000, 75, "Лифтбэк", 75, 7.2),
                    new AUDI("AUDI A8", 1600, 90, "Седан", 90, 9.5),
                    new AUDI("AUDI Q3", 1300, 60, "Хэтчбэк", 60, 7.3),
                    new AUDI("AUDI Q5", 1400, 65, "Кроссовер", 65, 9.1),
                    new AUDI("AUDI Q6", 1800, 74, "Кроссовер", 74, 10.3),
                    new AUDI("AUDI Q7", 1200, 100, "Кроссовер", 100, 9),
                    new AUDI("AUDI Q8", 1000, 85, "Кроссовер", 85, 9.2),
                };

                db.Volkswagen.AddRange(volkswagens);
                db.AUDI.AddRange(audis);
                db.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedCarName = comboBox1.Text;
            if (string.IsNullOrEmpty(selectedCarName))
            {
                listBox1.Items.Add("[LOG] Вы не выбрали технику для показа информации!");
                return;
            }

            using (var db = new ApplicationDbContext())
            {
                VAG vehicle = null;

                if (selectedCarName.Contains("AUDI"))
                {
                    vehicle = db.AUDI.FirstOrDefault(a => a.Name == selectedCarName);
                }
                else
                {
                    vehicle = db.Volkswagen.FirstOrDefault(v => v.Name == selectedCarName);
                }

                if (vehicle != null)
                {
                    VAG.AddVagToListBox(vehicle, listBox1);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedCarName = comboBox2.Text;
            if (string.IsNullOrEmpty(selectedCarName))
            {
                listBox1.Items.Add("[LOG] Вы не выбрали технику для производства!");
                return;
            }

            using (var db = new ApplicationDbContext())
            {
                VAG vehicle = null;

                if (selectedCarName.Contains("AUDI"))
                {
                    vehicle = db.AUDI.FirstOrDefault(a => a.Name == selectedCarName);
                }
                else
                {
                    vehicle = db.Volkswagen.FirstOrDefault(v => v.Name == selectedCarName);
                }

                if (vehicle != null)
                {
                    vehicle.Quantity++;
                    db.SaveChanges();
                    listBox1.Items.Add($"[LOG] На склад поступила 1 единица {vehicle.Name}. Новое количество: {vehicle.Quantity}.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selectedCarName = comboBox3.Text;
            if (string.IsNullOrEmpty(selectedCarName)) return;

            using (var db = new ApplicationDbContext())
            {
                VAG vehicle = null;

                if (selectedCarName.Contains("AUDI"))
                {
                    vehicle = db.AUDI.FirstOrDefault(a => a.Name == selectedCarName);
                }
                else
                {
                    vehicle = db.Volkswagen.FirstOrDefault(v => v.Name == selectedCarName);
                }

                if (vehicle != null)
                {
                    vehicle.CarDrive(listBox1);
                    db.Update(vehicle);
                    db.SaveChanges();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}