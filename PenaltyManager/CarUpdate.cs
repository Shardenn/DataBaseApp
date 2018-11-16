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
    public partial class CarUpdate : Form
    {
        Form parentForm = null;

        public CarUpdate(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void CarUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roadPenaltiesDataSet.Insurance' table. You can move, or remove it, as needed.
            this.insuranceTableAdapter.Fill(this.roadPenaltiesDataSet.Insurance);
            // TODO: This line of code loads data into the 'roadPenaltiesDataSet.Colors' table. You can move, or remove it, as needed.
            this.colorsTableAdapter.Fill(this.roadPenaltiesDataSet.Colors);
            // TODO: This line of code loads data into the 'roadPenaltiesDataSet.Manufacturers' table. You can move, or remove it, as needed.
            this.manufacturersTableAdapter.Fill(this.roadPenaltiesDataSet.Manufacturers);
            fill_form_with_default_data();
        }

        private void fill_form_with_default_data()
        {
            
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            var idText = textBox_id.Text;
            int id;
            if(!int.TryParse(idText, out id))
            {
                MainWindow.ShowError("Invalid ID input");
                return;
            }
            RemoveCar(id);

            parentForm.Enabled = true;
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshManagementTables();
            Close();
        }

        private void button_addEdit_Click(object sender, EventArgs e)
        {
            var idText = textBox_id.Text;
            if(idText == "")
            {
                //try
                //{
                    AddCar(textBox_carNumber.Text,
                        int.Parse(comboBox_assignedIns.SelectedValue.ToString()),
                        int.Parse(textBox_insValue.Text),
                        int.Parse(comboBox_manufacturer.SelectedValue.ToString()),
                        int.Parse(comboBox_color.SelectedValue.ToString()));
                    /*
                }
                catch (Exception exc)
                {
                    MainWindow.ShowError(exc.ToString());
                    return;
                }*/
            }
            else
            {
                int id = int.Parse(idText);
                EditCar(id,
                        textBox_carNumber.Text,
                        int.Parse(comboBox_assignedIns.SelectedValue.ToString()),
                        int.Parse(textBox_insValue.Text),
                        int.Parse(comboBox_manufacturer.SelectedValue.ToString()),
                        int.Parse(comboBox_color.SelectedValue.ToString()));
            }

            parentForm.Enabled = true;
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshManagementTables();
            Close();
        }

        private void AddCar(string number, int insId, int insValue, int manufacturerlId, int colorId)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Automobile car = new Automobile();

            car.Number = number;
            car.Insurance_id = insId;
            Insurance ins = db.Insurances.Find(insId);
            car.Insurance = ins;

            car.InsuranceValue = insValue;

            Model model = new Model { Model1 = "NewName" };
            Manufacturer man = db.Manufacturers.Find(manufacturerlId);
            model.Manufacturer = man;
            Model inserted = db.Models.Add(model);
            db.SaveChanges();
            car.Model_id = inserted.Id;
            car.Model = inserted;
            
            car.Color_id = colorId;
            Color color = db.Colors.Find(colorId);
            car.Color = color;

            db.Automobiles.Add(car);
            db.SaveChanges();
        }

        private void EditCar(int id, string number, int insId, int insValue, int manufacturerId, int colorId)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Automobile car = db.Automobiles.Find(id);
            if (car == null)
            {
                MainWindow.ShowError("No car has such a key");
                return;
            }
            car.Insurance_id = insId;
            car.InsuranceValue = insValue;
            car.Model_id = manufacturerId;
            car.Color_id = colorId;
            car.Number = number;
            db.SaveChanges();
        }

        private void RemoveCar(int id)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Automobile car = db.Automobiles.Find(id);
            if(car == null)
            {
                MainWindow.ShowError("No car has such a key");
                return;
            }
            db.Automobiles.Remove(car);
            db.SaveChanges();
        }

        private void CarUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }
    }
}
