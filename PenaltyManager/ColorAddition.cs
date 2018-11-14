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
    public partial class ColorAddition : Form
    {
        Form parentForm;
        public ColorAddition(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Color newColor = new Color { ColorName = textBox_input.Text };
            db.Colors.Add(newColor);
            db.SaveChanges();
            parentForm.Enabled = true;
            MainWindow main = (MainWindow)parentForm;
            main.RefreshAllTables();
            Close();
        }
    }
}
