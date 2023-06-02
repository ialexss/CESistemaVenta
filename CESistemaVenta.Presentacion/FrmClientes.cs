using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CESistemaVenta.Presentacion
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmClienteNatural childForm = new FrmClienteNatural();
            childForm.Text = "Ventana agregar cliente natural ";
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmClienteJuridico childForm = new FrmClienteJuridico();
            childForm.Text = "Ventana agregar cliente juridico ";
            childForm.Show();
        }
    }
}
