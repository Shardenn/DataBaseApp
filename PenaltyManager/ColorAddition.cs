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
    public partial class ManufacturerAddition : Form // it is really a color addition
    {
        Form parentForm;
        public ManufacturerAddition(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        // add/edit button
        private void button_add_Click(object sender, EventArgs e)
        {
            var colorName = textBox_input.Text;
            if(colorName == "")
            {
                MainWindow.ShowError("Provide new color name", "Error");
                return;
            }

            var idText = textBox_id.Text;
            if(idText != "")
            {
                int id;
                if(!Int32.TryParse(idText, out id))
                {
                    MainWindow.ShowError("Provide valid input");
                    return;
                }
                EditColor(id, colorName);
            }
            else
                AddColor(colorName);

            parentForm.Enabled = true;

            MainWindow main = (MainWindow)parentForm;
            if(main != null)
                main.RefreshUtilityTables();
            Close();
        }

        // remove button
        private void button1_Click(object sender, EventArgs e)
        {
            var idText = textBox_id.Text;
            var colorName = textBox_input.Text;

            if (idText == "")
            {
                MainWindow.ShowError("Provide valid input", "Wrong input");
                return;
            }

            int id;
            if (!Int32.TryParse(idText, out id))
            {
                MainWindow.ShowError("Wrong ID input", "Error");
                return;
            }
            
            RemoveColor(id);

            parentForm.Enabled = true;

            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshUtilityTables();
            Close();
        }

        private void AddColor(string newColor)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Color Color = new Color { ColorName = newColor };
            db.Colors.Add(Color);
            db.SaveChanges();
        }

        private void EditColor(int id, string newColor)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();

            Color colorToUpdate = db.Colors.Find(id);
            if(colorToUpdate == null)
            {
                MainWindow.ShowError("No color with such a key exists");
                return;
            }

            colorToUpdate.ColorName = newColor;
            db.SaveChanges();
        }

        private void RemoveColor(int id)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Color foundColor = db.Colors.Find(id);
            if(foundColor == null)
            {
                MainWindow.ShowError("No color with such a key exists");
                return;
            }
            db.Colors.Remove(foundColor);
            db.SaveChanges();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ManufacturerAddition_Load(object sender, EventArgs e)
        {

        }

        private void ManufacturerAddition_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }
    }
}
