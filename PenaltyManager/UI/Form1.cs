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
    public partial class MainWindow : Form
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        public void RefreshAllTables()
        {
            refresh_violation_types_table();
            refresh_colors_table();
            refresh_manufacturers_table();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshAllTables();
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

        }

        private void button_add_color_Click(object sender, EventArgs e)
        {
            ColorAddition colorAdditionForm = new ColorAddition(this);
            colorAdditionForm.Show();
            Enabled = false;
        }

        private void button_add_manufacturer_Click(object sender, EventArgs e)
        {

        }

        private void refresh_violation_types_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_violation_types.DataSource = db.ViolationTypes.ToList();
        }

        private void refresh_colors_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_car_colors.DataSource = db.Colors.ToList();
        }

        private void refresh_manufacturers_table()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            grid_car_manufacturers.DataSource = db.Manufacturers.ToList();
        }

        private void button_remove_violation_Click(object sender, EventArgs e)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            
        }
        
        
    }
}
