using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caso_4_paol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Capturando los valores del formulario
            int numFactura = int.Parse(txtNumFact.Text);
            DateTime fechaFact = DateTime.Parse(txtFechaFact.Text);
            double montoFact = double.Parse(txtMontoFact.Text);

            //Objeto de la clase Factura
            Factura objF = new Factura(numFactura, fechaFact, montoFact);

            //Imprimiendo en la lista
            ListViewItem fila = new ListViewItem(objF.numFactura.ToString());
            fila.SubItems.Add(objF.fechaFact.ToShortDateString());
            fila.SubItems.Add(objF.montoFact.ToString("C"));
            lvFacturas.Items.Add(fila);

            //Mostrando los montos
            lblTotalFact.Text = objF.totalFacturas().ToString();
            lblTotalSub.Text = objF.calculaTotalSubtotal().ToString("C");
            lblComision.Text = objF.calculaComision().ToString("C");

        }
        //Función lambda que muestra la fecha actual
        Func<String> muestraFecha = () => DateTime.Now.ToShortDateString();

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = muestraFecha();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
