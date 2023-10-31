using System;
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
    public partial class frm_implementos : Form
    {
        public frm_implementos()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            txt_codigo.Clear();
            txt_nombre.Clear();
            txt_valor.Clear();
            txt_cantidad.Clear();
            txt_descripcion.Clear();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            cls_implementos obj_guardar = new cls_implementos();
            obj_guardar.fnt_registrar(
            txt_codigo.Text,
            txt_nombre.Text,
            txt_descripcion.Text,
            Convert.ToDouble(txt_valor.Text),
            Convert.ToInt16(txt_cantidad.Text));
        }
    }
}
