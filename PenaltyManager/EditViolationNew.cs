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
    public partial class EditViolationNew : Form
    {
        Form parentForm;

        public EditViolationNew(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void EditViolationNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roadPenaltiesDataSet.Violation' table. You can move, or remove it, as needed.
            this.violationTableAdapter.Fill(this.roadPenaltiesDataSet.Violation);
            // TODO: This line of code loads data into the 'roadPenaltiesDataSet.Automobile' table. You can move, or remove it, as needed.
            this.automobileTableAdapter.Fill(this.roadPenaltiesDataSet.Automobile);
            // TODO: This line of code loads data into the 'roadPenaltiesDataSet.Driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.roadPenaltiesDataSet.Driver);

            fill_violation_combobox();
            comboBox_violationType.SelectedIndex = comboBox_violationType.Items.Count - 1;
            update_driver_info();
            update_car_info();
            update_fine_info();
        }

        private void fill_violation_combobox()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            comboBox_violationType.Items.Clear();
            db.ViolationTypes.ToList().ForEach(e => comboBox_violationType.Items.Add(e.Type));
        }

        private void update_driver_info()
        {
            if (comboBox_driverID.SelectedValue == null)
                return;

            RoadPenaltyContext db = new RoadPenaltyContext();
            Driver driver = db.Drivers.Find((int)comboBox_driverID.SelectedValue);
            label_driverName.Text = driver.FullName;
            label_driverLicense.Text = driver.License;
        }

        private void update_car_info()
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            if (comboBox_carID.SelectedValue == null)
                return;

            Automobile car = db.Automobiles.Find((int)comboBox_carID.SelectedValue);
            label_carManufacturer.Text = car.Model.Manufacturer.ManufacturerName;
            label_carModel.Text = car.Model.Model1;
            label_carNumber.Text = car.Number;
        }

        private void update_fine_info()
        {
            if (comboBox_violationType.SelectedItem == null)
                return;

            RoadPenaltyContext db = new RoadPenaltyContext();
            ViolationType type = db.ViolationTypes.Find(comboBox_violationType.SelectedItem);
            label_fine.Text = type.Fine.ToString();
        }

        private void comboBox_driverID_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_driver_info();
        }

        private void comboBox_carID_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_car_info();
        }

        private void comboBox_violationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_fine_info();
        }

        private void button_editViolation_Click(object sender, EventArgs e)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Violation vio = db.Violations.Find(comboBox_violationID.SelectedValue);
            vio.Driver_id = (int)comboBox_driverID.SelectedValue;
            vio.Driver = db.Drivers.Find(vio.Driver_id);
            vio.Automobile_id = (int)comboBox_carID.SelectedValue;
            vio.Automobile = db.Automobiles.Find(vio.Automobile_id);
            vio.ViolationType = db.ViolationTypes.Find(comboBox_violationType.SelectedItem);
            vio.Type = vio.ViolationType.Type;
            db.SaveChanges();

            parentForm.Enabled = true;
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshAllTables();

            Close();
        }

        private void EditViolationNew_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }
    }
}
