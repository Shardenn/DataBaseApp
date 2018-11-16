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
    public partial class RemoveViolation : Form
    {
        Form parentForm = null;

        public RemoveViolation(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void RemoveViolation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roadPenaltiesDataSet.Violation' table. You can move, or remove it, as needed.
            this.violationTableAdapter.Fill(this.roadPenaltiesDataSet.Violation);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox_violationsID.SelectedItem == null)
            {
                MainWindow.ShowError("Could not get violation ID");
                return;
            }
            else
            {
                RoadPenaltyContext db = new RoadPenaltyContext();
                Violation vio = db.Violations.Find(comboBox_violationsID.SelectedValue);
                db.Violations.Remove(vio);
                db.SaveChanges();
            }

            parentForm.Enabled = true;
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshAllTables();
            Close();
        }

        private void RemoveViolation_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }
    }
}
