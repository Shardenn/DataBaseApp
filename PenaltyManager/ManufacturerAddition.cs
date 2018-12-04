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
    public partial class ManufacturerAddition : Form
    {
        Form parentForm = null;

        public ManufacturerAddition(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string newName = textBox_newName.Text;
            RoadPenaltyContext db = new RoadPenaltyContext();
            Manufacturer foundMan = db.Manufacturers.Where(f => f.ManufacturerName == newName).FirstOrDefault();
            if(foundMan != null)
            {
                MainWindow.ShowError("A manufacturer with such a name already exists.");
                return;
            }

            Manufacturer man = new Manufacturer { ManufacturerName = newName };
            db.Manufacturers.Add(man);
            db.SaveChanges();
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshAllTables();
            Close();
        }

        private void ManufacturerAddition_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

    }
}
