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
    public partial class DriversUpdate : Form
    {
        Form parentForm = null;

        public DriversUpdate(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void button_addEdit_Click(object sender, EventArgs e)
        {
            var idText = textBox_id.Text;
            var name = textBox_fullName.Text;
            var license = textBox_license.Text;
            
            if(idText == "")
            {
                AddDriver(name, license);
            }
            else
            {
                int id;
                if(!Int32.TryParse(idText, out id))
                {
                    MainWindow.ShowError("Invalid ID input");
                    return;
                }
                EditDriver(id, name, license);
            }

            parentForm.Enabled = true;
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshManagementTables();
            Close();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            var idText = textBox_id.Text;
            int id;
            if(!Int32.TryParse(idText, out id))
            {
                MainWindow.ShowError("Invalid id input");
                return;
            }
            RemoveDriver(id);

            parentForm.Enabled = true;
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshManagementTables();
            Close();
        }

        private void AddDriver(string fullName = "", string license = "")
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            db.Drivers.Add(new Driver { FullName = fullName, License = license });
            db.SaveChanges();
        }

        private void EditDriver(int id, string newName, string newLicense)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Driver foundDriver = db.Drivers.Find(id);
            if(foundDriver == null)
            {
                MainWindow.ShowError("No driver with such a key exists");
                return;
            }

            if (newName == "")
                MainWindow.ShowWarning("Name field is empty. Leaving it as it was");
            else
                foundDriver.FullName = newName;

            if (newLicense == "")
                MainWindow.ShowWarning("License field is empty. Leaving it as it was");
            else
                foundDriver.License = newLicense;

            db.SaveChanges();
        }

        private void RemoveDriver(int id)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Driver foundDriver = db.Drivers.Find(id);
            if(foundDriver == null)
            {
                MainWindow.ShowError("No driver with such a key exists");
                return;
            }

            db.Drivers.Remove(foundDriver);
            db.SaveChanges();
        }

        private void DriversUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }
    }
}
