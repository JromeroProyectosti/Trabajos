using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrabajosApp;

namespace TrabajosUI
{
    public partial class GestionCliente : Form
    {
        public GestionCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente objCLiente = new Cliente();
            objCLiente.crearCliente(txtNombre.Text, txtCorreo.Text, txtTelefono.Text);
        }
    }
}
