using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrabajosApp;
using TrabajosEntity;

namespace TrabajosUI
{
    public partial class GestionCliente : Form
    {
        public GestionCliente()
        {
            InitializeComponent();
            listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente objCLiente = new Cliente();
            objCLiente.CrearCliente(txtNombre.Text, txtCorreo.Text, txtTelefono.Text);

            listar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Cliente objcl = new Cliente();
            CLIENTE entCli = new CLIENTE();
            entCli=objcl.BuscarCliente(txtNombre.Text);
            if (entCli != null)
            {
                txtCorreo.Text = entCli.Correo;
                txtTelefono.Text = entCli.Telefono;
            }
            else
            {
                txtCorreo.Text = "";
                txtTelefono.Text = "";
            }
        }
        private void listar()
        {
            Cliente cl=new Cliente();


            try
            {
                DetalleCliente.DataSource = cl.BuscarCliente();

            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
