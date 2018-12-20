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
    public partial class EditViolationNew : Form
    {
        Form parentForm;
        RoadPenaltyContext db = null;
        Violation violationToUpdate = null;

        public EditViolationNew(Form parent, RoadPenaltyContext cont, Violation viol)
        {
            InitializeComponent();
            parentForm = parent;
            db = cont;
            violationToUpdate = viol;
        }

        private void EditViolationNew_Load(object sender, EventArgs e)
        {
            if(violationToUpdate == null)
            {
                MainWindow.ShowError("No violations to edit. Maybe no violation is selected");
                Close();
            }

            foreach (var car in db.Automobiles)
            {
                comboBox_cars.Items.Add(car.Number);
            }
            //comboBox_cars.SelectedItem = comboBox_cars.Items[0];
            comboBox_cars.SelectedItem = violationToUpdate.Automobile.Number;

            foreach (var driver in db.Drivers)
            {
                if (!comboBox_drivers.Items.Contains(driver.FullName))
                {
                    comboBox_drivers.Items.Add(driver.FullName);
                }
            }
            //comboBox_drivers.SelectedItem = comboBox_drivers.Items[0];
            comboBox_drivers.SelectedItem = violationToUpdate.Driver.FullName;

            FillLicenses();
            comboBox_licenses.SelectedItem = comboBox_licenses.Items[0];

            fill_violation_combobox();
            comboBox_violationTypes.SelectedItem = comboBox_violationTypes.Items[0];

            update_fine_info();
        }

        private void FillLicenses()
        {
            comboBox_licenses.Items.Clear();
            var selectedDrivers = db.Drivers.Where(f => f.FullName == comboBox_drivers.SelectedItem.ToString());
            foreach (var driver in selectedDrivers)
            {
                comboBox_licenses.Items.Add(driver.License);
            }
        }

        private void fill_violation_combobox()
        {
            comboBox_violationTypes.Items.Clear();
            db.ViolationTypes.ToList().ForEach(e => comboBox_violationTypes.Items.Add(e.Type));
        }
        

        private void update_fine_info()
        {
            if (comboBox_violationTypes.SelectedItem == null)
                return;
            
            ViolationType type = db.ViolationTypes.Find(comboBox_violationTypes.SelectedItem);
            label_fine.Text = type.Fine.ToString();
        }

        private void comboBox_violationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_fine_info();
        }

        private void button_editViolation_Click(object sender, EventArgs e)
        {
            
        }

        private void EditViolationNew_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Driver foundDriver = db.Drivers.Where(f => f.FullName == comboBox_drivers.SelectedItem.ToString() &&
                                                  f.License == comboBox_licenses.SelectedItem.ToString()).FirstOrDefault();

            Automobile foundCar = db.Automobiles.Where(f => f.Number == comboBox_cars.SelectedItem.ToString()).FirstOrDefault();
            ViolationType vioType = db.ViolationTypes.Where(f => f.Type == comboBox_violationTypes.SelectedItem.ToString()).FirstOrDefault();

            violationToUpdate.Driver = foundDriver;
            violationToUpdate.Automobile = foundCar;
            violationToUpdate.ViolationType = vioType;

            violationToUpdate.Driver_id = foundDriver.Id;
            violationToUpdate.Automobile_id = foundCar.Id;

            db.SaveChanges();

            parentForm.Enabled = true;
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshAllTables();

            Close();
        }
    }
}
