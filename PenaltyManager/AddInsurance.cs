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
        int driverId = -1;
        public AddInsurance(Form parent, int id)
        {
            InitializeComponent();
            parentForm = parent;
            driverId = id;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker.Value;
            bool isValid = checkBox_isValid.Checked;

            RoadPenaltyContext db = new RoadPenaltyContext();
            Insurance ins = new Insurance { InsuranceDate = dt, IsValid = isValid };
            db.Insurances.Add(ins);
            db.SaveChanges();

            parentForm.Enabled = true;
            //parentForm.RefreshAllTables();
            Close();
        }
    }
}
