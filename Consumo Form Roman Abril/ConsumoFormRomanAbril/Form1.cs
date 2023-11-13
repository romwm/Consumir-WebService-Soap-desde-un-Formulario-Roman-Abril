using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoFormRomanAbril
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cotizacion.TipoCambio client = new Cotizacion.TipoCambio();
            var respuesta = client.TipoCambioDia();
            var fecha = (respuesta.CambioDolar.First().fecha);
            var cotizaciondia = (respuesta.CambioDolar.First().referencia);

            dia.Text = respuesta.CambioDolar.First().fecha;
            cotdia.Text= cotizaciondia.ToString();


        }

        
    }
}
