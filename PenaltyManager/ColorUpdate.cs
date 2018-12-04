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
    public partial class ColorUpdate : Form
    {
        Form parentForm = null;

        public ColorUpdate(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string oldName = textBox_oldName.Text;
            RoadPenaltyContext db = new RoadPenaltyContext();
            Color foundColor = db.Colors.Where(f => f.ColorName == oldName).FirstOrDefault();
            if(foundColor == null)
            {
                MainWindow.ShowError("No color with such a name found");
                return;
            }
            //UpdateColor(db, foundColor, textBox_newName.Text);

            foundColor.ColorName = textBox_newName.Text;
            db.SaveChanges();

            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshAllTables();

            Close();
        }

        private void UpdateColor(RoadPenaltyContext db, Color oldColor, string newName)
        {
            oldColor.ColorName = newName;
            db.SaveChanges();
        }

        private void ColorUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }
    }
}
