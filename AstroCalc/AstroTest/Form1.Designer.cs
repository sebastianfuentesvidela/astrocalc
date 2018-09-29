namespace AstroTest
{
    partial class Form1
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
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nDia = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nMes = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nAno = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nHora = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nMinu = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nTzone = new System.Windows.Forms.NumericUpDown();
            this.mLong = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mLati = new System.Windows.Forms.MaskedTextBox();
            this.ckOeste = new System.Windows.Forms.CheckBox();
            this.ckSur = new System.Windows.Forms.CheckBox();
            this.boton = new System.Windows.Forms.Button();
            this.txOut = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMinu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTzone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(71, 12);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(394, 22);
            this.txNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // nDia
            // 
            this.nDia.Location = new System.Drawing.Point(71, 47);
            this.nDia.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nDia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nDia.Name = "nDia";
            this.nDia.Size = new System.Drawing.Size(40, 22);
            this.nDia.TabIndex = 2;
            this.nDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "  d";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "  m";
            // 
            // nMes
            // 
            this.nMes.Location = new System.Drawing.Point(142, 47);
            this.nMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMes.Name = "nMes";
            this.nMes.Size = new System.Drawing.Size(40, 22);
            this.nMes.TabIndex = 2;
            this.nMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "  a";
            // 
            // nAno
            // 
            this.nAno.Location = new System.Drawing.Point(208, 47);
            this.nAno.Maximum = new decimal(new int[] {
            2035,
            0,
            0,
            0});
            this.nAno.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nAno.Name = "nAno";
            this.nAno.Size = new System.Drawing.Size(62, 22);
            this.nAno.TabIndex = 2;
            this.nAno.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "  h";
            // 
            // nHora
            // 
            this.nHora.Location = new System.Drawing.Point(354, 47);
            this.nHora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nHora.Name = "nHora";
            this.nHora.Size = new System.Drawing.Size(40, 22);
            this.nHora.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "  m";
            // 
            // nMinu
            // 
            this.nMinu.Location = new System.Drawing.Point(425, 47);
            this.nMinu.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nMinu.Name = "nMinu";
            this.nMinu.Size = new System.Drawing.Size(40, 22);
            this.nMinu.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Time Zone";
            // 
            // nTzone
            // 
            this.nTzone.Location = new System.Drawing.Point(89, 87);
            this.nTzone.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nTzone.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            -2147483648});
            this.nTzone.Name = "nTzone";
            this.nTzone.Size = new System.Drawing.Size(55, 22);
            this.nTzone.TabIndex = 3;
            // 
            // mLong
            // 
            this.mLong.Location = new System.Drawing.Point(226, 84);
            this.mLong.Mask = "99°99\'";
            this.mLong.Name = "mLong";
            this.mLong.Size = new System.Drawing.Size(44, 22);
            this.mLong.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Longitud";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(343, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Latitud";
            // 
            // mLati
            // 
            this.mLati.Location = new System.Drawing.Point(391, 84);
            this.mLati.Mask = "99°99\'";
            this.mLati.Name = "mLati";
            this.mLati.Size = new System.Drawing.Size(66, 22);
            this.mLati.TabIndex = 4;
            // 
            // ckOeste
            // 
            this.ckOeste.AutoSize = true;
            this.ckOeste.Location = new System.Drawing.Point(276, 88);
            this.ckOeste.Name = "ckOeste";
            this.ckOeste.Size = new System.Drawing.Size(65, 21);
            this.ckOeste.TabIndex = 6;
            this.ckOeste.Text = "oeste";
            this.ckOeste.UseVisualStyleBackColor = true;
            // 
            // ckSur
            // 
            this.ckSur.AutoSize = true;
            this.ckSur.Location = new System.Drawing.Point(463, 88);
            this.ckSur.Name = "ckSur";
            this.ckSur.Size = new System.Drawing.Size(50, 21);
            this.ckSur.TabIndex = 7;
            this.ckSur.Text = "sur";
            this.ckSur.UseVisualStyleBackColor = true;
            // 
            // boton
            // 
            this.boton.Location = new System.Drawing.Point(463, 12);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(69, 57);
            this.boton.TabIndex = 8;
            this.boton.Text = "Corre la Bolita";
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // txOut
            // 
            this.txOut.AcceptsReturn = true;
            this.txOut.Location = new System.Drawing.Point(0, 127);
            this.txOut.Multiline = true;
            this.txOut.Name = "txOut";
            this.txOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txOut.Size = new System.Drawing.Size(532, 427);
            this.txOut.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(538, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 585);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 609);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txOut);
            this.Controls.Add(this.boton);
            this.Controls.Add(this.ckSur);
            this.Controls.Add(this.ckOeste);
            this.Controls.Add(this.mLati);
            this.Controls.Add(this.mLong);
            this.Controls.Add(this.nTzone);
            this.Controls.Add(this.nAno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nMinu);
            this.Controls.Add(this.nMes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nHora);
            this.Controls.Add(this.nDia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMinu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTzone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nMes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nAno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nHora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nMinu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nTzone;
        private System.Windows.Forms.MaskedTextBox mLong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mLati;
        private System.Windows.Forms.CheckBox ckOeste;
        private System.Windows.Forms.CheckBox ckSur;
        private System.Windows.Forms.Button boton;
        private System.Windows.Forms.TextBox txOut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

