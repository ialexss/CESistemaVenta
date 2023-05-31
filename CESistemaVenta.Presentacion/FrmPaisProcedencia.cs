using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CESistemaVenta.Datos;
using CESistemaVenta.Negocio;


namespace CESistemaVenta.Presentacion
{
    public partial class FrmPaisProcedencia : Form
    {
        public FrmPaisProcedencia()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            NPaisProcedencia objNPaisProcedencia = new NPaisProcedencia();
            PaisProcedencia objPaisProcedencia = new PaisProcedencia();

            objPaisProcedencia.Id = objNPaisProcedencia.GenerarId();
            objPaisProcedencia.NombrePais = txbNombre.Text;

            if (objNPaisProcedencia.InsertarPaisProcedencia(objPaisProcedencia))
            {
                MessageBox.Show("País de procedencia agregado con exito");
            }
            else
            {
                MessageBox.Show("Error al agregar el país de procedencia");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NPaisProcedencia objNPaisProcedencia = new NPaisProcedencia();
            int id;
            if(int.TryParse(this.txbBuscar.Text, out id))
            {
                this.dataGridView1.DataSource = objNPaisProcedencia.TraerPaisProcedencia(id);
            }
            else
            { 
                this.dataGridView1.DataSource = objNPaisProcedencia.TraerPaisProcedenciaPorNombre(this.txbBuscar.Text);
            }
        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {
            NPaisProcedencia objNPaisProcedencia = new NPaisProcedencia();
            this.dataGridView1.DataSource = objNPaisProcedencia.TraerPaisProcedenciaPorNombre(this.txbNombre.Text);
        }
    }
}
