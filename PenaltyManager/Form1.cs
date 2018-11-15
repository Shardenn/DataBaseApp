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

        public void RefreshUtilityTables()
        {
            refresh_violation_types_table();
            refresh_colors_table();
            refresh_manufacturers_table();
        }

        public void InitAllTables()
        {
            init_colors_table();
            init_manufacturers_table();
            init_violation_types_table();
            init_drivers_table();
        }

        public void RefreshManagementTables()
        {
            refresh_drivers_table();
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
            RefreshUtilityTables();
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

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
            //db.ViolationTypes.ToList().ForEach(e => grid_violation_types.Rows.Add(e.Type, e.Fine));
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
            //db.Colors.ToList().ForEach(e => grid_car_colors.Rows.Add(e.Id, e.ColorName));
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
            //db.Manufacturers.ToList().ForEach(e => grid_car_manufacturers.Rows.Add(e.Id, e.ManufacturerName));
            refresh_manufacturers_table();
        }

        private void refresh_manufacturers_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_car_manufacturers.Rows.Clear();
            db.Manufacturers.ToList().ForEach(e => grid_car_manufacturers.Rows.Add(e.Id, e.ManufacturerName));
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

        private void grid_car_colors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button_updateDrivers_Click(object sender, EventArgs e)
        {
            DriversUpdate drvUpdateForm = new DriversUpdate(this);
            drvUpdateForm.Show();
            Enabled = false;
        }

        private void button_updateInsurances_Click(object sender, EventArgs e)
        {

        }
        
    }
}
