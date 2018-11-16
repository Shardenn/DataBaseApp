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
    public partial class InsuranceUpdate : Form
    {
        MainWindow parentForm = null;

        public InsuranceUpdate(Form parent)
        {
            InitializeComponent();
            parentForm = (MainWindow)parent;
            if (parentForm == null)
                MainWindow.ShowWarning("The windows wan not created from Main Window");
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            var idText = textBox_id.Text;
            int id;
            if(!Int32.TryParse(idText, out id))
            {
                MainWindow.ShowError("Invalid ID input");
                return;
            }

            RemoveInsurance(id);
            parentForm.Enabled = true;
            parentForm.RefreshManagementTables();
            Close();
        }

        private void button_addEdit_Click(object sender, EventArgs e)
        {
            var idText = textBox_id.Text;
            DateTime dt = dateTimePicker.Value;
            bool isValid = checkBox_isValid.Checked;

            if(idText == "")
            {
                AddInsurance(dt, isValid);
            }
            else
            {
                int id;
                if(!Int32.TryParse(idText, out id))
                {
                    MainWindow.ShowError("Invalid ID input");
                    return;
                }
                EditInsurance(id, dt, isValid);
            }

            parentForm.Enabled = true;
            parentForm.RefreshManagementTables();
            Close();
        }

        private void AddInsurance(DateTime date, bool isValid)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Insurance ins = new Insurance { InsuranceDate = date, IsValid = isValid };
            db.Insurances.Add(ins);
            db.SaveChanges();
        }

        private void EditInsurance(int id, DateTime date, bool isValid)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Insurance foundIns = db.Insurances.Find(id);

            if(foundIns == null)
            {
                MainWindow.ShowError("No insurance with such a key exists");
                return;
            }

            foundIns.InsuranceDate = date;
            foundIns.IsValid = isValid;

            db.SaveChanges();
        }

        private void RemoveInsurance(int id)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Insurance foundIns = db.Insurances.Find(id);
            if(foundIns == null)
            {
                MainWindow.ShowError("No insurance with such a key exists");
                return;
            }

            db.Insurances.Remove(foundIns);
            db.SaveChanges();
        }

        private void checkBox_leaveDate_CheckedChanged(object sender, EventArgs e)
        {
            var idText = textBox_id.Text;
            int id;
            if(!Int32.TryParse(idText, out id))
            {
                MainWindow.ShowWarning("Invalid ID, could not set an insurance's date");
                return;
            }
            
            RoadPenaltyContext db = new RoadPenaltyContext();
            DateTime dt = db.Insurances.Find(id).InsuranceDate;
            dateTimePicker.Value = dt;
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {
            if (textBox_id.Text == "")
                checkBox_leaveDate.Enabled = false;
            else
                checkBox_leaveDate.Enabled = true;
        }

        private void InsuranceUpdate_Load(object sender, EventArgs e)
        {

        }

        private void InsuranceUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }
    }
}
