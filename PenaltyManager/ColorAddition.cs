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
    public partial class ColorAddition : Form // it is really a color addition
    {
        Form parentForm;
        public ColorAddition(Form parent)
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

            RoadPenaltyContext db = new RoadPenaltyContext();
            Color foundColor = db.Colors.Where(f => f.ColorName == colorName).FirstOrDefault();
            if (foundColor == null)
                AddColor(colorName);
            else
                MainWindow.ShowError("Such a color already exists.");

            MainWindow main = (MainWindow)parentForm;
            if(main != null)
                main.RefreshAllTables();
            Close();
        }
        
        private void AddColor(string newColor)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Color Color = new Color { ColorName = newColor };
            db.Colors.Add(Color);
            db.SaveChanges();
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
