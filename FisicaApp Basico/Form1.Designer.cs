namespace FisicaApp_Basico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btVm = new Button();
            btTorr = new Button();
            btMu = new Button();
            btAcel = new Button();
            label1 = new Label();
            lblResultado = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nmEntrada1 = new NumericUpDown();
            nmEntrada3 = new NumericUpDown();
            nmEntrada2 = new NumericUpDown();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nmEntrada1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmEntrada3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmEntrada2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btVm
            // 
            btVm.BackColor = SystemColors.ControlLightLight;
            btVm.Location = new Point(35, 232);
            btVm.Name = "btVm";
            btVm.Size = new Size(114, 42);
            btVm.TabIndex = 0;
            btVm.Text = "Velocidade Média";
            btVm.UseVisualStyleBackColor = false;
            btVm.Click += btVm_Click;
            // 
            // btTorr
            // 
            btTorr.BackColor = SystemColors.ControlLightLight;
            btTorr.Location = new Point(395, 232);
            btTorr.Name = "btTorr";
            btTorr.Size = new Size(114, 42);
            btTorr.TabIndex = 1;
            btTorr.Text = "Torricelli";
            btTorr.UseVisualStyleBackColor = false;
            btTorr.Click += btTorr_Click;
            // 
            // btMu
            // 
            btMu.BackColor = SystemColors.ControlLightLight;
            btMu.Location = new Point(275, 232);
            btMu.Name = "btMu";
            btMu.Size = new Size(114, 42);
            btMu.TabIndex = 2;
            btMu.Text = "Movimento Uniforme";
            btMu.UseVisualStyleBackColor = false;
            btMu.Click += btMu_Click;
            // 
            // btAcel
            // 
            btAcel.BackColor = SystemColors.ControlLightLight;
            btAcel.Location = new Point(155, 232);
            btAcel.Name = "btAcel";
            btAcel.Size = new Size(114, 42);
            btAcel.TabIndex = 3;
            btAcel.Text = "Aceleração";
            btAcel.UseVisualStyleBackColor = false;
            btAcel.Click += btAcel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 296);
            label1.Name = "label1";
            label1.Size = new Size(102, 26);
            label1.TabIndex = 4;
            label1.Text = "Resultado:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(141, 296);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 26);
            lblResultado.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 75);
            label3.Name = "label3";
            label3.Size = new Size(100, 26);
            label3.TabIndex = 6;
            label3.Text = "Entrada 1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 15.75F);
            label4.Location = new Point(35, 121);
            label4.Name = "label4";
            label4.Size = new Size(100, 26);
            label4.TabIndex = 7;
            label4.Text = "Entrada 2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 15.75F);
            label5.Location = new Point(35, 167);
            label5.Name = "label5";
            label5.Size = new Size(100, 26);
            label5.TabIndex = 8;
            label5.Text = "Entrada 3:";
            // 
            // nmEntrada1
            // 
            nmEntrada1.Location = new Point(141, 78);
            nmEntrada1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmEntrada1.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            nmEntrada1.Name = "nmEntrada1";
            nmEntrada1.Size = new Size(83, 23);
            nmEntrada1.TabIndex = 9;
            // 
            // nmEntrada3
            // 
            nmEntrada3.Location = new Point(141, 167);
            nmEntrada3.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmEntrada3.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            nmEntrada3.Name = "nmEntrada3";
            nmEntrada3.Size = new Size(83, 23);
            nmEntrada3.TabIndex = 10;
            // 
            // nmEntrada2
            // 
            nmEntrada2.Location = new Point(141, 121);
            nmEntrada2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmEntrada2.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            nmEntrada2.Name = "nmEntrada2";
            nmEntrada2.Size = new Size(83, 23);
            nmEntrada2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.marcola;
            pictureBox1.Location = new Point(275, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 214);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(522, 336);
            Controls.Add(pictureBox1);
            Controls.Add(nmEntrada2);
            Controls.Add(nmEntrada3);
            Controls.Add(nmEntrada1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(btAcel);
            Controls.Add(btMu);
            Controls.Add(btTorr);
            Controls.Add(btVm);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Fisca App Basico";
            ((System.ComponentModel.ISupportInitialize)nmEntrada1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmEntrada3).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmEntrada2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVm;
        private Button btTorr;
        private Button btMu;
        private Button btAcel;
        private Label label1;
        private Label lblResultado;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown nmEntrada1;
        private NumericUpDown nmEntrada3;
        private NumericUpDown nmEntrada2;
        private PictureBox pictureBox1;
    }
}
