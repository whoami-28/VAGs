using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VAGFabric;

namespace VAGFabric
{
    public partial class Form1 : Form
    {
        private List<Volkswagen> volkswagens;
        private List<AUDI> AUDIs;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            volkswagens = new List<Volkswagen>{
                new Volkswagen("Volkswagen Touareg", 300, 116, "Кроссовер", 116, 10.9),
                new Volkswagen("Volkswagen Passat", 1200, 59, "Универсал", 59, 7.6),
                new Volkswagen("Volkswagen Polo", 900, 55, "Седан", 55, 7),
                new Volkswagen("Volkswagen Arteon", 500, 80, "Лифтбэк", 80, 8.5),
                new Volkswagen("Volkswagen Tiguan", 800, 63, "Кроссовер", 63, 7.5),
                new Volkswagen("Volkswagen Golf", 1500, 50, "Хэтчбэк", 50, 6.3),
            };
            AUDIs = new List<AUDI>{
                new AUDI("A3", 1100, 50, "Хэтчбэк", 50, 5.7),
                new AUDI("A4", 100, 54, "Седан", 54, 7.1),
                new AUDI("A5", 500, 54, "Купе", 54, 7.6),
                new AUDI("A6", 400, 87, "Универсал", 87, 8.2),
                new AUDI("A7", 1000, 75, "Лифтбэк", 75, 7.2),
                new AUDI("A8", 1600, 90, "Седан", 90, 9.5),
                new AUDI("Q3", 1300, 60, "Хэтчбэк", 60, 7.3),
                new AUDI("Q5", 1400, 65, "Кроссовер", 65, 9.1),
                new AUDI("Q6", 1800, 74, "Кроссовер", 74, 10.3),
                new AUDI("Q7", 1200, 100, "Кроссовер", 100, 9),
                new AUDI("Q8", 1000, 85, "Кроссовер", 85, 9.2),
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Volkswagen Touareg":
                    volkswagens[0].AddOneUnit(listBox1);
                    break;
                case "Volkswagen Passat":
                    volkswagens[1].AddOneUnit(listBox1);
                    break;
                case "Volkswagen Polo":
                    volkswagens[2].AddOneUnit(listBox1);
                    break;
                case "Volkswagen Arteon":
                    volkswagens[3].AddOneUnit(listBox1);
                    break;
                case "Volkswagen Tiguan":
                    volkswagens[4].AddOneUnit(listBox1);
                    break;
                case "Volkswagen Golf":
                    volkswagens[5].AddOneUnit(listBox1);
                    break;
                case "AUDI A3":
                    AUDIs[0].AddOneUnit(listBox1);
                    break;
                case "AUDI A4":
                    AUDIs[1].AddOneUnit(listBox1);
                    break;
                case "AUDI A5":
                    AUDIs[2].AddOneUnit(listBox1);
                    break;
                case "AUDI A6":
                    AUDIs[3].AddOneUnit(listBox1);
                    break;
                case "AUDI A7":
                    AUDIs[4].AddOneUnit(listBox1);
                    break;
                case "AUDI A8":
                    AUDIs[5].AddOneUnit(listBox1);
                    break;
                case "AUDI Q3":
                    AUDIs[6].AddOneUnit(listBox1);
                    break;
                case "AUDI Q5":
                    AUDIs[7].AddOneUnit(listBox1);
                    break;
                case "AUDI Q6":
                    AUDIs[8].AddOneUnit(listBox1);
                    break;
                case "AUDI Q7":
                    AUDIs[9].AddOneUnit(listBox1);
                    break;
                case "AUDI Q8":
                    AUDIs[10].AddOneUnit(listBox1);
                    break;
                default:
                    listBox1.Items.Add("[LOG] Вы не выбрали технику для производства!");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Volkswagen Touareg":
                    VAG.AddVagToListBox(volkswagens[0], listBox1);
                    break;
                case "Volkswagen Passat":
                    VAG.AddVagToListBox(volkswagens[1], listBox1);
                    break;
                case "Volkswagen Polo":
                    VAG.AddVagToListBox(volkswagens[2], listBox1);
                    break;
                case "Volkswagen Arteon":
                    VAG.AddVagToListBox(volkswagens[3], listBox1);
                    break;
                case "Volkswagen Tiguan":
                    VAG.AddVagToListBox(volkswagens[4], listBox1);
                    break;
                case "Volkswagen Golf":
                    VAG.AddVagToListBox(volkswagens[5], listBox1);
                    break;
                case "AUDI A3":
                    VAG.AddVagToListBox(AUDIs[0], listBox1);
                    break;
                case "AUDI A4":
                    VAG.AddVagToListBox(AUDIs[1], listBox1);
                    break;
                case "AUDI A5":
                    VAG.AddVagToListBox(AUDIs[2], listBox1);
                    break;
                case "AUDI A6":
                    VAG.AddVagToListBox(AUDIs[3], listBox1);
                    break;
                case "AUDI A7":
                    VAG.AddVagToListBox(AUDIs[4], listBox1);
                    break;
                case "AUDI A8":
                    VAG.AddVagToListBox(AUDIs[5], listBox1);
                    break;
                case "AUDI Q3":
                    VAG.AddVagToListBox(AUDIs[6], listBox1);
                    break;
                case "AUDI Q5":
                    VAG.AddVagToListBox(AUDIs[7], listBox1);
                    break;
                case "AUDI Q6":
                    VAG.AddVagToListBox(AUDIs[8], listBox1);
                    break;
                case "AUDI Q7":
                    VAG.AddVagToListBox(AUDIs[9], listBox1);
                    break;
                case "AUDI Q8":
                    VAG.AddVagToListBox(AUDIs[10], listBox1);
                    break;
                default:
                    listBox1.Items.Add("[LOG] Вы не выбрали технику для показа информации!");
                    break;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (comboBox3.Text)
            {
                case "Volkswagen Touareg":
                    volkswagens[0].CarDrive(listBox1);
                    break;
                case "Volkswagen Passat":
                    volkswagens[1].CarDrive(listBox1);
                    break;
                case "Volkswagen Polo":
                    volkswagens[2].CarDrive(listBox1);
                    break;
                case "Volkswagen Arteon":
                    volkswagens[3].CarDrive(listBox1);
                    break;
                case "Volkswagen Tiguan":
                    volkswagens[4].CarDrive(listBox1);
                    break;
                case "Volkswagen Golf":
                    volkswagens[5].CarDrive(listBox1);
                    break;
                case "AUDI A3":
                    AUDIs[0].CarDrive(listBox1);
                    break;
                case "AUDI A4":
                    AUDIs[1].CarDrive(listBox1);
                    break;
                case "AUDI A5":
                    AUDIs[2].CarDrive(listBox1);
                    break;
                case "AUDI A6":
                    AUDIs[3].CarDrive(listBox1);
                    break;
                case "AUDI A7":
                    AUDIs[4].CarDrive(listBox1);
                    break;
                case "AUDI A8":
                    AUDIs[5].CarDrive(listBox1);
                    break;
                case "AUDI Q3":
                    AUDIs[6].CarDrive(listBox1);
                    break;
                case "AUDI Q5":
                    AUDIs[7].CarDrive(listBox1);
                    break;
                case "AUDI Q6":
                    AUDIs[8].CarDrive(listBox1);
                    break;
                case "AUDI Q7":
                    AUDIs[9].CarDrive(listBox1);
                    break;
                case "AUDI Q8":
                    AUDIs[10].CarDrive(listBox1);
                    break;
                default:
                    listBox1.Items.Add("[LOG] Вы не выбрали машину для поездки!");
                    break;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
