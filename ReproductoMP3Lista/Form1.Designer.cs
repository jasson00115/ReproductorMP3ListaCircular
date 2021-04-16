namespace ReproductoMP3Lista
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.remover = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Alerta = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.repetir = new System.Windows.Forms.PictureBox();
            this.btnAfter = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.baradeProgreso = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repetir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.remover);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 664);
            this.panel1.TabIndex = 0;
            // 
            // remover
            // 
            this.remover.Image = global::ReproductoMP3Lista.Properties.Resources.remove;
            this.remover.Location = new System.Drawing.Point(12, 106);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(64, 59);
            this.remover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.remover.TabIndex = 7;
            this.remover.TabStop = false;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ReproductoMP3Lista.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.Alerta);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(84, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 664);
            this.panel2.TabIndex = 1;
            // 
            // Alerta
            // 
            this.Alerta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Alerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alerta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Alerta.Location = new System.Drawing.Point(3, 18);
            this.Alerta.Name = "Alerta";
            this.Alerta.Size = new System.Drawing.Size(195, 50);
            this.Alerta.TabIndex = 0;
            this.Alerta.Text = "Lista General";
            this.Alerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Alerta.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-2, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 459);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.baradeProgreso);
            this.panel3.Controls.Add(this.repetir);
            this.panel3.Controls.Add(this.btnAfter);
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnPlay);
            this.panel3.Controls.Add(this.btnPause);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(284, 541);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 123);
            this.panel3.TabIndex = 2;
            // 
            // repetir
            // 
            this.repetir.Image = global::ReproductoMP3Lista.Properties.Resources.shuffle;
            this.repetir.Location = new System.Drawing.Point(82, 21);
            this.repetir.Name = "repetir";
            this.repetir.Size = new System.Drawing.Size(64, 59);
            this.repetir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.repetir.TabIndex = 8;
            this.repetir.TabStop = false;
            this.repetir.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // btnAfter
            // 
            this.btnAfter.Image = global::ReproductoMP3Lista.Properties.Resources.back;
            this.btnAfter.Location = new System.Drawing.Point(159, 21);
            this.btnAfter.Name = "btnAfter";
            this.btnAfter.Size = new System.Drawing.Size(64, 59);
            this.btnAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAfter.TabIndex = 11;
            this.btnAfter.TabStop = false;
            this.btnAfter.Click += new System.EventHandler(this.btnAfter_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::ReproductoMP3Lista.Properties.Resources.stop_1;
            this.btnStop.Location = new System.Drawing.Point(238, 21);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(64, 59);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStop.TabIndex = 10;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::ReproductoMP3Lista.Properties.Resources.next;
            this.btnNext.Location = new System.Drawing.Point(476, 21);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(64, 59);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNext.TabIndex = 9;
            this.btnNext.TabStop = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::ReproductoMP3Lista.Properties.Resources.play_button1;
            this.btnPlay.Location = new System.Drawing.Point(397, 21);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(64, 59);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 8;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Image = global::ReproductoMP3Lista.Properties.Resources.pause1;
            this.btnPause.Location = new System.Drawing.Point(317, 21);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(64, 59);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPause.TabIndex = 7;
            this.btnPause.TabStop = false;
            this.btnPause.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(284, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(717, 100);
            this.panel4.TabIndex = 3;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(284, 93);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(717, 477);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // baradeProgreso
            // 
            this.baradeProgreso.Location = new System.Drawing.Point(15, 97);
            this.baradeProgreso.Name = "baradeProgreso";
            this.baradeProgreso.Size = new System.Drawing.Size(657, 23);
            this.baradeProgreso.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 664);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.remover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repetir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox btnAfter;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox btnNext;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnPause;
        private System.Windows.Forms.Label Alerta;
        private System.Windows.Forms.PictureBox remover;
        private System.Windows.Forms.PictureBox repetir;
        private System.Windows.Forms.ProgressBar baradeProgreso;
    }
}

