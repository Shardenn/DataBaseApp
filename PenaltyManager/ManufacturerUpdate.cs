﻿using System;
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
    public partial class ManufacturerUpdate : Form
    {
        Form parentForm = null;

        public ManufacturerUpdate(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        // remove button
        private void button_editRemove_Click(object sender, EventArgs e)
        {
            var idText = textBox_oldName.Text;
            var colorName = textBox_input.Text;
            
            int id;
            if (!Int32.TryParse(idText, out id))
            {
                MainWindow.ShowError("Wrong ID input", "Error");
                return;
            }

            RemoveManufacturer(id);

            parentForm.Enabled = true;

            MainWindow main = (MainWindow)parentForm;
            if (main != null)
                main.RefreshAllTables();
            Close();
        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // update button
        private void button_add_Click(object sender, EventArgs e)
        {
            string oldName = textBox_oldName.Text;
            RoadPenaltyContext db = new RoadPenaltyContext();
            Manufacturer foundMan = db.Manufacturers.Where(f => f.ManufacturerName == oldName).FirstOrDefault();
            if(foundMan == null)
            {
                MainWindow.ShowError("Could not find the manufacturer with name " + oldName);
                return;
            }

            foundMan.ManufacturerName = textBox_newName.Text;
            db.SaveChanges();

            parentForm.Enabled = true;
            MainWindow main = (MainWindow)parentForm;
            main.RefreshAllTables();
            Close();
        }

        private void AddManufacturer(string manufacturerName)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Manufacturer manufacturer = new Manufacturer { ManufacturerName = manufacturerName };
            db.Manufacturers.Add(manufacturer);
            db.SaveChanges();
        }

        private void EditManufacturer(int id, string newName)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();

            Manufacturer manToUpdate = db.Manufacturers.Find(id);
            if(manToUpdate == null)
            {
                MainWindow.ShowError("No manufacturer with such a key exists");
                return;
            }

            manToUpdate.ManufacturerName = newName;
            db.SaveChanges();
        }

        private void RemoveManufacturer(int id)
        {
            RoadPenaltyContext db = new RoadPenaltyContext();
            Manufacturer foundMan = db.Manufacturers.Find(id);

            if(foundMan == null)
            {
                MainWindow.ShowError("No manufacturer with such a key exists");
                return;
            }

            db.Manufacturers.Remove(foundMan);
            db.SaveChanges();
        }

        private void ManufacturerUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }
    }
}
