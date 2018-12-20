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

            foreach(var driver in db.Drivers)
            {
                if(!comboBox_owner.Items.Contains(driver.FullName))
                {
                    comboBox_owner.Items.Add(driver.FullName);
                }
            }
            comboBox_owner.SelectedItem = comboBox_owner.Items[0];

            FillLicenses();
            comboBox_license.SelectedItem = comboBox_license.Items[0];

            foreach (var model in db.Models)
            {
                comboBox_model.Items.Add(model.Manufacturer.ManufacturerName + " " + model.Model1);
            }
            comboBox_model.SelectedItem = comboBox_model.Items[0];
        }

        private void FillLicenses()
        {
            comboBox_license.Items.Clear();
            var selectedDrivers = db.Drivers.Where(f => f.FullName == comboBox_owner.SelectedItem.ToString());
            foreach(var driver in selectedDrivers)
            {
                comboBox_license.Items.Add(driver.License);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Model foundModel = GetModelFromSelected(comboBox_model.SelectedItem.ToString());
            Insurance ins = GetInsuranceFomSelected(comboBox_assignedIns.SelectedItem.ToString());
            Color color = GetColorFromSelected(comboBox_color.SelectedItem.ToString());
            Driver owner = GetDriverFromSelected(comboBox_owner.SelectedItem.ToString(), comboBox_license.SelectedItem.ToString());

            int insVal;
            if(!int.TryParse(textBox_insValue.Text, out insVal) ||
                foundModel == null ||
                ins == null ||
                color == null || 
                owner == null ||
                textBox_carNumber.Text == "")
            {
                MainWindow.ShowError("Check your input or code. Error getting all data for car to add.");
                return;
            }

            if(AddCarToDB(textBox_carNumber.Text, insVal, ins, foundModel, color, owner))
                RefreshAndClose();
        }

        private bool AddCarToDB(string number, int insValue, Insurance ins, Model model, Color color, Driver owner)
        {
            var foundCars = db.Automobiles.Where(f => f.Number == number);
            if(foundCars.Count() > 0)
            {
                MainWindow.ShowError("A car with such a number already exists.");
                return false;
            }
            if(insValue < 0)
            {
                MainWindow.ShowError("Insurance value should be positive.");
                return false;
            }
            if(ins.Automobiles.Count() > 0)
            {
                MainWindow.ShowError("This insurance already has a car assigned");
                return false;
            }

            Automobile car = new Automobile();

            car.Number = number;

            RoadPenaltiesEntities1 dbEnt = new RoadPenaltiesEntities1();
            
            car.InsuranceValue = dbEnt.CalculateInsurance(insValue);
                        
            car.Insurance = ins;
            car.Model = model;
            car.Color = color;

            car.Drivers.Clear();
            car.Drivers.Add(owner);

            db.Automobiles.Add(car);
            //db.SaveChanges();
            owner.Automobiles.Add(car);
            try
            {
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                MainWindow.ShowError("A man who had hit the man cannot own a new car");
                return false;
            }
            return true;
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
            return db.Insurances.Where(f => f.Number == insuranceNum).FirstOrDefault();
        }

        private Color GetColorFromSelected(string color)
        {
            return db.Colors.Where(f => f.ColorName == color).FirstOrDefault();
        }

        private Driver GetDriverFromSelected(string name, string license)
        {
            return db.Drivers.Where(f => f.FullName == name && f.License == license).FirstOrDefault();
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

        private void comboBox_owner_SelectedValueChanged(object sender, EventArgs e)
        {
            FillLicenses();
            comboBox_license.SelectedItem = comboBox_license.Items[0];
        }
    }
}
