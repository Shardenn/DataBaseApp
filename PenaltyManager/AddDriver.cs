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
    public partial class AddDriver : Form
    {
        Form parentForm = null;

        public AddDriver(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string fullName = textBox_fullName.Text;
            string license = textBox_license.Text;

            if(fullName == "" || license == "")
            {
                MainWindow.ShowError("All fields should be filled.");
                return;
            }

            if(AddDriverToDB(fullName, license))
                RefreshAndClose();
        }

        private bool AddDriverToDB(string fullName = "", string license = "")
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            var foundDrivers = db.Drivers.Where(f => f.License == license);
            if(foundDrivers.Count() > 0)
            {
                MainWindow.ShowError("Such a license already exists.");
                return false;
            }
            db.Drivers.Add(new Driver { FullName = fullName, License = license });
            db.SaveChanges();
            return true;
        }

        private void AddDriver_Load(object sender, EventArgs e)
        {
            parentForm.Enabled = false;
        }

        private void AddDriver_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        private void RefreshAndClose()
        {
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshAllTables();
            Close();
        }
    }
}
