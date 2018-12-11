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
    public partial class AddInsurance : Form
    {
        Form parentForm = null;
        RoadPenaltyContext db = null;

        public AddInsurance(Form parent, RoadPenaltyContext cont)
        {
            InitializeComponent();
            parentForm = parent;
            db = cont;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string number = textBox_number.Text;

            var foundIns = db.Insurances.Where(f => f.Number == number);
            if(foundIns.Count() > 0)
            {
                MainWindow.ShowError("An insurance with such a number already exists.");
                return;
            }

            DateTime dt = dateTimePicker.Value;
            bool isValid = checkBox_isValid.Checked;
            
            Insurance ins = new Insurance { InsuranceDate = dt, IsValid = isValid, Number = number };
            db.Insurances.Add(ins);
            db.SaveChanges();

            
            Close();
        }

        private void button_dateNow_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;
        }

        private void AddInsurance_FormClosed(object sender, FormClosedEventArgs e)
        {
            InsurancesManagement form = (InsurancesManagement)parentForm;
            if (form != null)
                form.RefreshGrid();
            parentForm.Enabled = true;
        }
    }
}
