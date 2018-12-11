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
    public partial class AddDriverCarConnection : Form
    {
        Form parentForm = null;
        RoadPenaltyContext db = null;

        public AddDriverCarConnection(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
            db = new RoadPenaltyContext();
        }

        private void AddDriverCarConnection_Load(object sender, EventArgs e)
        {
            
        }

        // search for cars
        private void button_search_Click(object sender, EventArgs e)
        {
            string number = textBox_carNumber.Text;
            var cars = db.Automobiles.Where(f => f.Number == number);
            FillSearchResultsWithCars(cars);
        }

        private void button_searchDrivers_Click(object sender, EventArgs e)
        {
            string name = textBox_driverName.Text;
            var drivers = db.Drivers.Where(f => f.FullName == name);
            FillSearchResultsWithDrivers(drivers);
        }

        private void button_addConntection_Click(object sender, EventArgs e)
        {
            Driver selectedDriver = GetSelectedDriver();
            Automobile selectedCar = GetSelectedCar();

            //selectedDriver.Automobiles.Add(selectedCar);
            selectedDriver.Insurances.Add(selectedCar.Insurance);
            selectedCar.Insurance.Drivers.Add(selectedDriver);

            SaveAndClose();
        }

        private Automobile GetSelectedCar()
        {
            int selectedIndex = gridView_cars.SelectedCells[0].RowIndex;
            string carNumber = gridView_cars.Rows[selectedIndex].Cells[0].Value.ToString();

            return db.Automobiles.Where(f => f.Number == carNumber).FirstOrDefault();
        }
        
        private Driver GetSelectedDriver()
        {
            int selectedIndex = gridView_drivers.SelectedCells[0].RowIndex;
            string name = gridView_drivers.Rows[selectedIndex].Cells[0].Value.ToString();

            return db.Drivers.Where(f => f.FullName == name).FirstOrDefault();
        }

        private void FillSearchResultsWithDrivers(IQueryable<Driver> drivers)
        {
            gridView_drivers.Rows.Clear();
            gridView_drivers.Columns.Clear();

            gridView_drivers.Columns.Add("Driver full name", "Driver full name");
            gridView_drivers.Columns.Add("License number", "License number");

            foreach (var driver in drivers)
            {
                gridView_drivers.Rows.Add(
                    driver.FullName,
                    driver.License
                    );
            }
        }

        private void FillSearchResultsWithCars(IQueryable<Automobile> cars)
        {
            gridView_cars.Rows.Clear();
            gridView_cars.Columns.Clear();

            gridView_cars.Columns.Add("Car number", "Car number");
            gridView_cars.Columns.Add("Car manufacturer", "Car manufacturer");
            gridView_cars.Columns.Add("Car model", "Car model");
            gridView_cars.Columns.Add("Insurance is valid", "Insurance is valid");
            gridView_cars.Columns.Add("Insurance value", "Insurance value");

            foreach (var car in cars)
            {
                gridView_cars.Rows.Add(
                car.Number,
                car.Model.Manufacturer.ManufacturerName,
                car.Model.Model1,
                car.Insurance.IsValid,
                car.InsuranceValue);
            }
        }

        private void SaveAndClose()
        {
            try
            {
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                MainWindow.ShowError("A driver who has hit a man cannot own new cars");
            }
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshAllTables();
            Close();
        }

        private void AddDriverCarConnection_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        
    }
}
