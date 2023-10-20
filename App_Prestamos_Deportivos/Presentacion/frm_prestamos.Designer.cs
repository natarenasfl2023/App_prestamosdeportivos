﻿namespace Presentacion
{
    partial class frm_prestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_identificacion = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_nombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_codigo = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_descripcion = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_existencias = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_implemento = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_cantidad = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_prestar = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancelar = new MaterialSkin.Controls.MaterialButton();
            this.txt_observaciones = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btn_agregar = new MaterialSkin.Controls.MaterialButton();
            this.dtg_prestamo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_prestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_identificacion
            // 
            this.txt_identificacion.AnimateReadOnly = false;
            this.txt_identificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_identificacion.Depth = 0;
            this.txt_identificacion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_identificacion.Hint = "Identificacion persona";
            this.txt_identificacion.LeadingIcon = null;
            this.txt_identificacion.Location = new System.Drawing.Point(36, 31);
            this.txt_identificacion.MaxLength = 50;
            this.txt_identificacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_identificacion.Multiline = false;
            this.txt_identificacion.Name = "txt_identificacion";
            this.txt_identificacion.Size = new System.Drawing.Size(274, 50);
            this.txt_identificacion.TabIndex = 0;
            this.txt_identificacion.Text = "";
            this.txt_identificacion.TrailingIcon = null;
            // 
            // txt_nombre
            // 
            this.txt_nombre.AnimateReadOnly = false;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Depth = 0;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nombre.Hint = "Nombre persona";
            this.txt_nombre.LeadingIcon = null;
            this.txt_nombre.Location = new System.Drawing.Point(338, 31);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nombre.Multiline = false;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(421, 50);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.Text = "";
            this.txt_nombre.TrailingIcon = null;
            // 
            // txt_codigo
            // 
            this.txt_codigo.AnimateReadOnly = false;
            this.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo.Depth = 0;
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_codigo.Hint = "Codigo del implemento";
            this.txt_codigo.LeadingIcon = null;
            this.txt_codigo.Location = new System.Drawing.Point(36, 102);
            this.txt_codigo.MaxLength = 50;
            this.txt_codigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_codigo.Multiline = false;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(274, 50);
            this.txt_codigo.TabIndex = 2;
            this.txt_codigo.Text = "";
            this.txt_codigo.TrailingIcon = null;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.AnimateReadOnly = false;
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descripcion.Depth = 0;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_descripcion.Hint = "Descripcion";
            this.txt_descripcion.LeadingIcon = null;
            this.txt_descripcion.Location = new System.Drawing.Point(338, 102);
            this.txt_descripcion.MaxLength = 50;
            this.txt_descripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_descripcion.Multiline = false;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ReadOnly = true;
            this.txt_descripcion.Size = new System.Drawing.Size(421, 50);
            this.txt_descripcion.TabIndex = 3;
            this.txt_descripcion.Text = "";
            this.txt_descripcion.TrailingIcon = null;
            // 
            // txt_existencias
            // 
            this.txt_existencias.AnimateReadOnly = false;
            this.txt_existencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_existencias.Depth = 0;
            this.txt_existencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_existencias.Hint = "Existencias";
            this.txt_existencias.LeadingIcon = null;
            this.txt_existencias.Location = new System.Drawing.Point(36, 170);
            this.txt_existencias.MaxLength = 50;
            this.txt_existencias.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_existencias.Multiline = false;
            this.txt_existencias.Name = "txt_existencias";
            this.txt_existencias.Size = new System.Drawing.Size(274, 50);
            this.txt_existencias.TabIndex = 4;
            this.txt_existencias.Text = "";
            this.txt_existencias.TrailingIcon = null;
            // 
            // txt_implemento
            // 
            this.txt_implemento.AnimateReadOnly = false;
            this.txt_implemento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_implemento.Depth = 0;
            this.txt_implemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_implemento.Hint = "Nombre del implemento";
            this.txt_implemento.LeadingIcon = null;
            this.txt_implemento.Location = new System.Drawing.Point(338, 170);
            this.txt_implemento.MaxLength = 50;
            this.txt_implemento.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_implemento.Multiline = false;
            this.txt_implemento.Name = "txt_implemento";
            this.txt_implemento.ReadOnly = true;
            this.txt_implemento.Size = new System.Drawing.Size(421, 50);
            this.txt_implemento.TabIndex = 5;
            this.txt_implemento.Text = "";
            this.txt_implemento.TrailingIcon = null;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.AnimateReadOnly = false;
            this.txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cantidad.Depth = 0;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_cantidad.Hint = "Cantidad a prestar";
            this.txt_cantidad.LeadingIcon = null;
            this.txt_cantidad.Location = new System.Drawing.Point(36, 237);
            this.txt_cantidad.MaxLength = 50;
            this.txt_cantidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_cantidad.Multiline = false;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(274, 50);
            this.txt_cantidad.TabIndex = 6;
            this.txt_cantidad.Text = "";
            this.txt_cantidad.TrailingIcon = null;
            // 
            // btn_prestar
            // 
            this.btn_prestar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_prestar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_prestar.Depth = 0;
            this.btn_prestar.HighEmphasis = true;
            this.btn_prestar.Icon = null;
            this.btn_prestar.Location = new System.Drawing.Point(140, 312);
            this.btn_prestar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_prestar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_prestar.Name = "btn_prestar";
            this.btn_prestar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_prestar.Size = new System.Drawing.Size(85, 36);
            this.btn_prestar.TabIndex = 7;
            this.btn_prestar.Text = "prestar";
            this.btn_prestar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_prestar.UseAccentColor = false;
            this.btn_prestar.UseVisualStyleBackColor = true;
            this.btn_prestar.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancelar.Depth = 0;
            this.btn_cancelar.HighEmphasis = true;
            this.btn_cancelar.Icon = null;
            this.btn_cancelar.Location = new System.Drawing.Point(36, 312);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancelar.Size = new System.Drawing.Size(96, 36);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancelar.UseAccentColor = false;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.AnimateReadOnly = false;
            this.txt_observaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_observaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_observaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_observaciones.Depth = 0;
            this.txt_observaciones.HideSelection = true;
            this.txt_observaciones.Hint = "OBSERVACIONES";
            this.txt_observaciones.Location = new System.Drawing.Point(338, 237);
            this.txt_observaciones.MaxLength = 32767;
            this.txt_observaciones.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.PasswordChar = '\0';
            this.txt_observaciones.ReadOnly = false;
            this.txt_observaciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_observaciones.SelectedText = "";
            this.txt_observaciones.SelectionLength = 0;
            this.txt_observaciones.SelectionStart = 0;
            this.txt_observaciones.ShortcutsEnabled = true;
            this.txt_observaciones.Size = new System.Drawing.Size(421, 111);
            this.txt_observaciones.TabIndex = 9;
            this.txt_observaciones.TabStop = false;
            this.txt_observaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_observaciones.UseSystemPasswordChar = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_agregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_agregar.Depth = 0;
            this.btn_agregar.HighEmphasis = true;
            this.btn_agregar.Icon = null;
            this.btn_agregar.Location = new System.Drawing.Point(246, 312);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_agregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_agregar.Size = new System.Drawing.Size(64, 36);
            this.btn_agregar.TabIndex = 10;
            this.btn_agregar.Text = "+";
            this.btn_agregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_agregar.UseAccentColor = false;
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // dtg_prestamo
            // 
            this.dtg_prestamo.AllowUserToAddRows = false;
            this.dtg_prestamo.AllowUserToDeleteRows = false;
            this.dtg_prestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_prestamo.Location = new System.Drawing.Point(36, 379);
            this.dtg_prestamo.Name = "dtg_prestamo";
            this.dtg_prestamo.ReadOnly = true;
            this.dtg_prestamo.Size = new System.Drawing.Size(723, 150);
            this.dtg_prestamo.TabIndex = 11;
            // 
            // frm_prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.dtg_prestamo);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_observaciones);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_prestar);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_implemento);
            this.Controls.Add(this.txt_existencias);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_identificacion);
            this.Name = "frm_prestamos";
            this.Text = "frm_prestamos";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_prestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_identificacion;
        private MaterialSkin.Controls.MaterialTextBox txt_nombre;
        private MaterialSkin.Controls.MaterialTextBox txt_codigo;
        private MaterialSkin.Controls.MaterialTextBox txt_descripcion;
        private MaterialSkin.Controls.MaterialTextBox txt_existencias;
        private MaterialSkin.Controls.MaterialTextBox txt_implemento;
        private MaterialSkin.Controls.MaterialTextBox txt_cantidad;
        private MaterialSkin.Controls.MaterialButton btn_prestar;
        private MaterialSkin.Controls.MaterialButton btn_cancelar;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_observaciones;
        private MaterialSkin.Controls.MaterialButton btn_agregar;
        private System.Windows.Forms.DataGridView dtg_prestamo;
    }
}