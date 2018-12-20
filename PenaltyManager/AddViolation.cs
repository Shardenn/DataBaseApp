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
    public partial class AddViolation : Form
    {
        Form parentForm = null;
        RoadPenaltyContext db;

        public AddViolation(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
            db = new RoadPenaltyContext();
        }

        private void update_fine_info()
        {
            if (comboBox_violationType.SelectedItem == null)
                return;

            ViolationType type = db.ViolationTypes.Find(comboBox_violationType.SelectedItem);
            label_fine.Text = type.Fine.ToString();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Violation vio = new Violation();

            Driver foundDriver = db.Drivers.Where(f => f.FullName == comboBox_driverID.SelectedItem.ToString() &&
                                                  f.License == comboBox_license.SelectedItem.ToString()).FirstOrDefault();

            Automobile foundCar = db.Automobiles.Where(f => f.Number == comboBox_carID.SelectedItem.ToString()).FirstOrDefault();
            ViolationType vioType = db.ViolationTypes.Where(f => f.Type == comboBox_violationType.SelectedItem.ToString()).FirstOrDefault();
            DateTime selectedDate = dateTimePicker1.Value;

            if (foundDriver == null ||
                foundCar == null ||
                vioType == null)
            {
                MainWindow.ShowError("Could not find either a driver or a car or a violation type");
                return;
            }

            vio.Driver = foundDriver;
            vio.Automobile = foundCar;
            vio.ViolationType = vioType;
            vio.Date = selectedDate;

            db.Violations.Add(vio);
            db.SaveChanges();

            parentForm.Enabled = true;
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshAllTables();

            Close();
        }
        
        private void comboBox_violationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_fine_info();
        }

        private void fill_violation_combobox()
        {
            comboBox_violationType.Items.Clear();
            db.ViolationTypes.ToList().ForEach(e => comboBox_violationType.Items.Add(e.Type));
        }

        private void AddViolation_Load(object sender, EventArgs e)
        {
            foreach(var car in db.Automobiles)
            {
                comboBox_carID.Items.Add(car.Number);
            }
            comboBox_carID.SelectedItem = comboBox_carID.Items[0];

            foreach (var driver in db.Drivers)
            {
                if (!comboBox_driverID.Items.Contains(driver.FullName))
                {
                    comboBox_driverID.Items.Add(driver.FullName);
                }
            }
            comboBox_driverID.SelectedItem = comboBox_driverID.Items[0];

            FillLicenses();
            comboBox_license.SelectedItem = comboBox_license.Items[0];

            fill_violation_combobox();
            comboBox_violationType.SelectedIndex = comboBox_violationType.Items.Count - 1;
            
            update_fine_info();
        }

        private void FillLicenses()
        {
            comboBox_license.Items.Clear();
            var selectedDrivers = db.Drivers.Where(f => f.FullName == comboBox_driverID.SelectedItem.ToString());
            foreach (var driver in selectedDrivers)
            {
                comboBox_license.Items.Add(driver.License);
            }
        }

        private void AddViolation_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        private void comboBox_driverID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillLicenses();
            comboBox_license.SelectedItem = comboBox_license.Items[0];
        }
    }
}
