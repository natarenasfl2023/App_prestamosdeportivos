﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_prestamos : Form
    {
        public frm_prestamos()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_descripcion.Clear();
            txt_cantidad.Clear();   
            txt_existencias.Clear();    
            txt_identificacion.Clear();
            txt_implemento.Clear();
            txt_nombre.Clear();
            txt_codigo.Clear();
            txt_observaciones.Clear();
            dtg_prestamo = null;
            txt_identificacion.Focus();
        }
    }
}
