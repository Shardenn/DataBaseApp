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
    public partial class ManufacturerUpdate : Form
    {
        Form parentForm = null;

        public ManufacturerUpdate(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_editRemove_Click(object sender, EventArgs e)
        {

        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            var manufacturerName = textBox_input.Text;
            if (manufacturerName == "")
            {
                MainWindow.ShowError("Provide new manufacturer name", "Error");
                return;
            }

            Manufacturer newManufacturer = new Manufacturer { ManufacturerName = manufacturerName };
            db.Manufacturers.Add(newManufacturer);
            db.SaveChanges();
            parentForm.Enabled = true;
            MainWindow main = (MainWindow)parentForm;
            main.RefreshAllTables();
            Close();
        }
    }
}
