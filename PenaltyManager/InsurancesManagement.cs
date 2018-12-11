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
    public partial class InsurancesManagement : Form
    {
        Form parentForm = null;
        RoadPenaltyContext db = null;

        public InsurancesManagement(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
            db = new RoadPenaltyContext();
        }

        private void InsurancesManagement_Load(object sender, EventArgs e)
        {
            FillGridWithInsurances();
        }

        public void FillGridWithInsurances()
        {
            InitGrid();
            RefreshGrid();
        }

        private void InitGrid()
        {
            gridView_insurances.Columns.Clear();
            gridView_insurances.Rows.Clear();

            gridView_insurances.Columns.Add("Insurance number", "Insurance number");
            gridView_insurances.Columns.Add("Created on", "Created on");
            gridView_insurances.Columns.Add("Is valid?", "Is valid?");
        }

        public void RefreshGrid()
        {
            gridView_insurances.Rows.Clear();
            foreach(var ins in db.Insurances)
            {
                gridView_insurances.Rows.Add(ins.Number, ins.InsuranceDate.ToString(), ins.IsValid.ToString());
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AddInsurance form = new AddInsurance(this, db);
            form.Show();
            Enabled = false;
        }

        private void Save()
        {
            db.SaveChanges();
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshAllTables();
            //Close();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            EditInsurance form = new EditInsurance(this, db);
            form.Show();
            Enabled = false;
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            int selectedIndex = gridView_insurances.SelectedCells[0].RowIndex;
            string selectedNumber = gridView_insurances.Rows[selectedIndex].Cells["Insurance number"].Value.ToString();

            Insurance foundIns = db.Insurances.Where(f => f.Number == selectedNumber).FirstOrDefault();
            if(foundIns == null)
            {
                MainWindow.ShowError("Could not find an insurance with a selected number in the data base");
                return;
            }
            db.Insurances.Remove(foundIns);
            Save();
            RefreshGrid();
        }

        private void InsurancesManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        
    }
}
