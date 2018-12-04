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

        private void RemoveAdminButtons()
        {
            panel7.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

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

            try
            {
                db.Colors.Remove(color);
                db.SaveChanges();
                RefreshAllTables();
            }
            catch(Exception exc)
            {
                ShowWarning("There are other tables referencing to that entity. Delete them first.");
            }
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

        private void init_drivers_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_drivers.Columns.Add("Name", "Full name");
            grid_drivers.Columns.Add("License", "Driver's license number");
            //db.Drivers.ToList().ForEach(e => grid_drivers.Rows.Add(e.Id, e.FullName, e.License));
            refresh_drivers_table();
        }

        private void refresh_drivers_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_drivers.Rows.Clear();
            db.Drivers.ToList().ForEach(e => grid_drivers.Rows.Add(e.FullName, e.License));
        }

        private void init_insurances_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_insurances.Columns.Add("DateTime", "Insurance time");
            grid_insurances.Columns.Add("IsValid", "Is valid");
            db.SaveChanges();
            refresh_insurances_table();
        }

        private void refresh_insurances_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_insurances.Rows.Clear();
            db.Insurances.ToList().ForEach(e => grid_insurances.Rows.Add(e.InsuranceDate, e.IsValid));
        }

        private void init_cars_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_cars.Columns.Add("Number", "Car number");
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
                grid_cars.Rows.Add(e.Number, e.InsuranceValue, e.Model.Manufacturer.ManufacturerName,
                e.Model.Model1, e.Color.ColorName));
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
    }
}
