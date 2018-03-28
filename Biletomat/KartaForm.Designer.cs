namespace Biletomat
{
    partial class KartaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KartaForm));
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.buttonZ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonK = new System.Windows.Forms.Button();
            this.p_0 = new System.Windows.Forms.Button();
            this.p_9 = new System.Windows.Forms.Button();
            this.p_8 = new System.Windows.Forms.Button();
            this.p_6 = new System.Windows.Forms.Button();
            this.p_5 = new System.Windows.Forms.Button();
            this.p_7 = new System.Windows.Forms.Button();
            this.p_4 = new System.Windows.Forms.Button();
            this.p_3 = new System.Windows.Forms.Button();
            this.p_2 = new System.Windows.Forms.Button();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.p_1 = new System.Windows.Forms.Button();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelF = new System.Windows.Forms.Label();
            this.buttonC = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonA.Location = new System.Drawing.Point(345, 117);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(107, 61);
            this.buttonA.TabIndex = 8;
            this.buttonA.Text = "CANCEL";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonP
            // 
            this.buttonP.BackColor = System.Drawing.Color.Green;
            this.buttonP.Enabled = false;
            this.buttonP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonP.Location = new System.Drawing.Point(345, 305);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(107, 61);
            this.buttonP.TabIndex = 7;
            this.buttonP.Text = "ENTER";
            this.buttonP.UseVisualStyleBackColor = false;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // textBoxK
            // 
            this.textBoxK.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxK.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxK.Location = new System.Drawing.Point(261, 53);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(127, 38);
            this.textBoxK.TabIndex = 9;
            this.textBoxK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxK.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxK.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // buttonZ
            // 
            this.buttonZ.BackColor = System.Drawing.Color.Transparent;
            this.buttonZ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonZ.BackgroundImage")));
            this.buttonZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonZ.FlatAppearance.BorderSize = 0;
            this.buttonZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZ.Location = new System.Drawing.Point(294, 479);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(168, 105);
            this.buttonZ.TabIndex = 10;
            this.buttonZ.UseVisualStyleBackColor = false;
            this.buttonZ.Click += new System.EventHandler(this.buttonZ_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(257, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "To pay:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "PIN number:";
            // 
            // ButtonK
            // 
            this.ButtonK.BackColor = System.Drawing.Color.Yellow;
            this.ButtonK.Enabled = false;
            this.ButtonK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonK.Location = new System.Drawing.Point(345, 212);
            this.ButtonK.Name = "ButtonK";
            this.ButtonK.Size = new System.Drawing.Size(107, 58);
            this.ButtonK.TabIndex = 28;
            this.ButtonK.Text = "CLEAR";
            this.ButtonK.UseVisualStyleBackColor = false;
            this.ButtonK.Click += new System.EventHandler(this.ButtonK_Click);
            // 
            // p_0
            // 
            this.p_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_0.Enabled = false;
            this.p_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p_0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p_0.Location = new System.Drawing.Point(127, 392);
            this.p_0.Name = "p_0";
            this.p_0.Size = new System.Drawing.Size(70, 70);
            this.p_0.TabIndex = 27;
            this.p_0.Text = "0";
            this.p_0.UseVisualStyleBackColor = false;
            this.p_0.Click += new System.EventHandler(this.p_0_Click);
            // 
            // p_9
            // 
            this.p_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_9.Enabled = false;
            this.p_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p_9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p_9.Location = new System.Drawing.Point(231, 296);
            this.p_9.Name = "p_9";
            this.p_9.Size = new System.Drawing.Size(70, 70);
            this.p_9.TabIndex = 26;
            this.p_9.Text = "9";
            this.p_9.UseVisualStyleBackColor = false;
            this.p_9.Click += new System.EventHandler(this.p_9_Click);
            // 
            // p_8
            // 
            this.p_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_8.Enabled = false;
            this.p_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p_8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p_8.Location = new System.Drawing.Point(127, 296);
            this.p_8.Name = "p_8";
            this.p_8.Size = new System.Drawing.Size(70, 70);
            this.p_8.TabIndex = 25;
            this.p_8.Text = "8";
            this.p_8.UseVisualStyleBackColor = false;
            this.p_8.Click += new System.EventHandler(this.p_8_Click);
            // 
            // p_6
            // 
            this.p_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_6.Enabled = false;
            this.p_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p_6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p_6.Location = new System.Drawing.Point(231, 206);
            this.p_6.Name = "p_6";
            this.p_6.Size = new System.Drawing.Size(70, 70);
            this.p_6.TabIndex = 24;
            this.p_6.Text = "6";
            this.p_6.UseVisualStyleBackColor = false;
            this.p_6.Click += new System.EventHandler(this.p_6_Click);
            // 
            // p_5
            // 
            this.p_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_5.Enabled = false;
            this.p_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p_5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p_5.Location = new System.Drawing.Point(127, 206);
            this.p_5.Name = "p_5";
            this.p_5.Size = new System.Drawing.Size(70, 70);
            this.p_5.TabIndex = 23;
            this.p_5.Text = "5";
            this.p_5.UseVisualStyleBackColor = false;
            this.p_5.Click += new System.EventHandler(this.p_5_Click);
            // 
            // p_7
            // 
            this.p_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_7.Enabled = false;
            this.p_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p_7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p_7.Location = new System.Drawing.Point(27, 296);
            this.p_7.Name = "p_7";
            this.p_7.Size = new System.Drawing.Size(70, 70);
            this.p_7.TabIndex = 22;
            this.p_7.Text = "7";
            this.p_7.UseVisualStyleBackColor = false;
            this.p_7.Click += new System.EventHandler(this.p_7_Click);
            // 
            // p_4
            // 
            this.p_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_4.Enabled = false;
            this.p_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p_4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p_4.Location = new System.Drawing.Point(27, 206);
            this.p_4.Name = "p_4";
            this.p_4.Size = new System.Drawing.Size(70, 70);
            this.p_4.TabIndex = 21;
            this.p_4.Text = "4";
            this.p_4.UseVisualStyleBackColor = false;
            this.p_4.Click += new System.EventHandler(this.p_4_Click);
            // 
            // p_3
            // 
            this.p_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_3.Enabled = false;
            this.p_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p_3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p_3.Location = new System.Drawing.Point(231, 117);
            this.p_3.Name = "p_3";
            this.p_3.Size = new System.Drawing.Size(70, 70);
            this.p_3.TabIndex = 20;
            this.p_3.Text = "3";
            this.p_3.UseVisualStyleBackColor = false;
            this.p_3.Click += new System.EventHandler(this.p_3_Click);
            // 
            // p_2
            // 
            this.p_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_2.Enabled = false;
            this.p_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p_2.Location = new System.Drawing.Point(127, 117);
            this.p_2.Name = "p_2";
            this.p_2.Size = new System.Drawing.Size(70, 70);
            this.p_2.TabIndex = 19;
            this.p_2.Text = "2";
            this.p_2.UseVisualStyleBackColor = false;
            this.p_2.Click += new System.EventHandler(this.p_2_Click);
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxPIN.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPIN.Location = new System.Drawing.Point(27, 53);
            this.textBoxPIN.MaxLength = 12;
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.ReadOnly = true;
            this.textBoxPIN.Size = new System.Drawing.Size(170, 39);
            this.textBoxPIN.TabIndex = 18;
            this.textBoxPIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPIN.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxPIN.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // p_1
            // 
            this.p_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_1.Enabled = false;
            this.p_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p_1.Location = new System.Drawing.Point(27, 117);
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(70, 70);
            this.p_1.TabIndex = 17;
            this.p_1.Text = "1";
            this.p_1.UseVisualStyleBackColor = false;
            this.p_1.Click += new System.EventHandler(this.p_1_Click);
            // 
            // textBoxL
            // 
            this.textBoxL.BackColor = System.Drawing.Color.LightGray;
            this.textBoxL.Location = new System.Drawing.Point(372, 392);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(49, 20);
            this.textBoxL.TabIndex = 31;
            this.textBoxL.Text = "P";
            this.textBoxL.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(394, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 38);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "PLN";
            this.textBox1.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(261, 469);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(0, 13);
            this.labelF.TabIndex = 34;
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.Transparent;
            this.buttonC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonC.BackgroundImage")));
            this.buttonC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonC.FlatAppearance.BorderSize = 0;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Location = new System.Drawing.Point(87, 479);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(168, 105);
            this.buttonC.TabIndex = 35;
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 30000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // KartaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(474, 594);
            this.ControlBox = false;
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonK);
            this.Controls.Add(this.p_0);
            this.Controls.Add(this.p_9);
            this.Controls.Add(this.p_8);
            this.Controls.Add(this.p_6);
            this.Controls.Add(this.p_5);
            this.Controls.Add(this.p_7);
            this.Controls.Add(this.p_4);
            this.Controls.Add(this.p_3);
            this.Controls.Add(this.p_2);
            this.Controls.Add(this.textBoxPIN);
            this.Controls.Add(this.p_1);
            this.Controls.Add(this.buttonZ);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 600);
            this.Name = "KartaForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.KartaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonK;
        private System.Windows.Forms.Button p_0;
        private System.Windows.Forms.Button p_9;
        private System.Windows.Forms.Button p_8;
        private System.Windows.Forms.Button p_6;
        private System.Windows.Forms.Button p_5;
        private System.Windows.Forms.Button p_7;
        private System.Windows.Forms.Button p_4;
        private System.Windows.Forms.Button p_3;
        private System.Windows.Forms.Button p_2;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.Button p_1;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Timer timer2;
    }
}