using System;
using System.Linq;
using System.Windows.Forms;

namespace PenaltyManager
{
    public partial class MainWindow : Form
    {
        
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

            init_drivers_table();
            init_insurances_table();
            init_cars_table();

            init_violations_table();
        }

        public void RefreshAllTables()
        {
            refresh_violation_types_table();
            refresh_colors_table();
            refresh_manufacturers_table();
            refresh_models_table();

            refresh_drivers_table();
            refresh_insurances_table();
            refresh_cars_table();

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

        private void Form1_Load(object sender, EventArgs e)
        {
            InitAllTables();
            RefreshAllTables();
            RefreshAllTables();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        private void textBox1_TextChanged(object sender, EventArgs e){}

        private void button_add_violation_Click(object sender, EventArgs e)
        {
            ViolationTypeUpdate violUpdateTable = new ViolationTypeUpdate(this);
            violUpdateTable.Show();
            Enabled = false;
        }

        private void button_add_color_Click(object sender, EventArgs e)
        {
            ManufacturerAddition manufacturerAdditionForm = new ManufacturerAddition(this);
            manufacturerAdditionForm.Show();
            Enabled = false;
        }

        private void button_add_manufacturer_Click(object sender, EventArgs e)
        {
            ManufacturerUpdate manufacturerUpdate = new ManufacturerUpdate(this);
            manufacturerUpdate.Show();
            Enabled = false;
        }

        private void init_violation_types_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_violation_types.Columns.Add("ID", "Violation type");
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
            grid_car_colors.Columns.Add("ID", "Color ID");
            grid_car_colors.Columns.Add("ColorName", "Color Name");
            refresh_colors_table();
        }

        private void refresh_colors_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_car_colors.Rows.Clear();
            db.Colors.ToList().ForEach(e => grid_car_colors.Rows.Add(e.Id, e.ColorName));
        }

        private void init_manufacturers_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_car_manufacturers.Columns.Add("ID", "Manufacturers ID");
            grid_car_manufacturers.Columns.Add("ColorName", "Manufacturer Name");
            refresh_manufacturers_table();
        }

        private void refresh_manufacturers_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_car_manufacturers.Rows.Clear();
            db.Manufacturers.ToList().ForEach(e => grid_car_manufacturers.Rows.Add(e.Id, e.ManufacturerName));
        }

        private void init_models_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_models.Columns.Add("ID", "ID");
            grid_models.Columns.Add("Manufacturer", "Manufacturer");
            grid_models.Columns.Add("ModelName", "Model name");
            refresh_models_table();
        }

        private void refresh_models_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_models.Rows.Clear();
            db.Models.ToList().ForEach(e => grid_models.Rows.Add(e.Id, e.Manufacturer.ManufacturerName, e.Model1));
        }

        private void button_remove_violation_Click(object sender, EventArgs e)
        {
            
        }

        private void init_drivers_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_drivers.Columns.Add("ID", "ID");
            grid_drivers.Columns.Add("Name", "Full name");
            grid_drivers.Columns.Add("License", "Driver's license number");
            //db.Drivers.ToList().ForEach(e => grid_drivers.Rows.Add(e.Id, e.FullName, e.License));
            refresh_drivers_table();
        }

        private void refresh_drivers_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_drivers.Rows.Clear();
            db.Drivers.ToList().ForEach(e => grid_drivers.Rows.Add(e.Id, e.FullName, e.License));
        }

        private void init_insurances_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_insurances.Columns.Add("ID", "ID");
            grid_insurances.Columns.Add("DateTime", "Insurance time");
            grid_insurances.Columns.Add("IsValid", "Is valid");
            db.SaveChanges();
            refresh_insurances_table();
        }

        private void refresh_insurances_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_insurances.Rows.Clear();
            db.Insurances.ToList().ForEach(e => grid_insurances.Rows.Add(e.Id, e.InsuranceDate, e.IsValid));
        }

        private void init_cars_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_cars.Columns.Add("ID", "ID");
            grid_cars.Columns.Add("Number", "Car number");
            grid_cars.Columns.Add("InsID", "Insurance ID");
            grid_cars.Columns.Add("InsValue", "Insurance value");
            grid_cars.Columns.Add("Manufacturer", "Manufacturer");
            grid_cars.Columns.Add("Model", "Model");
            grid_cars.Columns.Add("Color", "Color");
            refresh_cars_table();
        }

        private void refresh_cars_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_cars.Rows.Clear();
            db.Automobiles.ToList().ForEach(e =>
                grid_cars.Rows.Add(e.Id, e.Number, e.Insurance_id, e.InsuranceValue, e.Model.Manufacturer.ManufacturerName,
                e.Model.Model1, e.Color.ColorName));
        }

        private void init_violations_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_violations.Columns.Add("ID", "ID");
            grid_violations.Columns.Add("CarID", "Car ID");
            grid_violations.Columns.Add("CarManufacturer", "Car manufacturer");
            grid_violations.Columns.Add("CarModel", "Car model");
            grid_violations.Columns.Add("DriverID", "Driver ID");
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
                grid_violations.Rows.Add(e.Id,
                    e.Automobile_id,
                    e.Automobile.Model.Manufacturer.ManufacturerName,
                    e.Automobile.Model.Model1,
                    e.Driver_id,
                    e.Driver.FullName,
                    e.ViolationType.Type,
                    e.ViolationType.Fine);
            });
        }

        private void grid_car_colors_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e){}

        private void button_updateDrivers_Click(object sender, EventArgs e)
        {
            DriversUpdate drvUpdateForm = new DriversUpdate(this);
            drvUpdateForm.Show();
            Enabled = false;
        }

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

        public int GetSelectedCarId()
        {
            if (grid_cars.SelectedCells.Count == 0)
                return -1;
            // get the selected row number
            int selectedRow = grid_cars.SelectedCells[0].RowIndex;
            // and pick the first column - should be ID
            string stringId = (string)grid_cars.Rows[selectedRow].Cells[0].Value;
            int ret;
            int.TryParse(stringId, out ret);
            return ret;
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
    }
}
