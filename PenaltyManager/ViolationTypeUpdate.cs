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
    public partial class ViolationTypeUpdate : Form
    {
        Form parentForm = null;

        public ViolationTypeUpdate(Form form)
        {
            InitializeComponent();
            parentForm = form;

            comboBox_violationTypes.Items.Clear();
            RoadPenaltyContext db = new RoadPenaltyContext();
            db.ViolationTypes.ToList().ForEach(e => comboBox_violationTypes.Items.Add(e.Type));
            
        }

        // remove/edit
        private void button_remove_Click(object sender, EventArgs e)
        {
            var nameInput = comboBox_violationTypes.Text;
            var fineInput = textBox_fine.Text;

            if (nameInput == "")
            {
                MainWindow.ShowError("Violation type is empty");
                return;
            }

            if (fineInput == "")
            {
                RemoveViolationType(nameInput);
            }
            else
            {
                int fine;
                if (!Int32.TryParse(fineInput, out fine))
                {
                    MainWindow.ShowError("Wrong fine input");
                    return;
                }

                EditViolationType(nameInput, fine);
            }

            parentForm.Enabled = true;
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshUtilityTables();
            Close();
        }
        
        // add button
        private void button_update_Click(object sender, EventArgs e)
        {
            var name = textBox_violationType.Text;
            var fineInput = textBox_fine.Text;

            if(name == "" || fineInput == "")
            {
                MainWindow.ShowError("Provide non-empty input");
                return;
            }

            int fine;
            if(!Int32.TryParse(fineInput, out fine))
            {
                MainWindow.ShowError("Wrong fine input");
                return;
            }
            
            AddViolationType(name, fine);

            parentForm.Enabled = true;
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshUtilityTables();
            Close();
        }

        private void AddViolationType(string name, int fine)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            ViolationType newViol = new ViolationType { Type = name, Fine = fine };
            db.ViolationTypes.Add(newViol);
            db.SaveChanges();
        }

        private void EditViolationType(string name, int newFine)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            ViolationType foundViol = db.ViolationTypes.Find(name);

            if(foundViol == null)
            {
                MainWindow.ShowError("No violation type with such a key exists");
                return;
            }

            foundViol.Fine = newFine;
            db.SaveChanges();
        }

        private void RemoveViolationType(string name)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            ViolationType foundType = db.ViolationTypes.Find(name);
            if(foundType == null)
            {
                MainWindow.ShowError("No such a violation type exists");
                return;
            }

            db.ViolationTypes.Remove(foundType);
            db.SaveChanges();
        }

        private void ViolationTypeUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        private void comboBox_violationTypes_DrawItem(object sender, DrawItemEventArgs e)
        {

        }
    }
}
