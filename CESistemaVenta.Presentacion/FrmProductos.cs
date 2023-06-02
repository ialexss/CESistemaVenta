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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMarca childForm = new FrmMarca();
            childForm.Text = "Ventana agregar marca ";
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAlmacen childForm = new FrmAlmacen();
            childForm.Text = "Ventana agregar almacen ";
            childForm.Show();
        }
    }
}
