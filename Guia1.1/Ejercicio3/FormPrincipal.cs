using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej6_SistemaPeaje
{
    public partial class FormPrincipal : Form
    {
        Peaje peaje = new Peaje();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarPeaje_Click(object sender, EventArgs e)
        {
            FormRegistroResumenPeaje cargaResumen=new FormRegistroResumenPeaje();

            if (cargaResumen.ShowDialog() == DialogResult.OK)
            {
                int dia = Convert.ToInt32(cargaResumen.nudDia.Value);
                int cantidadVehiculos = Convert.ToInt32(cargaResumen.nudDia.Value);

                peaje.RegistrarResumenDia(dia, cantidadVehiculos);
            }
        }
    }
}
