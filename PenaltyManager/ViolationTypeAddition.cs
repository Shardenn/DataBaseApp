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
    public partial class ViolationTypeAddition : Form
    {
        Form parentForm = null;

        public ViolationTypeAddition(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string newName = textBox_newName.Text;
            string fineStr = textBox_fine.Text;
            if(newName == "")
            {
                MainWindow.ShowError("Please enter new violation type name");
                return;
            }
            int fine;
            if(!int.TryParse(fineStr, out fine))
            {
                MainWindow.ShowError("Please provide a valid fine input. It should be int.");
                return;
            }
            RoadPenaltyContext db = new RoadPenaltyContext();
            ViolationType newViolation = new ViolationType { Type = newName, Fine = fine };
            db.ViolationTypes.Add(newViolation);
            db.SaveChanges();
            UpdateAndClose();
        }

        private void UpdateAndClose()
        {
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshAllTables();
            Close();
        }

        private void ViolationTypeAddition_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }
    }
}
