using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleSpeedCalculatorApp
{
    public partial class VehicleSpeedCalculatorUI : Form
    {
        Vehicle aVehicle;

        public VehicleSpeedCalculatorUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            aVehicle = new Vehicle();
            aVehicle.name = vehicleNameTextBox.Text;
            aVehicle.regNo = regNoTextBox.Text;

            MessageBox.Show("Created successfully!");
            vehicleNameTextBox.Text = "";
            regNoTextBox.Text = "";
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (aVehicle == null)
            {
                MessageBox.Show("Create vehicle first!");
                return;
            }

            double speed = Convert.ToDouble(addSpeedTextBox.Text);
            aVehicle.SetSpeed(speed);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            double minSpeed = aVehicle.GetMinSpeed();
            double maxSpeed = aVehicle.GetMaxSpeed();
            double avgSpeed = aVehicle.GetAvgSpeed();

            minSpeedTextBox.Text = minSpeed.ToString("0.00");
            maxSpeedTextBox.Text = maxSpeed.ToString("0.00");
            avgSpeedTextBox.Text = avgSpeed.ToString("0.00");
        }
    }
}
