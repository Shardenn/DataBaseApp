using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenaltyManager
{
    public partial class CarUpdate : Form
    {
        Form parentForm = null;

        public CarUpdate(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void CarUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roadPenaltiesDataSet.Models' table. You can move, or remove it, as needed.
            this.modelsTableAdapter.Fill(this.roadPenaltiesDataSet.Models);
            // TODO: This line of code loads data into the 'roadPenaltiesDataSet.Insurance' table. You can move, or remove it, as needed.
            this.insuranceTableAdapter.Fill(this.roadPenaltiesDataSet.Insurance);
            // TODO: This line of code loads data into the 'roadPenaltiesDataSet.Colors' table. You can move, or remove it, as needed.
            this.colorsTableAdapter.Fill(this.roadPenaltiesDataSet.Colors);
            // TODO: This line of code loads data into the 'roadPenaltiesDataSet.Manufacturers' table. You can move, or remove it, as needed.
            this.manufacturersTableAdapter.Fill(this.roadPenaltiesDataSet.Manufacturers);
            fill_form_with_default_data();
        }

        private void fill_form_with_default_data()
        {
            
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            var idText = textBox_id.Text;
            int id;
            if(!int.TryParse(idText, out id))
            {
                MainWindow.ShowError("Invalid ID input");
                return;
            }
            RemoveCar(id);

            parentForm.Enabled = true;
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshAllTables();
            Close();
        }

        private void button_addEdit_Click(object sender, EventArgs e)
        {
            string idText = textBox_id.Text,
                numberText = textBox_carNumber.Text,
                insValueText = textBox_insValue.Text;

            int insId = (int)comboBox_assignedIns.SelectedValue, 
                insValue,
                modelId = (int)comboBox_model.SelectedValue, 
                colorId = (int)comboBox_color.SelectedValue;

            if(!int.TryParse(insValueText, out insValue))
            {
                MainWindow.ShowError("Invalid insurance value");
                return;
            }
            if(idText == "")
            {
                AddCar(numberText, insId, insValue, modelId, colorId);
            }
            else
            {
                int id;
                if(!int.TryParse(idText, out id))
                {
                    MainWindow.ShowError("Invalid ID input");
                    return;
                }
                EditCar(id, numberText, insId, insValue, modelId, colorId);
            }

            parentForm.Enabled = true;
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshAllTables();
            Close();
        }

        private void AddCar(string number, int insId, int insValue, 
            int modelId, int colorId)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Automobile car = new Automobile();

            car.Number = number;
            car.Insurance_id = insId;
            car.InsuranceValue = insValue;
            car.Model_id = modelId;
            car.Color_id = colorId;

            car.Insurance = db.Insurances.Find(insId);
            car.Model = db.Models.Find(modelId);
            car.Color = db.Colors.Find(colorId);

            db.Automobiles.Add(car);
            db.SaveChanges();
        }

        private void EditCar(int id, string number, int insId, int insValue, 
            int modelId, int colorId)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Automobile car = db.Automobiles.Find(id);
            if (car == null)
            {
                MainWindow.ShowError("No car has such a key");
                return;
            }
            car.Number = number;
            car.Insurance_id = insId;
            car.InsuranceValue = insValue;
            car.Model_id = modelId;
            car.Color_id = colorId;

            car.Insurance = db.Insurances.Find(insId);
            car.Model = db.Models.Find(modelId);
            car.Color = db.Colors.Find(colorId);

            db.SaveChanges();
        }

        private void RemoveCar(int id)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Automobile car = db.Automobiles.Find(id);
            if(car == null)
            {
                MainWindow.ShowError("No car has such a key");
                return;
            }
            db.Automobiles.Remove(car);
            db.SaveChanges();
        }

        private void CarUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }
    }
}
