namespace Presentacion
{
    partial class frm_modulo_usuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_primernombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_segundonombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_primerapellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_identificacion = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_segundoapellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_contacto = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_correo = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_sexo = new MaterialSkin.Controls.MaterialComboBox();
            this.tblsexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbs_prestamos_deportivosDataSet = new Presentacion.dbs_prestamos_deportivosDataSet();
            this.txt_direccion = new MaterialSkin.Controls.MaterialTextBox();
            this.tbl_sexoTableAdapter = new Presentacion.dbs_prestamos_deportivosDataSetTableAdapters.tbl_sexoTableAdapter();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.tblsexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(292, 20);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(146, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Registro de Usuarios";
            // 
            // txt_primernombre
            // 
            this.txt_primernombre.AnimateReadOnly = false;
            this.txt_primernombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_primernombre.Depth = 0;
            this.txt_primernombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_primernombre.Hint = "Primer Nombre";
            this.txt_primernombre.LeadingIcon = null;
            this.txt_primernombre.Location = new System.Drawing.Point(261, 51);
            this.txt_primernombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_primernombre.MaxLength = 50;
            this.txt_primernombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_primernombre.Multiline = false;
            this.txt_primernombre.Name = "txt_primernombre";
            this.txt_primernombre.Size = new System.Drawing.Size(220, 50);
            this.txt_primernombre.TabIndex = 2;
            this.txt_primernombre.Text = "";
            this.txt_primernombre.TrailingIcon = null;
            this.txt_primernombre.TextChanged += new System.EventHandler(this.materialTextBox2_TextChanged);
            // 
            // txt_segundonombre
            // 
            this.txt_segundonombre.AnimateReadOnly = false;
            this.txt_segundonombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_segundonombre.Depth = 0;
            this.txt_segundonombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_segundonombre.Hint = "Segundo Nombre";
            this.txt_segundonombre.LeadingIcon = null;
            this.txt_segundonombre.Location = new System.Drawing.Point(496, 51);
            this.txt_segundonombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_segundonombre.MaxLength = 50;
            this.txt_segundonombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_segundonombre.Multiline = false;
            this.txt_segundonombre.Name = "txt_segundonombre";
            this.txt_segundonombre.Size = new System.Drawing.Size(220, 50);
            this.txt_segundonombre.TabIndex = 3;
            this.txt_segundonombre.Text = "";
            this.txt_segundonombre.TrailingIcon = null;
            // 
            // txt_primerapellido
            // 
            this.txt_primerapellido.AnimateReadOnly = false;
            this.txt_primerapellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_primerapellido.Depth = 0;
            this.txt_primerapellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_primerapellido.Hint = "Primer Apellido";
            this.txt_primerapellido.LeadingIcon = null;
            this.txt_primerapellido.Location = new System.Drawing.Point(28, 116);
            this.txt_primerapellido.Margin = new System.Windows.Forms.Padding(2);
            this.txt_primerapellido.MaxLength = 50;
            this.txt_primerapellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_primerapellido.Multiline = false;
            this.txt_primerapellido.Name = "txt_primerapellido";
            this.txt_primerapellido.Size = new System.Drawing.Size(220, 50);
            this.txt_primerapellido.TabIndex = 4;
            this.txt_primerapellido.Text = "";
            this.txt_primerapellido.TrailingIcon = null;
            // 
            // txt_identificacion
            // 
            this.txt_identificacion.AnimateReadOnly = false;
            this.txt_identificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_identificacion.Depth = 0;
            this.txt_identificacion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_identificacion.Hint = "Identificación";
            this.txt_identificacion.LeadingIcon = null;
            this.txt_identificacion.Location = new System.Drawing.Point(28, 51);
            this.txt_identificacion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_identificacion.MaxLength = 50;
            this.txt_identificacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_identificacion.Multiline = false;
            this.txt_identificacion.Name = "txt_identificacion";
            this.txt_identificacion.Size = new System.Drawing.Size(220, 50);
            this.txt_identificacion.TabIndex = 6;
            this.txt_identificacion.Text = "";
            this.txt_identificacion.TrailingIcon = null;
            // 
            // txt_segundoapellido
            // 
            this.txt_segundoapellido.AnimateReadOnly = false;
            this.txt_segundoapellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_segundoapellido.Depth = 0;
            this.txt_segundoapellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_segundoapellido.Hint = "Segundo Apellido";
            this.txt_segundoapellido.LeadingIcon = null;
            this.txt_segundoapellido.Location = new System.Drawing.Point(261, 116);
            this.txt_segundoapellido.Margin = new System.Windows.Forms.Padding(2);
            this.txt_segundoapellido.MaxLength = 50;
            this.txt_segundoapellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_segundoapellido.Multiline = false;
            this.txt_segundoapellido.Name = "txt_segundoapellido";
            this.txt_segundoapellido.Size = new System.Drawing.Size(220, 50);
            this.txt_segundoapellido.TabIndex = 7;
            this.txt_segundoapellido.Text = "";
            this.txt_segundoapellido.TrailingIcon = null;
            // 
            // txt_contacto
            // 
            this.txt_contacto.AnimateReadOnly = false;
            this.txt_contacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contacto.Depth = 0;
            this.txt_contacto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_contacto.Hint = "Contacto";
            this.txt_contacto.LeadingIcon = null;
            this.txt_contacto.Location = new System.Drawing.Point(496, 116);
            this.txt_contacto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_contacto.MaxLength = 50;
            this.txt_contacto.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_contacto.Multiline = false;
            this.txt_contacto.Name = "txt_contacto";
            this.txt_contacto.Size = new System.Drawing.Size(220, 50);
            this.txt_contacto.TabIndex = 8;
            this.txt_contacto.Text = "";
            this.txt_contacto.TrailingIcon = null;
            // 
            // txt_correo
            // 
            this.txt_correo.AnimateReadOnly = false;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Depth = 0;
            this.txt_correo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_correo.Hint = "Correo";
            this.txt_correo.LeadingIcon = null;
            this.txt_correo.Location = new System.Drawing.Point(28, 184);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_correo.MaxLength = 50;
            this.txt_correo.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_correo.Multiline = false;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(453, 50);
            this.txt_correo.TabIndex = 9;
            this.txt_correo.Text = "";
            this.txt_correo.TrailingIcon = null;
            this.txt_correo.TextChanged += new System.EventHandler(this.materialTextBox7_TextChanged);
            // 
            // txt_sexo
            // 
            this.txt_sexo.AutoResize = false;
            this.txt_sexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_sexo.DataSource = this.tblsexoBindingSource;
            this.txt_sexo.Depth = 0;
            this.txt_sexo.DisplayMember = "Nombre";
            this.txt_sexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txt_sexo.DropDownHeight = 174;
            this.txt_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_sexo.DropDownWidth = 121;
            this.txt_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txt_sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_sexo.FormattingEnabled = true;
            this.txt_sexo.IntegralHeight = false;
            this.txt_sexo.ItemHeight = 43;
            this.txt_sexo.Location = new System.Drawing.Point(496, 182);
            this.txt_sexo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sexo.MaxDropDownItems = 4;
            this.txt_sexo.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Size = new System.Drawing.Size(220, 49);
            this.txt_sexo.StartIndex = 0;
            this.txt_sexo.TabIndex = 10;
            this.txt_sexo.ValueMember = "Nomenclatura";
            this.txt_sexo.SelectedIndexChanged += new System.EventHandler(this.txt_sexo_SelectedIndexChanged);
            // 
            // tblsexoBindingSource
            // 
            this.tblsexoBindingSource.DataMember = "tbl_sexo";
            this.tblsexoBindingSource.DataSource = this.dbs_prestamos_deportivosDataSet;
            // 
            // dbs_prestamos_deportivosDataSet
            // 
            this.dbs_prestamos_deportivosDataSet.DataSetName = "dbs_prestamos_deportivosDataSet";
            this.dbs_prestamos_deportivosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_direccion
            // 
            this.txt_direccion.AnimateReadOnly = false;
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_direccion.Depth = 0;
            this.txt_direccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_direccion.Hint = "Dirección";
            this.txt_direccion.LeadingIcon = null;
            this.txt_direccion.Location = new System.Drawing.Point(28, 248);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_direccion.MaxLength = 50;
            this.txt_direccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_direccion.Multiline = false;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(688, 50);
            this.txt_direccion.TabIndex = 11;
            this.txt_direccion.Text = "";
            this.txt_direccion.TrailingIcon = null;
            this.txt_direccion.TextChanged += new System.EventHandler(this.materialTextBox8_TextChanged);
            // 
            // tbl_sexoTableAdapter
            // 
            this.tbl_sexoTableAdapter.ClearBeforeFill = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(169, 315);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(109, 36);
            this.materialButton1.TabIndex = 12;
            this.materialButton1.Text = "Actualizar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(329, 315);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(88, 36);
            this.materialButton2.TabIndex = 13;
            this.materialButton2.Text = "Guardar";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(462, 315);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(96, 36);
            this.materialButton3.TabIndex = 14;
            this.materialButton3.Text = "Cancelar";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // frm_modulo_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 378);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_sexo);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_contacto);
            this.Controls.Add(this.txt_segundoapellido);
            this.Controls.Add(this.txt_identificacion);
            this.Controls.Add(this.txt_primerapellido);
            this.Controls.Add(this.txt_segundonombre);
            this.Controls.Add(this.txt_primernombre);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_modulo_usuarios";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_modulo_usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblsexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_prestamos_deportivosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txt_primernombre;
        private MaterialSkin.Controls.MaterialTextBox txt_segundonombre;
        private MaterialSkin.Controls.MaterialTextBox txt_primerapellido;
        private MaterialSkin.Controls.MaterialTextBox txt_identificacion;
        private MaterialSkin.Controls.MaterialTextBox txt_segundoapellido;
        private MaterialSkin.Controls.MaterialTextBox txt_contacto;
        private MaterialSkin.Controls.MaterialTextBox txt_correo;
        private MaterialSkin.Controls.MaterialComboBox txt_sexo;
        private MaterialSkin.Controls.MaterialTextBox txt_direccion;
        private dbs_prestamos_deportivosDataSet dbs_prestamos_deportivosDataSet;
        private System.Windows.Forms.BindingSource tblsexoBindingSource;
        private dbs_prestamos_deportivosDataSetTableAdapters.tbl_sexoTableAdapter tbl_sexoTableAdapter;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
    }
}

