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
    public partial class FoundDriverInfo : Form
    {
        int driverId = -1;
        Form parentForm = null;

        public FoundDriverInfo(int id, Form parent)
        {
            InitializeComponent();
            driverId = id;
            parentForm = parent;
        }

        private void InitInsurancesTable()
        {
            gridView_insurances.Rows.Clear();
            gridView_insurances.Columns.Clear();

            gridView_insurances.Columns.Add("Insurance number", "Insurance number");
            gridView_insurances.Columns.Add("Car assigned", "Car assigned");
            gridView_insurances.Columns.Add("Value", "Value");
            gridView_insurances.Columns.Add("Date", "Date");
            gridView_insurances.Columns.Add("Is valid?", "Is valid?");
        }

        private void FillInsurancesTable()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Driver driver = db.Drivers.Find(driverId);

            if(driver == null)
            {
                MainWindow.ShowError("Driver Info window could not find a driver with ID " + driverId.ToString());
                Close();
            }

            var cars = db.Automobiles.Where(f => f.Model.Manufacturer.ManufacturerName == "New Lada");
            Insurance insur = new Insurance {
                Drivers = { driver },
                InsuranceDate = DateTime.Now,
                IsValid = true,
                Number = "testing1", Automobiles = cars.ToList()
            };
            driver.Insurances.Add(insur);

            var insurances = driver.Insurances;
            foreach(var ins in insurances)
            {
                Automobile carAssigned = ins.Automobiles.Last();
                gridView_insurances.Rows.Add(
                    ins.Number,
                    carAssigned.Number,
                    carAssigned.InsuranceValue,
                    ins.InsuranceDate.ToString(),
                    ins.IsValid.ToString()
                    );
            }
        }

        private void FoundDriverInfo_Load(object sender, EventArgs e)
        {
            InitInsurancesTable();
            FillInsurancesTable();
            RoadPenaltyContext db = new RoadPenaltyContext();
            Driver driver = db.Drivers.Find(driverId);
            textBox_driverName.Text = driver.FullName;
            textBox_licenseNumber.Text = driver.License;
        }

        private void button_saveChanges_Click(object sender, EventArgs e)
        {

        }

        private void RefreshAndClose()
        {
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshAllTables();
            Close();
        }

        private void FoundDriverInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

    }
}
