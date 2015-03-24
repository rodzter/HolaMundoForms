namespace HolaMundoForms.Catalogos
{
    partial class Almacen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnCambio = new System.Windows.Forms.Button();
            this.BTN_AGREGAR_REGISTRO = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_num_almacen = new System.Windows.Forms.TextBox();
            this.txt_cod_producto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.nud_Stock_Minimo = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Stock_Minimo)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 99);
            this.panel1.TabIndex = 28;
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
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
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
            this.btnCambio.UseVisualStyleBackColor = true;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
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
            this.BTN_AGREGAR_REGISTRO.UseVisualStyleBackColor = true;
            this.BTN_AGREGAR_REGISTRO.Click += new System.EventHandler(this.BTN_AGREGAR_REGISTRO_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(20, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 37);
            this.label6.TabIndex = 39;
            this.label6.Text = "Almacen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "No. de almacen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "Codigo de Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(14, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(14, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 43;
            this.label4.Text = "Stock Minimo:";
            // 
            // txt_num_almacen
            // 
            this.txt_num_almacen.Location = new System.Drawing.Point(209, 111);
            this.txt_num_almacen.Name = "txt_num_almacen";
            this.txt_num_almacen.Size = new System.Drawing.Size(197, 20);
            this.txt_num_almacen.TabIndex = 50;
            // 
            // txt_cod_producto
            // 
            this.txt_cod_producto.Location = new System.Drawing.Point(209, 174);
            this.txt_cod_producto.MaxLength = 16;
            this.txt_cod_producto.Name = "txt_cod_producto";
            this.txt_cod_producto.Size = new System.Drawing.Size(197, 20);
            this.txt_cod_producto.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 76);
            this.panel2.TabIndex = 54;
            // 
            // nud_Cantidad
            // 
            this.nud_Cantidad.Location = new System.Drawing.Point(209, 248);
            this.nud_Cantidad.Name = "nud_Cantidad";
            this.nud_Cantidad.Size = new System.Drawing.Size(197, 20);
            this.nud_Cantidad.TabIndex = 55;
            // 
            // nud_Stock_Minimo
            // 
            this.nud_Stock_Minimo.Location = new System.Drawing.Point(209, 329);
            this.nud_Stock_Minimo.Name = "nud_Stock_Minimo";
            this.nud_Stock_Minimo.Size = new System.Drawing.Size(197, 20);
            this.nud_Stock_Minimo.TabIndex = 56;
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(685, 465);
            this.Controls.Add(this.nud_Stock_Minimo);
            this.Controls.Add(this.nud_Cantidad);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_cod_producto);
            this.Controls.Add(this.txt_num_almacen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Almacen";
            this.Text = "Almacen";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Stock_Minimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnCambio;
        private System.Windows.Forms.Button BTN_AGREGAR_REGISTRO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_num_almacen;
        private System.Windows.Forms.TextBox txt_cod_producto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nud_Cantidad;
        private System.Windows.Forms.NumericUpDown nud_Stock_Minimo;
    }
}