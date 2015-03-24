namespace HolaMundoForms.Catalogos
{
    partial class FormProductos
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnCambio = new System.Windows.Forms.Button();
            this.BTN_AGREGAR_REGISTRO = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Cod_producto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Nombre_completo = new System.Windows.Forms.TextBox();
            this.nud_Precio = new System.Windows.Forms.NumericUpDown();
            this.nud_Costo = new System.Windows.Forms.NumericUpDown();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Costo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnBaja);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnCambio);
            this.panel1.Controls.Add(this.BTN_AGREGAR_REGISTRO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 107);
            this.panel1.TabIndex = 25;
            // 
            // btnBaja
            // 
            this.btnBaja.BackgroundImage = global::HolaMundoForms.Properties.Resources.arrow_down_icon;
            this.btnBaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.ForeColor = System.Drawing.Color.Transparent;
            this.btnBaja.Location = new System.Drawing.Point(144, 26);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(64, 64);
            this.btnBaja.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btnBaja, "Baja");
            this.btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = global::HolaMundoForms.Properties.Resources.x_cross_icon;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnsalir.Location = new System.Drawing.Point(605, 26);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(64, 64);
            this.btnsalir.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnsalir, "Salir");
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnCambio
            // 
            this.btnCambio.BackgroundImage = global::HolaMundoForms.Properties.Resources.Other_Power_Restart_Metro_icon3;
            this.btnCambio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambio.ForeColor = System.Drawing.Color.Transparent;
            this.btnCambio.Location = new System.Drawing.Point(266, 29);
            this.btnCambio.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(64, 64);
            this.btnCambio.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnCambio, "Cambio");
            this.btnCambio.UseVisualStyleBackColor = true;
            // 
            // BTN_AGREGAR_REGISTRO
            // 
            this.BTN_AGREGAR_REGISTRO.BackgroundImage = global::HolaMundoForms.Properties.Resources.check_icon;
            this.BTN_AGREGAR_REGISTRO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_AGREGAR_REGISTRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AGREGAR_REGISTRO.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_AGREGAR_REGISTRO.Location = new System.Drawing.Point(27, 26);
            this.BTN_AGREGAR_REGISTRO.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_AGREGAR_REGISTRO.Name = "BTN_AGREGAR_REGISTRO";
            this.BTN_AGREGAR_REGISTRO.Size = new System.Drawing.Size(64, 64);
            this.BTN_AGREGAR_REGISTRO.TabIndex = 20;
            this.toolTip1.SetToolTip(this.BTN_AGREGAR_REGISTRO, "Alta");
            this.BTN_AGREGAR_REGISTRO.UseVisualStyleBackColor = true;
            this.BTN_AGREGAR_REGISTRO.Click += new System.EventHandler(this.BTN_AGREGAR_REGISTRO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(11, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Codigo del Producto:";
            // 
            // txt_Cod_producto
            // 
            this.txt_Cod_producto.Location = new System.Drawing.Point(212, 80);
            this.txt_Cod_producto.Name = "txt_Cod_producto";
            this.txt_Cod_producto.Size = new System.Drawing.Size(197, 20);
            this.txt_Cod_producto.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre Completo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(99, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Precio $:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(104, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "Costo $:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(13, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 29);
            this.label5.TabIndex = 31;
            this.label5.Text = "Fecha de Ingreso:";
            // 
            // txt_Nombre_completo
            // 
            this.txt_Nombre_completo.Location = new System.Drawing.Point(212, 121);
            this.txt_Nombre_completo.Name = "txt_Nombre_completo";
            this.txt_Nombre_completo.Size = new System.Drawing.Size(334, 20);
            this.txt_Nombre_completo.TabIndex = 32;
            // 
            // nud_Precio
            // 
            this.nud_Precio.DecimalPlaces = 2;
            this.nud_Precio.Location = new System.Drawing.Point(212, 160);
            this.nud_Precio.Name = "nud_Precio";
            this.nud_Precio.Size = new System.Drawing.Size(197, 20);
            this.nud_Precio.TabIndex = 33;
            // 
            // nud_Costo
            // 
            this.nud_Costo.DecimalPlaces = 2;
            this.nud_Costo.Location = new System.Drawing.Point(212, 207);
            this.nud_Costo.Name = "nud_Costo";
            this.nud_Costo.Size = new System.Drawing.Size(197, 20);
            this.nud_Costo.TabIndex = 34;
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Fecha.Location = new System.Drawing.Point(212, 248);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(334, 32);
            this.dtp_Fecha.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 37);
            this.label6.TabIndex = 36;
            this.label6.Text = "Productos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 53);
            this.panel2.TabIndex = 65;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(758, 414);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.nud_Costo);
            this.Controls.Add(this.nud_Precio);
            this.Controls.Add(this.txt_Nombre_completo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Cod_producto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Costo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnCambio;
        private System.Windows.Forms.Button BTN_AGREGAR_REGISTRO;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Cod_producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Nombre_completo;
        private System.Windows.Forms.NumericUpDown nud_Precio;
        private System.Windows.Forms.NumericUpDown nud_Costo;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
    }
}