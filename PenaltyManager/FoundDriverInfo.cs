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

        private void InitCarsTable()
        {
            gridView_carsAssigned.Rows.Clear();
            gridView_carsAssigned.Columns.Clear();

            gridView_carsAssigned.Columns.Add("Car number", "Car number");
            gridView_carsAssigned.Columns.Add("Insurance number", "Insurance number");
            gridView_carsAssigned.Columns.Add("Is owner?", "Is owner?");
        }

        private void FillCarsTable()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Driver driver = db.Drivers.Find(driverId);

            if(driver == null)
            {
                MainWindow.ShowError("Driver Info window could not find a driver with ID " + driverId.ToString());
                Close();
            }

            var insurances = driver.Insurances;
            try
            {
                if (insurances.Count() < 1)
                {
                    MainWindow.ShowWarning("No insurances are assigned to the driver");
                }
                else foreach (var ins in insurances)
                    {
                        gridView_carsAssigned.Rows.Add(ins.Automobiles.FirstOrDefault().Number,
                            ins.Number,
                            "False");
                    }

                var carsOwned = driver.Automobiles;
                if (carsOwned.Count() < 1)
                {
                    MainWindow.ShowWarning("No cars are owned by the driver");
                }
                else foreach (var car in carsOwned)
                    {
                        gridView_carsAssigned.Rows.Add(car.Number,
                            car.Insurance.Number,
                            "True");
                    }
            }
            catch(Exception ex)
            {
                MainWindow.ShowError(ex.Message);
            }
        }

        private void FoundDriverInfo_Load(object sender, EventArgs e)
        {
            InitCarsTable();
            FillCarsTable();
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
