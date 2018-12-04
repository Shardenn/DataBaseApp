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
    public partial class ModelsAddition : Form
    {
        Form parentForm = null;

        public ModelsAddition(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void ModelsAddition_Load(object sender, EventArgs e)
        {
            comboBox_manufacturers.Items.Clear();
            RoadPenaltyContext db = new RoadPenaltyContext();
            db.Manufacturers.ToList().ForEach(f => comboBox_manufacturers.Items.Add(f.ManufacturerName));
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string name = textBox_modelName.Text;
            if(name == "")
            {
                MainWindow.ShowError("A new name should be provided.");
                return;
            }
            string manufacturer = comboBox_manufacturers.SelectedItem.ToString();

            RoadPenaltyContext db = new RoadPenaltyContext();
            Manufacturer foundMan = db.Manufacturers.Where(f => f.ManufacturerName == manufacturer).FirstOrDefault();
            if(foundMan == null)
            {
                MainWindow.ShowError("Could not find a manufacturer to add the model");
                return;
            }
            Model model = new Model { Model1 = name, Manufacturer = foundMan };
            db.Models.Add(model);
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

        private void ModelsAddition_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        
    }
}
