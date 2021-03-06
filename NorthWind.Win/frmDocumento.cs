﻿
using NorthWind.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind.Win
{
    public partial class frmDocumento : Form
    {
        public frmDocumento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton mostrar formulario Clientes
            frmCliente ofrmCliente = new frmCliente();
            ofrmCliente.OnClienteSeleccionado += new EventHandler<Entity.TbClienteBE>(MetodoCliente);
            ofrmCliente.Show();
        }

        TbClienteBE otmpCliente; //Variable Temporal
        void MetodoCliente(object sender, TbClienteBE e)
        {
            txtcliente.Text = e.Nombre;
            txtruc.Text = e.Apellido;
            otmpCliente = e;
        }
    }
}
