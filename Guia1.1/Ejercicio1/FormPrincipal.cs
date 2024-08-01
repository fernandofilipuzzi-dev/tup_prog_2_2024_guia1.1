using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
            
        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            string marca = tbMarca.Text;
            int modelo = Convert.ToInt32(nupModelo.Value);
            int añoACalcular = Convert.ToInt32(nupAñoCalcular.Value);
            double valorFabrica = Convert.ToDouble(tbValorFabrica.Text);
            int vidaUtil = Convert.ToInt32(tbValorFabrica.Text);
            double tasaDepreciacion = Convert.ToDouble(tbValorFabrica.Text);

            Moto m = new Moto(marca, modelo, valorFabrica);
            

            FormVer fVer = new FormVer();
            fVer.lbxResultados.Items.Add(m.VerDescripcion());

            double valorLineal = m.CalcularDepreciacionLineal(añoACalcular,vidaUtil);
            fVer.lbxResultados.Items.Add($"Depreciación lineal: ${valorLineal,10:f2}");

            double valorAnual = m.CalcularDepreciacionAnual(añoACalcular, tasaDepreciacion);
            fVer.lbxResultados.Items.Add($"Depreciación anual: ${valorAnual,10:f2}");

            fVer.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
