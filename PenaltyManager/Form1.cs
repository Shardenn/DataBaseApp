using System;
using System.Linq;
using System.Windows.Forms;

namespace PenaltyManager
{

    public partial class MainWindow : Form
    {
        private int m_foundDriverID = -1;
        private int m_foundCarID = -1;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void InitAllTables()
        {
            init_colors_table();
            init_manufacturers_table();
            init_violation_types_table();
            init_models_table();
            

            init_violations_table();
        }

        public void RefreshAllTables()
        {
            refresh_violation_types_table();
            refresh_colors_table();
            refresh_manufacturers_table();
            refresh_models_table();
            
            if (m_foundDriverID != -1 || m_foundCarID != -1)
                button1_Click(this, null);

            refresh_violations_table();
        }

        public static void ShowError(string message, string title = "Error")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowWarning(string message, string title = "Warning")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void RemoveAdminButtons()
        {
            panel7.Visible = false;

            tabControl1.TabPages.RemoveAt(2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Environment.UserName == "InsufficientUser") //InsufficientUser //Andrei
                RemoveAdminButtons();

            InitAllTables();
            RefreshAllTables();
            RefreshAllTables();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        private void textBox1_TextChanged(object sender, EventArgs e){}


        // it is a violation type update actually!
        private void button_add_violation_Click(object sender, EventArgs e)
        {
            ViolationTypeUpdate violUpdateTable = new ViolationTypeUpdate(this);
            violUpdateTable.Show();
            Enabled = false;
        }

        private void button_addViolationType_Click(object sender, EventArgs e)
        {
            ViolationTypeAddition form = new ViolationTypeAddition(this);
            form.Show();
            Enabled = false;
        }

        private void button_addColor_Click(object sender, EventArgs e)
        {
            ColorAddition form = new ColorAddition(this);
            form.Show();
            Enabled = false;
        }

        private void button_updateColor_Click(object sender, EventArgs e)
        {
            ColorUpdate form = new ColorUpdate(this);
            form.Show();
            Enabled = false;
        }

        private void button_removeColor_Click(object sender, EventArgs e)
        {
            string colorName = grid_car_colors.SelectedCells[0].Value.ToString();
            RoadPenaltyContext db = new RoadPenaltyContext();
            Color color = db.Colors.Where(f => f.ColorName == colorName).FirstOrDefault();
            if(color == null)
            {
                ShowError("Could not find a color to delete");
                return;
            }
            
            db.Colors.Remove(color);
            db.SaveChanges();
            RefreshAllTables();
        }

        // it is a color update actually 
        private void button_add_manufacturer_Click(object sender, EventArgs e)
        {
            ManufacturerUpdate manufacturerUpdate = new ManufacturerUpdate(this);
            manufacturerUpdate.Show();
            Enabled = false;
        }


        private void button_manufacturerAdd_Click(object sender, EventArgs e)
        {
            ManufacturerAddition form = new ManufacturerAddition(this);
            form.Show();
            Enabled = false;
        }

        private void button_manufacturereUpdate_Click(object sender, EventArgs e)
        {
            ManufacturerUpdate form = new ManufacturerUpdate(this);
            form.Show();
            Enabled = false;
        }

        private void button_manufacturerRemove_Click(object sender, EventArgs e)
        {
            string manName = grid_car_manufacturers.SelectedCells[0].Value.ToString();
            RoadPenaltyContext db = new RoadPenaltyContext();
            Manufacturer man = db.Manufacturers.Where(f => f.ManufacturerName== manName).FirstOrDefault();
            if (man == null)
            {
                ShowError("Could not find a manufacturer to delete");
                return;
            }

            try
            {
                db.Manufacturers.Remove(man);
                db.SaveChanges();
                RefreshAllTables();
            }
            catch(Exception exc)
            {
                ShowWarning("There are other tables referencing to that entity. Delete them first.");
            }
        }

        private void init_violation_types_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_violation_types.Columns.Add("ViolationType", "Violation type");
            grid_violation_types.Columns.Add("Fine", "Fine");
            refresh_violation_types_table();
        }

        private void refresh_violation_types_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_violation_types.Rows.Clear();
            db.ViolationTypes.ToList().ForEach(e => grid_violation_types.Rows.Add(e.Type, e.Fine));
        }



        private void init_colors_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_car_colors.Columns.Add("ColorName", "Color Name");
            refresh_colors_table();
        }

        private void refresh_colors_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_car_colors.Rows.Clear();
            db.Colors.ToList().ForEach(e => grid_car_colors.Rows.Add(e.ColorName));
        }

        private void init_manufacturers_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_car_manufacturers.Columns.Add("ManufacturerName", "Manufacturer Name");
            refresh_manufacturers_table();
        }

        private void refresh_manufacturers_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_car_manufacturers.Rows.Clear();
            db.Manufacturers.ToList().ForEach(e => grid_car_manufacturers.Rows.Add(e.ManufacturerName));
        }

        private void init_models_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_models.Columns.Add("Manufacturer", "Manufacturer");
            grid_models.Columns.Add("ModelName", "Model name");
            refresh_models_table();
        }

        private void refresh_models_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_models.Rows.Clear();
            db.Models.ToList().ForEach(e => grid_models.Rows.Add(e.Manufacturer.ManufacturerName, e.Model1));
        }

        private void button_remove_violation_Click(object sender, EventArgs e)
        {
            
        }

        private void init_violations_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_violations.Columns.Add("CarManufacturer", "Car manufacturer");
            grid_violations.Columns.Add("CarModel", "Car model");
            grid_violations.Columns.Add("CarColor", "Car color");
            grid_violations.Columns.Add("DriverName", "Driver Name");
            grid_violations.Columns.Add("ViolationType", "Violation Type");
            grid_violations.Columns.Add("Fine", "Fine");
            refresh_violations_table();
        }

        private void refresh_violations_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_violations.Rows.Clear();
            db.Violations.ToList().ForEach(e =>
            {
                grid_violations.Rows.Add(
                    e.Automobile.Model.Manufacturer.ManufacturerName,
                    e.Automobile.Model.Model1,
                    e.Automobile.Color.ColorName,
                    e.Driver.FullName,
                    e.ViolationType.Type,
                    e.ViolationType.Fine);
            });
        }

        private void grid_car_colors_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e){}
        

        private void button_updateInsurances_Click(object sender, EventArgs e)
        {
            InsuranceUpdate insUpdate = new InsuranceUpdate(this);
            insUpdate.Show();
            Enabled = false;
        }

        private void button_updateCars_Click(object sender, EventArgs e)
        {
            CarUpdate carForm = new CarUpdate(this);
            carForm.Show();
            Enabled = false;
        }
        
        private void button_updateModels_Click(object sender, EventArgs e)
        {
            ModelsUpdate modelsForm = new ModelsUpdate(this);
            modelsForm.Show();
            Enabled = false;
        }

        private void button_addViolation_Click(object sender, EventArgs e)
        {
            AddViolation violForm = new AddViolation(this);
            violForm.Show();
            Enabled = false;
        }

        private void button_editViolation_Click(object sender, EventArgs e)
        {
            EditViolationNew violEdit = new EditViolationNew(this);
            violEdit.Show();
            Enabled = false;
        }

        private void button_removeViolation_Click(object sender, EventArgs e)
        {
            RemoveViolation violForm = new RemoveViolation(this);
            violForm.Show();
            Enabled = false;
        }

        private void button_removeViolationType_Click(object sender, EventArgs e)
        {
            string violationName = grid_violation_types.SelectedCells[0].Value.ToString();
            if(violationName == "")
            {
                ShowError("No violation selected for removal");
                return;
            }

            RoadPenaltyContext db = new RoadPenaltyContext();
            ViolationType type = db.ViolationTypes.Where(f => f.Type == violationName).FirstOrDefault();

            if(type == null)
            {
                ShowError("No violation found for removal");
                return;
            }
            try
            {
                db.ViolationTypes.Remove(type);
                db.SaveChanges();
                RefreshAllTables();
            }
            catch(Exception exc)
            {
                ShowWarning("There are other tables referencing to that entity. Delete them first.");
            }
        }

        private void button_modelAddition_Click(object sender, EventArgs e)
        {
            ModelsAddition form = new ModelsAddition(this);
            form.Show();
            Enabled = false;
        }

        private void button_modelsRemoval_Click(object sender, EventArgs e)
        {
            int selectedIndex = grid_models.SelectedCells[0].RowIndex;

            string manufacturer = grid_models.Rows[selectedIndex].Cells[0].Value.ToString();
            string model = grid_models.Rows[selectedIndex].Cells[1].Value.ToString();

            RoadPenaltyContext db = new RoadPenaltyContext();
            Manufacturer foundMan = db.Manufacturers.Where(f => f.ManufacturerName == manufacturer).FirstOrDefault();
            if(foundMan == null)
            {
                ShowError("Could not find such a manufacturer");
                return;
            }

            var foundMans = db.Manufacturers.Where(f => f.ManufacturerName == manufacturer);
            Model foundModel = null;
            foreach (var man in foundMans)
            {
                foundModel = man.Models.Where(f => f.Model1 == model).FirstOrDefault();
                if (foundModel == null)
                {
                    ShowError("Could not find a model to delete");
                    continue;
                }
                break;
            }

            try
            {
                db.Models.Remove(foundModel);
                db.SaveChanges();
                RefreshAllTables();
                return;
            }
            catch(Exception exc)
            {
                ShowWarning("There are other tables referencing to that entity. Delete them first.");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        // Search button -_- I hate c# and DB
        private void button1_Click(object sender, EventArgs e)
        {
            m_foundCarID = -1;
            m_foundDriverID = -1;

            string enteredName = textBox_driverName.Text;
            string enteredSurname = textBox_driverSurname.Text;
            string enteredCarNumber = textBox_carNumber.Text;

            Driver foundDriver = FindDriver(enteredName + " " + enteredSurname);
            Automobile foundCar = FindCar(enteredCarNumber);

            if(foundDriver == null && foundCar == null)
            {
                ShowError("Could not find neither a driver with provided name nor a car with the number.");
                return;
            }

            if(foundCar == null)
            {
                m_foundDriverID = foundDriver.Id;
                FillSearchInfoByDriver(foundDriver);
            }
            else
            {
                m_foundCarID = foundCar.Id;
                FillSearchInfoByCar(foundCar);
            }
            label_resultDriverName_CarNumber.Visible = true;
        }

        private Driver FindDriver(string fullName)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Driver foundDriver = db.Drivers.Where(f => f.FullName == fullName).FirstOrDefault();
            return foundDriver;
        }

        private Automobile FindCar(string carNumber)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Automobile foundCar = db.Automobiles.Where(f => f.Number == carNumber).FirstOrDefault();
            return foundCar;
        }

        // Will fill the table with the cars that belongs to the found driver
        private void FillSearchInfoByDriver(Driver driver)
        {
            label_driverOrCar.Text = "driver";
            label_resultDriverName_CarNumber.Text = driver.FullName;
            dataGridView_searchResults.Columns.Clear();
            dataGridView_searchResults.Rows.Clear();

            dataGridView_searchResults.Columns.Add("Car number", "Car number");
            dataGridView_searchResults.Columns.Add("Car manufacturer", "Car manufacturer");
            dataGridView_searchResults.Columns.Add("Car model", "Car model");
            dataGridView_searchResults.Columns.Add("Insurance is valid", "Insurance is valid");
            dataGridView_searchResults.Columns.Add("Insurance value", "Insurance value");

            if(driver.Insurances.Count == 0)
            {
                ShowWarning("Looks like the provided driver is not in an insurance.");
                return;
            }
            
            // search for all insurances this driver in
            foreach(var ins in driver.Insurances)
            {
                // get all cars
                var car = ins.Automobiles.FirstOrDefault();
                dataGridView_searchResults.Rows.Add(
                    car.Number,
                    car.Model.Manufacturer.ManufacturerName,
                    car.Model.Model1,
                    car.Insurance.IsValid,
                    car.InsuranceValue);
            }

        }

        // DONE
        // Will fill the table with the drivers who can drive the found car
        private void FillSearchInfoByCar(Automobile car)
        {
            label_driverOrCar.Text = "car with №";
            label_resultDriverName_CarNumber.Text = car.Number;
            dataGridView_searchResults.Columns.Clear();
            dataGridView_searchResults.Rows.Clear();

            if (car.Insurance.Drivers.Count == 0)
            {
                ShowWarning("Looks like the provided car has no assigned driver.");
                return;
            }

            dataGridView_searchResults.Columns.Add("Driver full name", "Driver full name");
            dataGridView_searchResults.Columns.Add("License number", "License number");

            foreach(var driver in car.Insurance.Drivers)
            {
                dataGridView_searchResults.Rows.Add(
                    driver.FullName,
                    driver.License
                    );
            }
        }

        private void label_resultDriverName_CarNumber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_foundDriverID != -1)
            {
                FoundDriverInfo form = new FoundDriverInfo(m_foundDriverID, this);
                form.Show();
                return;
            }
            else if(m_foundCarID != -1)
            {
                FoundDriverInfo form = new FoundDriverInfo(m_foundCarID, this);
                form.Show();
                return;
            }
        }

        private void button_addDriver_Click(object sender, EventArgs e)
        {
            AddDriver form = new AddDriver(this);
            form.Show();
            Enabled = false;
        }

        private void button_addCar_Click(object sender, EventArgs e)
        {
            AddCar form = new AddCar(this);
            form.Show();
            Enabled = false;
        }

        private void button_addDriverCarConnection_Click(object sender, EventArgs e)
        {
            AddDriverCarConnection form = new AddDriverCarConnection(this);
            form.Show();
            Enabled = false;
        }

        private void button_editDriverCarConnection_Click(object sender, EventArgs e)
        {
            if (m_foundCarID != -1)
                RemoveCarDriverConnection(m_foundCarID);
            else if (m_foundDriverID != -1)
                RemoveDriverCarConnection(m_foundDriverID);
        }

        private void RemoveDriverCarConnection(int driverID)
        {
            int selectedIndex = dataGridView_searchResults.SelectedCells[0].RowIndex;
            string carNumber = dataGridView_searchResults.Rows[selectedIndex].Cells["Car number"].Value.ToString();

            RoadPenaltyContext db = new RoadPenaltyContext();
            Automobile car = db.Automobiles.Where(f => f.Number == carNumber).FirstOrDefault();
            Driver driver = db.Drivers.Find(driverID);
            if (car != null)
            {
                car.Drivers.Remove(driver);
                driver.Automobiles.Remove(car);
            }
            else
            {
                ShowError("No car is selected in the table");
            }
            db.SaveChanges();
            RefreshAllTables();
        }

        private void RemoveCarDriverConnection(int carID)
        {
            int selectedIndex = dataGridView_searchResults.SelectedCells[0].RowIndex;
            string name = dataGridView_searchResults.Rows[selectedIndex].Cells["Driver full name"].Value.ToString();

            RoadPenaltyContext db = new RoadPenaltyContext();
            Driver driver = db.Drivers.Where(f => f.FullName == name).FirstOrDefault();
            Automobile car = db.Automobiles.Find(carID);
            if (driver != null)
            {
                car.Drivers.Remove(driver);
                driver.Automobiles.Remove(car);
            }
            else
            {
                ShowError("No driver is selected in the table");
            }
            db.SaveChanges();
            RefreshAllTables();
        }

        private void button_manageInsurances_Click(object sender, EventArgs e)
        {
            InsurancesManagement form = new InsurancesManagement(this);
            form.Show();
            Enabled = false;
        }

        private void grid_violations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
