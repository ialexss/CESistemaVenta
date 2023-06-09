﻿using System;
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
    public partial class FrmFormularioPrincipal : Form
    {
        private int childFormNumber = 0;

        public FrmFormularioPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            FrmPaisProcedencia childForm = new FrmPaisProcedencia();
            childForm.Text = "Ventana agregar país de procedencia ";
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void agregarNuevaMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarca childForm = new FrmMarca();
            childForm.Text = "Ventana agregar marca ";
            childForm.Show();
        }

        private void agregarAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlmacen childForm = new FrmAlmacen();
            childForm.Text = "Ventana agregar almacen ";
            childForm.Show();
        }

        private void agregarClienteNaturalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteNatural childForm = new FrmClienteNatural();
            childForm.Text = "Ventana agregar cliente natural ";
            childForm.Show();
        }

        private void agregarClienteJuridicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteJuridico childForm = new FrmClienteJuridico();
            childForm.Text = "Ventana agregar cliente juridico ";
            childForm.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes childForm = new FrmClientes();
            childForm.Text = "Ventana gestionar clientes ";
            childForm.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas childForm = new FrmVentas();
            childForm.Text = "Ventana gestionar ventas ";
            childForm.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos childForm = new FrmProductos();
            childForm.Text = "Ventana gestionar productos ";
            childForm.Show();
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            FrmGestionarAlmacen childForm = new FrmGestionarAlmacen();
            childForm.Text = "Ventana gestionar almacén ";
            childForm.Show();
        }
    }
}
