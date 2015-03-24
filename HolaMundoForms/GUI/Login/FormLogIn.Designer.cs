namespace HolaMundoForms
{
    partial class FormLogIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textuser = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btningreso = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(46, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(46, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // textuser
            // 
            this.textuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textuser.Location = new System.Drawing.Point(52, 160);
            this.textuser.Margin = new System.Windows.Forms.Padding(4);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(180, 32);
            this.textuser.TabIndex = 1;
            this.textuser.TextChanged += new System.EventHandler(this.textuser_TextChanged);
            this.textuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textuser_KeyPress);
            // 
            // textpassword
            // 
            this.textpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpassword.Location = new System.Drawing.Point(52, 251);
            this.textpassword.Margin = new System.Windows.Forms.Padding(4);
            this.textpassword.MaxLength = 20;
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = 'X';
            this.textpassword.Size = new System.Drawing.Size(180, 32);
            this.textpassword.TabIndex = 2;
            this.textpassword.TextChanged += new System.EventHandler(this.textpassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(15, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 55);
            this.label3.TabIndex = 8;
            this.label3.Text = "Login";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.HotTrack;
            // 
            // btningreso
            // 
            this.btningreso.BackgroundImage = global::HolaMundoForms.Properties.Resources.Drives_Start_Button_Metro_icon;
            this.btningreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btningreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningreso.ForeColor = System.Drawing.Color.Transparent;
            this.btningreso.Location = new System.Drawing.Point(96, 26);
            this.btningreso.Margin = new System.Windows.Forms.Padding(4);
            this.btningreso.Name = "btningreso";
            this.btningreso.Size = new System.Drawing.Size(64, 64);
            this.btningreso.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btningreso, "Login");
            this.btningreso.UseVisualStyleBackColor = true;
            this.btningreso.Click += new System.EventHandler(this.btningreso_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = global::HolaMundoForms.Properties.Resources.Other_Power_Restart_Metro_icon1;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnsalir.Location = new System.Drawing.Point(663, 26);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(64, 64);
            this.btnsalir.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnsalir, "Salir");
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackgroundImage = global::HolaMundoForms.Properties.Resources.Apps_Notepad_Metro_icon;
            this.btnactualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnactualizar.Location = new System.Drawing.Point(365, 26);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(64, 64);
            this.btnactualizar.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnactualizar, "Nuevo Usuario");
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnactualizar);
            this.panel1.Controls.Add(this.btningreso);
            this.panel1.Location = new System.Drawing.Point(-3, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 107);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HolaMundoForms.Properties.Resources.Folders_OS_User_No_Frame_Metro_icon;
            this.pictureBox1.Location = new System.Drawing.Point(527, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 53);
            this.panel2.TabIndex = 65;
            // 
            // FormLogIn
            // 
            this.AcceptButton = this.btningreso;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.CancelButton = this.btnsalir;
            this.ClientSize = new System.Drawing.Size(829, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogIn";
            this.Text = "FormLogIn";
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Button btningreso;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}