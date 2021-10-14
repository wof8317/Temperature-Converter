using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celsius_Fahrenheit_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCtoF_Click(object sender, EventArgs e)
        {// Convert to Fahrenheit and display the conversion result.
            double convertToFahrenheit;
            convertToFahrenheit = (Convert.ToDouble(txtTemperature.Text) * 9 / 5) + 32;
            txtConverted.Text = convertToFahrenheit.ToString("");
        }

        private void btnFtoC_Click(object sender, EventArgs e)
        {// Convert to Celsius and display the conversion result.
            double convertToCelsius;
            convertToCelsius = (Convert.ToDouble(txtTemperature.Text) - 32) * 5 / 9;
            txtConverted.Text = convertToCelsius.ToString("");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {// Clears all the text boxes so that one can start anew.
            txtTemperature.Clear();
            txtConverted.Clear();
        }
    }
}
