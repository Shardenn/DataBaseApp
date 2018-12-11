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
    public partial class EditInsurance : Form
    {
        RoadPenaltyContext db = null;
        Form parentForm = null;

        public EditInsurance(Form parent, RoadPenaltyContext cont)
        {
            InitializeComponent();
            parentForm = parent;
            db = cont;
        }

        private void EditInsurance_Load(object sender, EventArgs e)
        {
            FillComboBox();
            comboBox_numbers.SelectedItem = comboBox_numbers.Items[0];
        }

        private void FillComboBox()
        {
            foreach (var ins in db.Insurances)
            {
                comboBox_numbers.Items.Add(ins.Number);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string number = comboBox_numbers.SelectedItem.ToString();

            var foundIns = db.Insurances.Where(f => f.Number == number);
            if (foundIns.Count() < 1)
            {
                MainWindow.ShowError("Could not find an insurance with such a number to update");
                return;
            }

            DateTime dt = dateTimePicker.Value;
            bool isValid = checkBox_isValid.Checked;

            Insurance ins = db.Insurances.Where(f => f.Number == number).FirstOrDefault();
            ins.IsValid = isValid;
            ins.InsuranceDate = dt;
            Save();

            Close();
        }

        private void Save()
        {
            db.SaveChanges();
            InsurancesManagement form = (InsurancesManagement)parentForm;
            if (form != null)
                form.RefreshGrid();
        }

        private void EditInsurance_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        
    }
}
