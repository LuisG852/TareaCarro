
namespace Tarea_Carro
{
    partial class labelEstadoVelocidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(labelEstadoVelocidad));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.buttonParar = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelEstadoVelocidadr = new System.Windows.Forms.Label();
            this.BMW = new System.Windows.Forms.Button();
            this.CMB = new System.Windows.Forms.Button();
            this.labelCambio = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonFrenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(92, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "MECHES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEncender
            // 
            this.buttonEncender.BackColor = System.Drawing.Color.Aqua;
            this.buttonEncender.Location = new System.Drawing.Point(92, 113);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(90, 35);
            this.buttonEncender.TabIndex = 1;
            this.buttonEncender.Text = "Encender Carro";
            this.buttonEncender.UseVisualStyleBackColor = false;
            this.buttonEncender.Visible = false;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.BackColor = System.Drawing.Color.Lime;
            this.buttonAcelerar.Location = new System.Drawing.Point(92, 168);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(90, 35);
            this.buttonAcelerar.TabIndex = 2;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = false;
            this.buttonAcelerar.Visible = false;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // buttonParar
            // 
            this.buttonParar.BackColor = System.Drawing.Color.Red;
            this.buttonParar.Location = new System.Drawing.Point(197, 228);
            this.buttonParar.Name = "buttonParar";
            this.buttonParar.Size = new System.Drawing.Size(90, 37);
            this.buttonParar.TabIndex = 3;
            this.buttonParar.Text = "Parar";
            this.buttonParar.UseVisualStyleBackColor = false;
            this.buttonParar.Visible = false;
            this.buttonParar.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEstado.Location = new System.Drawing.Point(321, 113);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(0, 13);
            this.labelEstado.TabIndex = 4;
            // 
            // labelEstadoVelocidadr
            // 
            this.labelEstadoVelocidadr.AutoSize = true;
            this.labelEstadoVelocidadr.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEstadoVelocidadr.Location = new System.Drawing.Point(321, 190);
            this.labelEstadoVelocidadr.Name = "labelEstadoVelocidadr";
            this.labelEstadoVelocidadr.Size = new System.Drawing.Size(0, 13);
            this.labelEstadoVelocidadr.TabIndex = 5;
            // 
            // BMW
            // 
            this.BMW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BMW.Location = new System.Drawing.Point(92, 3);
            this.BMW.Name = "BMW";
            this.BMW.Size = new System.Drawing.Size(90, 41);
            this.BMW.TabIndex = 6;
            this.BMW.Text = "BMW";
            this.BMW.UseVisualStyleBackColor = false;
            this.BMW.Click += new System.EventHandler(this.BMW_Click);
            // 
            // CMB
            // 
            this.CMB.BackColor = System.Drawing.Color.Yellow;
            this.CMB.Location = new System.Drawing.Point(197, 168);
            this.CMB.Name = "CMB";
            this.CMB.Size = new System.Drawing.Size(86, 35);
            this.CMB.TabIndex = 7;
            this.CMB.Text = "Cambios";
            this.CMB.UseVisualStyleBackColor = false;
            this.CMB.Visible = false;
            this.CMB.Click += new System.EventHandler(this.CMB_Click);
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCambio.Location = new System.Drawing.Point(321, 157);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(0, 13);
            this.labelCambio.TabIndex = 8;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(92, 271);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(134, 59);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            // 
            // buttonFrenar
            // 
            this.buttonFrenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonFrenar.Location = new System.Drawing.Point(92, 228);
            this.buttonFrenar.Name = "buttonFrenar";
            this.buttonFrenar.Size = new System.Drawing.Size(90, 35);
            this.buttonFrenar.TabIndex = 10;
            this.buttonFrenar.Text = "Frenar";
            this.buttonFrenar.UseVisualStyleBackColor = false;
            this.buttonFrenar.Visible = false;
            this.buttonFrenar.Click += new System.EventHandler(this.buttonFrenar_Click);
            // 
            // labelEstadoVelocidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tarea_Carro.Properties.Resources.depositphotos_132689652_stock_illustration_futuristic_gear_wheel_with_car;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.buttonFrenar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.labelCambio);
            this.Controls.Add(this.CMB);
            this.Controls.Add(this.BMW);
            this.Controls.Add(this.labelEstadoVelocidadr);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.buttonParar);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.button1);
            this.Name = "labelEstadoVelocidad";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Button buttonParar;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelEstadoVelocidadr;
        private System.Windows.Forms.Button BMW;
        private System.Windows.Forms.Button CMB;
        private System.Windows.Forms.Label labelCambio;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button buttonFrenar;
    }
}

