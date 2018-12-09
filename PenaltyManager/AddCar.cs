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
    public partial class AddCar : Form
    {
        Form parentForm = null;
        RoadPenaltyContext db = null;

        public AddCar(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
            db = new RoadPenaltyContext();
        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            db.Colors.ToList().ForEach(f => comboBox_color.Items.Add(f.ColorName));
            comboBox_color.SelectedItem = comboBox_color.Items[0];

            db.Insurances.ToList().ForEach(f => comboBox_assignedIns.Items.Add(f.Number));
            comboBox_assignedIns.SelectedItem = comboBox_assignedIns.Items[0];

            foreach (var model in db.Models)
            {
                comboBox_model.Items.Add(model.Manufacturer.ManufacturerName + " " + model.Model1);
            }
            comboBox_model.SelectedItem = comboBox_model.Items[0];
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Model foundModel = GetModelFromSelected(comboBox_model.SelectedItem.ToString());
            Insurance ins = GetInsuranceFomSelected(comboBox_assignedIns.SelectedItem.ToString());
            Color color = GetColorFromSelected(comboBox_color.SelectedItem.ToString());
            int insVal;
            if(!int.TryParse(textBox_insValue.Text, out insVal) ||
                foundModel == null ||
                ins == null ||
                color == null)
            {
                MainWindow.ShowError("Check your input or code. Error getting all data for car to add.");
                return;
            }

            AddCarToDB(textBox_carNumber.Text, insVal, ins, foundModel, color);
            RefreshAndClose();
        }

        private void AddCarToDB(string number, int insValue, Insurance ins, Model model, Color color)
        {
            
            Automobile car = new Automobile();

            car.Number = number;
            car.InsuranceValue = insValue;

            car.Insurance = ins;
            car.Model = model;
            car.Color = color;

            db.Automobiles.Add(car);
            db.SaveChanges();
        }

        // get the model ibject from the selected manufacturer-model string
        private Model GetModelFromSelected(string manModel)
        {
            int spaceIndex = manModel.LastIndexOf(' ') + 1;
            string modelName = manModel.Substring(spaceIndex);
            string manName = manModel.Substring(0, spaceIndex - 1);

            //RoadPenaltyContext db = new RoadPenaltyContext();
            Model foundModel = db.Models.Where(f => f.Model1 == modelName && f.Manufacturer.ManufacturerName == manName).FirstOrDefault();

            return foundModel;
        }

        private Insurance GetInsuranceFomSelected(string insuranceNum)
        {
            //RoadPenaltyContext db = new RoadPenaltyContext();
            return db.Insurances.Where(f => f.Number == insuranceNum).FirstOrDefault();
        }

        private Color GetColorFromSelected(string color)
        {
            //RoadPenaltyContext db = new RoadPenaltyContext();
            return db.Colors.Where(f => f.ColorName == color).FirstOrDefault();
        }

        private void RefreshAndClose()
        {
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshAllTables();
            Close();
        }

        private void AddCar_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        
    }
}
