using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleeApp
{
    public partial class VehicleUI : Form
    {
        public VehicleUI()
        {
            InitializeComponent();
               
        }

        private Vehicle aVehicle;
        private void createButton_Click(object sender, EventArgs e)
        {
            aVehicle = new Vehicle(Convert.ToString(vehiclenameTextBox.Text),
                   Convert.ToInt32(registrationnoTextBox.Text));
             
            MessageBox.Show("Created");
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
           aVehicle = new Vehicle(Convert.ToDouble(speedTextBox.Text));
        
            aVehicle.MaxSpeed();
            aVehicle.MinSpeed();
            MessageBox.Show("Entered");
       
        }

        private void showButton_Click(object sender, EventArgs e)
        {          
           maxspeedTextBox.Text = Convert.ToString(aVehicle.MaxSpeed());
           minspeedTextBox.Text = Convert.ToString(aVehicle.MinSpeed());
           averagespeedTextBox.Text = Convert.ToString(aVehicle.AverageSpeed());       
           // MessageBox.Show("Entered");
        }
       
    }
}

