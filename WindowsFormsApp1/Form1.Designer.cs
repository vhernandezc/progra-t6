
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btncrear = new System.Windows.Forms.Button();
            this.lblestado = new System.Windows.Forms.Label();
            this.btnencender = new System.Windows.Forms.Button();
            this.btnacelerar = new System.Windows.Forms.Button();
            this.lblvelocidad = new System.Windows.Forms.Label();
            this.btnAlto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkboxparqueo = new System.Windows.Forms.CheckBox();
            this.checkBoxretroceso = new System.Windows.Forms.CheckBox();
            this.checkBoxneutro = new System.Windows.Forms.CheckBox();
            this.checkBoxdirecto = new System.Windows.Forms.CheckBox();
            this.lblcambios = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btncargar = new System.Windows.Forms.Button();
            this.btnreproducir = new System.Windows.Forms.Button();
            this.btnparar = new System.Windows.Forms.Button();
            this.btnpausa = new System.Windows.Forms.Button();
            this.lblruta = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncrear
            // 
            this.btncrear.BackColor = System.Drawing.Color.Navy;
            this.btncrear.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrear.ForeColor = System.Drawing.Color.Yellow;
            this.btncrear.Location = new System.Drawing.Point(93, 66);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(289, 43);
            this.btncrear.TabIndex = 0;
            this.btncrear.Text = "crear carro";
            this.btncrear.UseVisualStyleBackColor = false;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // lblestado
            // 
            this.lblestado.AllowDrop = true;
            this.lblestado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblestado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblestado.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblestado.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.ForeColor = System.Drawing.Color.Red;
            this.lblestado.Location = new System.Drawing.Point(153, 133);
            this.lblestado.Name = "lblestado";
            this.lblestado.Padding = new System.Windows.Forms.Padding(1);
            this.lblestado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblestado.Size = new System.Drawing.Size(145, 77);
            this.lblestado.TabIndex = 1;
            this.lblestado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblestado.Visible = false;
            this.lblestado.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnencender
            // 
            this.btnencender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnencender.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnencender.Location = new System.Drawing.Point(42, 133);
            this.btnencender.Name = "btnencender";
            this.btnencender.Size = new System.Drawing.Size(90, 45);
            this.btnencender.TabIndex = 2;
            this.btnencender.Text = "encender carro";
            this.btnencender.UseVisualStyleBackColor = false;
            this.btnencender.Visible = false;
            this.btnencender.Click += new System.EventHandler(this.btnencender_Click);
            // 
            // btnacelerar
            // 
            this.btnacelerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnacelerar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacelerar.Location = new System.Drawing.Point(42, 196);
            this.btnacelerar.Name = "btnacelerar";
            this.btnacelerar.Size = new System.Drawing.Size(90, 41);
            this.btnacelerar.TabIndex = 3;
            this.btnacelerar.Text = "acelerar";
            this.btnacelerar.UseVisualStyleBackColor = false;
            this.btnacelerar.Visible = false;
            this.btnacelerar.Click += new System.EventHandler(this.acelerar_Click);
            // 
            // lblvelocidad
            // 
            this.lblvelocidad.AllowDrop = true;
            this.lblvelocidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblvelocidad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblvelocidad.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvelocidad.ForeColor = System.Drawing.Color.Red;
            this.lblvelocidad.Location = new System.Drawing.Point(153, 219);
            this.lblvelocidad.Name = "lblvelocidad";
            this.lblvelocidad.Size = new System.Drawing.Size(145, 82);
            this.lblvelocidad.TabIndex = 4;
            this.lblvelocidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblvelocidad.Visible = false;
            this.lblvelocidad.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnAlto
            // 
            this.btnAlto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAlto.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlto.Location = new System.Drawing.Point(42, 259);
            this.btnAlto.Name = "btnAlto";
            this.btnAlto.Size = new System.Drawing.Size(90, 42);
            this.btnAlto.TabIndex = 5;
            this.btnAlto.Text = "alto total";
            this.btnAlto.UseVisualStyleBackColor = false;
            this.btnAlto.Visible = false;
            this.btnAlto.Click += new System.EventHandler(this.btnAlto_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tesla Motors";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkboxparqueo
            // 
            this.checkboxparqueo.AutoSize = true;
            this.checkboxparqueo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkboxparqueo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxparqueo.ForeColor = System.Drawing.Color.Black;
            this.checkboxparqueo.Location = new System.Drawing.Point(391, 164);
            this.checkboxparqueo.Name = "checkboxparqueo";
            this.checkboxparqueo.Size = new System.Drawing.Size(37, 20);
            this.checkboxparqueo.TabIndex = 7;
            this.checkboxparqueo.Text = "P";
            this.checkboxparqueo.UseVisualStyleBackColor = false;
            this.checkboxparqueo.Visible = false;
            this.checkboxparqueo.CheckedChanged += new System.EventHandler(this.checkboxparqueo_CheckedChanged);
            // 
            // checkBoxretroceso
            // 
            this.checkBoxretroceso.AutoSize = true;
            this.checkBoxretroceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkBoxretroceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxretroceso.ForeColor = System.Drawing.Color.Black;
            this.checkBoxretroceso.Location = new System.Drawing.Point(391, 196);
            this.checkBoxretroceso.Name = "checkBoxretroceso";
            this.checkBoxretroceso.Size = new System.Drawing.Size(38, 20);
            this.checkBoxretroceso.TabIndex = 8;
            this.checkBoxretroceso.Text = "R";
            this.checkBoxretroceso.UseVisualStyleBackColor = false;
            this.checkBoxretroceso.Visible = false;
            this.checkBoxretroceso.CheckedChanged += new System.EventHandler(this.checkBoxretroceso_CheckedChanged);
            // 
            // checkBoxneutro
            // 
            this.checkBoxneutro.AutoSize = true;
            this.checkBoxneutro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkBoxneutro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxneutro.ForeColor = System.Drawing.Color.Black;
            this.checkBoxneutro.Location = new System.Drawing.Point(390, 235);
            this.checkBoxneutro.Name = "checkBoxneutro";
            this.checkBoxneutro.Size = new System.Drawing.Size(38, 20);
            this.checkBoxneutro.TabIndex = 9;
            this.checkBoxneutro.Text = "N";
            this.checkBoxneutro.UseVisualStyleBackColor = false;
            this.checkBoxneutro.Visible = false;
            this.checkBoxneutro.CheckedChanged += new System.EventHandler(this.checkBoxneutro_CheckedChanged);
            // 
            // checkBoxdirecto
            // 
            this.checkBoxdirecto.AutoSize = true;
            this.checkBoxdirecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkBoxdirecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxdirecto.ForeColor = System.Drawing.Color.Black;
            this.checkBoxdirecto.Location = new System.Drawing.Point(391, 272);
            this.checkBoxdirecto.Name = "checkBoxdirecto";
            this.checkBoxdirecto.Size = new System.Drawing.Size(38, 20);
            this.checkBoxdirecto.TabIndex = 10;
            this.checkBoxdirecto.Text = "D";
            this.checkBoxdirecto.UseVisualStyleBackColor = false;
            this.checkBoxdirecto.Visible = false;
            this.checkBoxdirecto.CheckedChanged += new System.EventHandler(this.checkBoxdirecto_CheckedChanged);
            // 
            // lblcambios
            // 
            this.lblcambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblcambios.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcambios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblcambios.Location = new System.Drawing.Point(357, 133);
            this.lblcambios.Name = "lblcambios";
            this.lblcambios.Size = new System.Drawing.Size(100, 23);
            this.lblcambios.TabIndex = 11;
            this.lblcambios.Text = "caja de cambios";
            this.lblcambios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblcambios.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(39, 307);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(259, 113);
            this.axWindowsMediaPlayer1.TabIndex = 12;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(301, 308);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(75, 23);
            this.btncargar.TabIndex = 13;
            this.btncargar.Text = "cargar";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Visible = false;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // btnreproducir
            // 
            this.btnreproducir.Location = new System.Drawing.Point(301, 337);
            this.btnreproducir.Name = "btnreproducir";
            this.btnreproducir.Size = new System.Drawing.Size(75, 23);
            this.btnreproducir.TabIndex = 14;
            this.btnreproducir.Text = "reproducir";
            this.btnreproducir.UseVisualStyleBackColor = true;
            this.btnreproducir.Visible = false;
            this.btnreproducir.Click += new System.EventHandler(this.btnreproducir_Click);
            // 
            // btnparar
            // 
            this.btnparar.Location = new System.Drawing.Point(301, 367);
            this.btnparar.Name = "btnparar";
            this.btnparar.Size = new System.Drawing.Size(75, 23);
            this.btnparar.TabIndex = 15;
            this.btnparar.Text = "parar";
            this.btnparar.UseVisualStyleBackColor = true;
            this.btnparar.Visible = false;
            this.btnparar.Click += new System.EventHandler(this.btnparar_Click);
            // 
            // btnpausa
            // 
            this.btnpausa.Location = new System.Drawing.Point(301, 396);
            this.btnpausa.Name = "btnpausa";
            this.btnpausa.Size = new System.Drawing.Size(75, 23);
            this.btnpausa.TabIndex = 16;
            this.btnpausa.Text = "pausa";
            this.btnpausa.UseVisualStyleBackColor = true;
            this.btnpausa.Visible = false;
            this.btnpausa.Click += new System.EventHandler(this.btnpausa_Click);
            // 
            // lblruta
            // 
            this.lblruta.Location = new System.Drawing.Point(39, 423);
            this.lblruta.Name = "lblruta";
            this.lblruta.Size = new System.Drawing.Size(259, 23);
            this.lblruta.TabIndex = 17;
            this.lblruta.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.tesla;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.lblruta);
            this.Controls.Add(this.btnpausa);
            this.Controls.Add(this.btnparar);
            this.Controls.Add(this.btnreproducir);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lblcambios);
            this.Controls.Add(this.checkBoxdirecto);
            this.Controls.Add(this.checkBoxneutro);
            this.Controls.Add(this.checkBoxretroceso);
            this.Controls.Add(this.checkboxparqueo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlto);
            this.Controls.Add(this.lblvelocidad);
            this.Controls.Add(this.btnacelerar);
            this.Controls.Add(this.btnencender);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.btncrear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncrear;
        public System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Button btnencender;
        private System.Windows.Forms.Button btnacelerar;
        private System.Windows.Forms.Label lblvelocidad;
        private System.Windows.Forms.Button btnAlto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkboxparqueo;
        private System.Windows.Forms.CheckBox checkBoxretroceso;
        private System.Windows.Forms.CheckBox checkBoxneutro;
        private System.Windows.Forms.CheckBox checkBoxdirecto;
        private System.Windows.Forms.Label lblcambios;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.Button btnreproducir;
        private System.Windows.Forms.Button btnparar;
        private System.Windows.Forms.Button btnpausa;
        private System.Windows.Forms.Label lblruta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

