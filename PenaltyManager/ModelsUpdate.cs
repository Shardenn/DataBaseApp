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
    public partial class ModelsUpdate : Form
    {
        Form parentForm;

        public ModelsUpdate(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void ModelsUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roadPenaltiesDataSet.Manufacturers' table. You can move, or remove it, as needed.
            this.manufacturersTableAdapter.Fill(this.roadPenaltiesDataSet.Manufacturers);

        }

        private void button_addEdit_Click(object sender, EventArgs e)
        {
            var idText = textBox_id.Text;
            var name = textBox_modelName.Text;
            int man = (int)comboBox_manufacturers.SelectedValue;

            if(idText == "")
            {
                AddModel(name, man);
            }
            else
            {
                int id;
                if(!int.TryParse(idText, out id))
                {
                    MainWindow.ShowError("Invalid ID input");
                    return;
                }
                EditModel(id, name, man);
            }

            parentForm.Enabled = true;
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshUtilityTables();
            Close();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            var idText = textBox_id.Text;
            int id;
            if(!int.TryParse(idText, out id))
            {
                MainWindow.ShowError("No model with such a key exists");
                return;
            }

            RemoveModel(id);

            parentForm.Enabled = true;
            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshUtilityTables();
            Close();

        }

        private void AddModel(string modelName, int manufacturerId)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Model newModel = new Model { Model1 = modelName, Manufacturer_id = manufacturerId };
            newModel.Manufacturer = db.Manufacturers.Find(manufacturerId);
            db.Models.Add(newModel);
            db.SaveChanges();
        }

        private void EditModel(int id, string newName, int newManId)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Model foundModel = db.Models.Find(id);
            if (foundModel == null)
            {
                MainWindow.ShowError("No model with such a key exists");
                return;
            }
            foundModel.Model1 = newName;
            foundModel.Manufacturer_id = newManId;
            foundModel.Manufacturer = db.Manufacturers.Find(newManId);
            db.SaveChanges();
        }

        private void RemoveModel(int id)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Model foundModel = db.Models.Find(id);
            if(foundModel == null)
            {
                MainWindow.ShowError("No model with such a key exists");
                return;
            }
            db.Models.Remove(foundModel);
            db.SaveChanges();
        }

        private void ModelsUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }
    }
}
