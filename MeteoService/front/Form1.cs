using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace front
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ServiceReference1.CondicionesActuales condicionesActuales= new ServiceReference1.CondicionesActuales();
        private async void buttonSolicitar_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference1.MeteoServicesvcClient client = new ServiceReference1.MeteoServicesvcClient();
                string Ciudad = textBoxCiudad.Text;

                var condicionesActuales = await Task.Run(() => client.GetCondicionesActuales(Ciudad));

                labelTemperature.Text = "Temperature:        " + condicionesActuales.Temperature;
                labelDescription.Text = "Description:        " + condicionesActuales.Description;
                labelWind.Text = "Wind:               " + condicionesActuales.Wind;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
