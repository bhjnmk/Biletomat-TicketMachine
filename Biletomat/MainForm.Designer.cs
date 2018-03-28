namespace Biletomat
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonPL = new System.Windows.Forms.Button();
            this.buttonENG = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.panelG = new System.Windows.Forms.Panel();
            this.buttonJG = new System.Windows.Forms.Button();
            this.buttonJM = new System.Windows.Forms.Button();
            this.buttonOM = new System.Windows.Forms.Button();
            this.buttonOG = new System.Windows.Forms.Button();
            this.panelOst1 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelOM = new System.Windows.Forms.Panel();
            this.buttonBackOM0 = new System.Windows.Forms.Button();
            this.okresoweM1 = new Biletomat.OkresoweM();
            this.panelJM = new System.Windows.Forms.Panel();
            this.buttonBackJM0 = new System.Windows.Forms.Button();
            this.jedn_M1 = new Biletomat.Jedn_M();
            this.buttonBackJM = new System.Windows.Forms.Button();
            this.platnosc2 = new Biletomat.Platnosc();
            this.panelJG = new System.Windows.Forms.Panel();
            this.buttonBackJG0 = new System.Windows.Forms.Button();
            this.jedn_G1 = new Biletomat.Jedn_G();
            this.buttonBackJG = new System.Windows.Forms.Button();
            this.platnosc1 = new Biletomat.Platnosc();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBackOG0 = new System.Windows.Forms.Button();
            this.panelOG = new System.Windows.Forms.Panel();
            this.okresoweG1 = new Biletomat.OkresoweG();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonPL2 = new System.Windows.Forms.Button();
            this.buttonENG2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panelG.SuspendLayout();
            this.panelOst1.SuspendLayout();
            this.panelOM.SuspendLayout();
            this.panelJM.SuspendLayout();
            this.panelJG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelOG.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPL
            // 
            this.buttonPL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPL.BackgroundImage")));
            this.buttonPL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPL.FlatAppearance.BorderSize = 0;
            this.buttonPL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPL.Location = new System.Drawing.Point(780, 61);
            this.buttonPL.Name = "buttonPL";
            this.buttonPL.Size = new System.Drawing.Size(44, 44);
            this.buttonPL.TabIndex = 0;
            this.buttonPL.UseVisualStyleBackColor = true;
            this.buttonPL.Click += new System.EventHandler(this.buttonPL_Click);
            // 
            // buttonENG
            // 
            this.buttonENG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonENG.BackgroundImage")));
            this.buttonENG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonENG.FlatAppearance.BorderSize = 0;
            this.buttonENG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonENG.Location = new System.Drawing.Point(844, 59);
            this.buttonENG.Name = "buttonENG";
            this.buttonENG.Size = new System.Drawing.Size(44, 44);
            this.buttonENG.TabIndex = 1;
            this.buttonENG.UseVisualStyleBackColor = true;
            this.buttonENG.Click += new System.EventHandler(this.buttonENG_Click);
            // 
            // buttonI
            // 
            this.buttonI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonI.BackgroundImage")));
            this.buttonI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonI.FlatAppearance.BorderSize = 0;
            this.buttonI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonI.Location = new System.Drawing.Point(134, 20);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(89, 75);
            this.buttonI.TabIndex = 2;
            this.buttonI.UseVisualStyleBackColor = true;
            this.buttonI.Click += new System.EventHandler(this.buttonI_Click);
            // 
            // buttonH
            // 
            this.buttonH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonH.BackgroundImage")));
            this.buttonH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonH.FlatAppearance.BorderSize = 0;
            this.buttonH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonH.Location = new System.Drawing.Point(25, 20);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(89, 75);
            this.buttonH.TabIndex = 6;
            this.buttonH.UseVisualStyleBackColor = true;
            this.buttonH.Click += new System.EventHandler(this.buttonH_Click);
            // 
            // panelG
            // 
            this.panelG.Controls.Add(this.buttonJG);
            this.panelG.Controls.Add(this.buttonJM);
            this.panelG.Controls.Add(this.buttonOM);
            this.panelG.Controls.Add(this.buttonOG);
            this.panelG.Location = new System.Drawing.Point(0, 115);
            this.panelG.Name = "panelG";
            this.panelG.Size = new System.Drawing.Size(1024, 640);
            this.panelG.TabIndex = 7;
            // 
            // buttonJG
            // 
            this.buttonJG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(164)))));
            this.buttonJG.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonJG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.buttonJG.Location = new System.Drawing.Point(25, 25);
            this.buttonJG.Name = "buttonJG";
            this.buttonJG.Size = new System.Drawing.Size(405, 350);
            this.buttonJG.TabIndex = 12;
            this.buttonJG.Text = "BILETY JEDNORAZOWE";
            this.buttonJG.UseVisualStyleBackColor = false;
            this.buttonJG.Click += new System.EventHandler(this.buttonJG_Click);
            // 
            // buttonJM
            // 
            this.buttonJM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.buttonJM.FlatAppearance.BorderSize = 0;
            this.buttonJM.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonJM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.buttonJM.Location = new System.Drawing.Point(460, 25);
            this.buttonJM.Name = "buttonJM";
            this.buttonJM.Size = new System.Drawing.Size(523, 160);
            this.buttonJM.TabIndex = 9;
            this.buttonJM.Text = "BILETY JEDNORAZOWE METROPOLITALNE";
            this.buttonJM.UseVisualStyleBackColor = false;
            this.buttonJM.Click += new System.EventHandler(this.buttonJM_Click);
            // 
            // buttonOM
            // 
            this.buttonOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.buttonOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.buttonOM.Location = new System.Drawing.Point(459, 215);
            this.buttonOM.Name = "buttonOM";
            this.buttonOM.Size = new System.Drawing.Size(524, 160);
            this.buttonOM.TabIndex = 8;
            this.buttonOM.Text = "BILET OKRESOWY METROPOLITALNY";
            this.buttonOM.UseVisualStyleBackColor = false;
            this.buttonOM.Click += new System.EventHandler(this.buttonOM_Click);
            // 
            // buttonOG
            // 
            this.buttonOG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(164)))));
            this.buttonOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.buttonOG.Location = new System.Drawing.Point(25, 405);
            this.buttonOG.Name = "buttonOG";
            this.buttonOG.Size = new System.Drawing.Size(958, 178);
            this.buttonOG.TabIndex = 7;
            this.buttonOG.Text = "BILETY OKRESOWE ";
            this.buttonOG.UseVisualStyleBackColor = false;
            this.buttonOG.Click += new System.EventHandler(this.buttonOG_Click);
            // 
            // panelOst1
            // 
            this.panelOst1.Controls.Add(this.richTextBox2);
            this.panelOst1.Controls.Add(this.richTextBox1);
            this.panelOst1.Location = new System.Drawing.Point(6, 101);
            this.panelOst1.Name = "panelOst1";
            this.panelOst1.Size = new System.Drawing.Size(1024, 653);
            this.panelOst1.TabIndex = 9;
            this.panelOst1.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(1024, 653);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "\n\n\n\n\n\n\n\n\n";
            this.richTextBox2.Visible = false;
            this.richTextBox2.Enter += new System.EventHandler(this.richTextBox_Enter);
            this.richTextBox2.Leave += new System.EventHandler(this.richtextBox_Leave);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(1024, 653);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "\n\n\n\n\n\n\n\n\n";
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.Enter += new System.EventHandler(this.richTextBox_Enter);
            this.richTextBox1.Leave += new System.EventHandler(this.richtextBox_Leave);
            // 
            // panelOM
            // 
            this.panelOM.Controls.Add(this.buttonBackOM0);
            this.panelOM.Controls.Add(this.okresoweM1);
            this.panelOM.Location = new System.Drawing.Point(1048, 686);
            this.panelOM.MaximumSize = new System.Drawing.Size(1024, 640);
            this.panelOM.MinimumSize = new System.Drawing.Size(1024, 640);
            this.panelOM.Name = "panelOM";
            this.panelOM.Size = new System.Drawing.Size(1024, 640);
            this.panelOM.TabIndex = 11;
            this.panelOM.Visible = false;
            // 
            // buttonBackOM0
            // 
            this.buttonBackOM0.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackOM0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackOM0.BackgroundImage")));
            this.buttonBackOM0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBackOM0.FlatAppearance.BorderSize = 0;
            this.buttonBackOM0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackOM0.Location = new System.Drawing.Point(5, 0);
            this.buttonBackOM0.Name = "buttonBackOM0";
            this.buttonBackOM0.Size = new System.Drawing.Size(89, 67);
            this.buttonBackOM0.TabIndex = 56;
            this.buttonBackOM0.UseVisualStyleBackColor = false;
            this.buttonBackOM0.Click += new System.EventHandler(this.buttonBackOM0_Click);
            // 
            // okresoweM1
            // 
            this.okresoweM1.BackColor = System.Drawing.Color.GhostWhite;
            this.okresoweM1.Location = new System.Drawing.Point(0, 0);
            this.okresoweM1.MaximumSize = new System.Drawing.Size(2000, 1000);
            this.okresoweM1.MinimumSize = new System.Drawing.Size(900, 900);
            this.okresoweM1.Name = "okresoweM1";
            this.okresoweM1.Size = new System.Drawing.Size(1024, 900);
            this.okresoweM1.TabIndex = 0;
            // 
            // panelJM
            // 
            this.panelJM.Controls.Add(this.buttonBackJM0);
            this.panelJM.Controls.Add(this.jedn_M1);
            this.panelJM.Controls.Add(this.buttonBackJM);
            this.panelJM.Controls.Add(this.platnosc2);
            this.panelJM.Location = new System.Drawing.Point(1, 776);
            this.panelJM.MaximumSize = new System.Drawing.Size(1024, 640);
            this.panelJM.MinimumSize = new System.Drawing.Size(1024, 640);
            this.panelJM.Name = "panelJM";
            this.panelJM.Size = new System.Drawing.Size(1024, 640);
            this.panelJM.TabIndex = 10;
            this.panelJM.Visible = false;
            this.panelJM.VisibleChanged += new System.EventHandler(this.panelJM_VisibleChanged);
            // 
            // buttonBackJM0
            // 
            this.buttonBackJM0.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackJM0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackJM0.BackgroundImage")));
            this.buttonBackJM0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBackJM0.FlatAppearance.BorderSize = 0;
            this.buttonBackJM0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackJM0.Location = new System.Drawing.Point(5, 0);
            this.buttonBackJM0.Name = "buttonBackJM0";
            this.buttonBackJM0.Size = new System.Drawing.Size(89, 67);
            this.buttonBackJM0.TabIndex = 55;
            this.buttonBackJM0.UseVisualStyleBackColor = false;
            this.buttonBackJM0.Click += new System.EventHandler(this.buttonBackJM0_Click);
            // 
            // jedn_M1
            // 
            this.jedn_M1.BackColor = System.Drawing.Color.GhostWhite;
            this.jedn_M1.Location = new System.Drawing.Point(0, 0);
            this.jedn_M1.MaximumSize = new System.Drawing.Size(900, 490);
            this.jedn_M1.MinimumSize = new System.Drawing.Size(1024, 980);
            this.jedn_M1.Name = "jedn_M1";
            this.jedn_M1.Size = new System.Drawing.Size(1024, 980);
            this.jedn_M1.TabIndex = 55;
            // 
            // buttonBackJM
            // 
            this.buttonBackJM.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackJM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackJM.BackgroundImage")));
            this.buttonBackJM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBackJM.FlatAppearance.BorderSize = 0;
            this.buttonBackJM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackJM.Location = new System.Drawing.Point(5, 0);
            this.buttonBackJM.Name = "buttonBackJM";
            this.buttonBackJM.Size = new System.Drawing.Size(89, 67);
            this.buttonBackJM.TabIndex = 53;
            this.buttonBackJM.UseVisualStyleBackColor = false;
            this.buttonBackJM.Click += new System.EventHandler(this.buttonBackJM_Click);
            // 
            // platnosc2
            // 
            this.platnosc2.BackColor = System.Drawing.Color.GhostWhite;
            this.platnosc2.Location = new System.Drawing.Point(0, 0);
            this.platnosc2.MaximumSize = new System.Drawing.Size(1024, 620);
            this.platnosc2.MinimumSize = new System.Drawing.Size(1024, 620);
            this.platnosc2.Name = "platnosc2";
            this.platnosc2.Size = new System.Drawing.Size(1024, 620);
            this.platnosc2.TabIndex = 56;
            // 
            // panelJG
            // 
            this.panelJG.Controls.Add(this.buttonBackJG0);
            this.panelJG.Controls.Add(this.jedn_G1);
            this.panelJG.Controls.Add(this.buttonBackJG);
            this.panelJG.Controls.Add(this.platnosc1);
            this.panelJG.Location = new System.Drawing.Point(600, 773);
            this.panelJG.MaximumSize = new System.Drawing.Size(1024, 640);
            this.panelJG.MinimumSize = new System.Drawing.Size(1024, 640);
            this.panelJG.Name = "panelJG";
            this.panelJG.Size = new System.Drawing.Size(1024, 640);
            this.panelJG.TabIndex = 8;
            this.panelJG.Visible = false;
            this.panelJG.VisibleChanged += new System.EventHandler(this.panelJG_VisibleChanged);
            // 
            // buttonBackJG0
            // 
            this.buttonBackJG0.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackJG0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackJG0.BackgroundImage")));
            this.buttonBackJG0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBackJG0.FlatAppearance.BorderSize = 0;
            this.buttonBackJG0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackJG0.Location = new System.Drawing.Point(5, 0);
            this.buttonBackJG0.Name = "buttonBackJG0";
            this.buttonBackJG0.Size = new System.Drawing.Size(89, 67);
            this.buttonBackJG0.TabIndex = 54;
            this.buttonBackJG0.UseVisualStyleBackColor = false;
            this.buttonBackJG0.Click += new System.EventHandler(this.buttonBackJG0_Click);
            // 
            // jedn_G1
            // 
            this.jedn_G1.BackColor = System.Drawing.Color.GhostWhite;
            this.jedn_G1.Location = new System.Drawing.Point(0, 0);
            this.jedn_G1.MaximumSize = new System.Drawing.Size(1024, 950);
            this.jedn_G1.MinimumSize = new System.Drawing.Size(1024, 950);
            this.jedn_G1.Name = "jedn_G1";
            this.jedn_G1.Size = new System.Drawing.Size(1024, 950);
            this.jedn_G1.TabIndex = 55;
            // 
            // buttonBackJG
            // 
            this.buttonBackJG.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackJG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackJG.BackgroundImage")));
            this.buttonBackJG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBackJG.FlatAppearance.BorderSize = 0;
            this.buttonBackJG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackJG.Location = new System.Drawing.Point(5, 0);
            this.buttonBackJG.Name = "buttonBackJG";
            this.buttonBackJG.Size = new System.Drawing.Size(89, 67);
            this.buttonBackJG.TabIndex = 53;
            this.buttonBackJG.UseVisualStyleBackColor = false;
            this.buttonBackJG.Click += new System.EventHandler(this.buttonBackJG_Click);
            // 
            // platnosc1
            // 
            this.platnosc1.BackColor = System.Drawing.Color.GhostWhite;
            this.platnosc1.Location = new System.Drawing.Point(0, 0);
            this.platnosc1.MaximumSize = new System.Drawing.Size(1024, 620);
            this.platnosc1.MinimumSize = new System.Drawing.Size(1024, 620);
            this.platnosc1.Name = "platnosc1";
            this.platnosc1.Size = new System.Drawing.Size(1024, 620);
            this.platnosc1.TabIndex = 56;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(380, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 114);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(164)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(-5, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1030, 4);
            this.label1.TabIndex = 16;
            // 
            // buttonBackOG0
            // 
            this.buttonBackOG0.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackOG0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackOG0.BackgroundImage")));
            this.buttonBackOG0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBackOG0.FlatAppearance.BorderSize = 0;
            this.buttonBackOG0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackOG0.Location = new System.Drawing.Point(5, 0);
            this.buttonBackOG0.Name = "buttonBackOG0";
            this.buttonBackOG0.Size = new System.Drawing.Size(89, 67);
            this.buttonBackOG0.TabIndex = 57;
            this.buttonBackOG0.UseVisualStyleBackColor = false;
            this.buttonBackOG0.Click += new System.EventHandler(this.buttonBackOG0_Click);
            // 
            // panelOG
            // 
            this.panelOG.Controls.Add(this.buttonBackOG0);
            this.panelOG.Controls.Add(this.okresoweG1);
            this.panelOG.Location = new System.Drawing.Point(1135, 40);
            this.panelOG.Name = "panelOG";
            this.panelOG.Size = new System.Drawing.Size(1024, 640);
            this.panelOG.TabIndex = 17;
            // 
            // okresoweG1
            // 
            this.okresoweG1.BackColor = System.Drawing.Color.GhostWhite;
            this.okresoweG1.Location = new System.Drawing.Point(0, 0);
            this.okresoweG1.Name = "okresoweG1";
            this.okresoweG1.Size = new System.Drawing.Size(1024, 640);
            this.okresoweG1.TabIndex = 0;
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(1053, 14);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(100, 20);
            this.textBoxL.TabIndex = 18;
            this.textBoxL.Text = "P";
            this.textBoxL.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelDate.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDate.Location = new System.Drawing.Point(684, 0);
            this.labelDate.Margin = new System.Windows.Forms.Padding(0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(299, 48);
            this.labelDate.TabIndex = 14;
            this.labelDate.Text = "poniedziałek, 23 października 2222\r\n24.24.24";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPL2
            // 
            this.buttonPL2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPL2.BackgroundImage")));
            this.buttonPL2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPL2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPL2.FlatAppearance.BorderSize = 0;
            this.buttonPL2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPL2.Location = new System.Drawing.Point(780, 61);
            this.buttonPL2.Name = "buttonPL2";
            this.buttonPL2.Size = new System.Drawing.Size(44, 44);
            this.buttonPL2.TabIndex = 19;
            this.buttonPL2.UseVisualStyleBackColor = true;
            this.buttonPL2.Visible = false;
            this.buttonPL2.Click += new System.EventHandler(this.buttonPL2_Click);
            // 
            // buttonENG2
            // 
            this.buttonENG2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonENG2.BackgroundImage")));
            this.buttonENG2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonENG2.FlatAppearance.BorderSize = 0;
            this.buttonENG2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonENG2.Location = new System.Drawing.Point(844, 59);
            this.buttonENG2.Name = "buttonENG2";
            this.buttonENG2.Size = new System.Drawing.Size(44, 44);
            this.buttonENG2.TabIndex = 20;
            this.buttonENG2.UseVisualStyleBackColor = true;
            this.buttonENG2.Visible = false;
            this.buttonENG2.Click += new System.EventHandler(this.buttonENG2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(950, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 21;
            // 
            // timer3
            // 
            this.timer3.Interval = 30000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.panelJG);
            this.Controls.Add(this.panelOG);
            this.Controls.Add(this.panelJM);
            this.Controls.Add(this.panelG);
            this.Controls.Add(this.buttonH);
            this.Controls.Add(this.buttonI);
            this.Controls.Add(this.buttonENG);
            this.Controls.Add(this.buttonPL);
            this.Controls.Add(this.panelOM);
            this.Controls.Add(this.buttonPL2);
            this.Controls.Add(this.buttonENG2);
            this.Controls.Add(this.panelOst1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(3000, 3000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 640);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            this.panelG.ResumeLayout(false);
            this.panelOst1.ResumeLayout(false);
            this.panelOM.ResumeLayout(false);
            this.panelJM.ResumeLayout(false);
            this.panelJG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelOG.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPL;
        private System.Windows.Forms.Button buttonENG;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Panel panelG;
        private System.Windows.Forms.Button buttonJG;
        private System.Windows.Forms.Button buttonJM;
        private System.Windows.Forms.Button buttonOM;
        private System.Windows.Forms.Button buttonOG;
        private System.Windows.Forms.Panel panelOst1;
        private System.Windows.Forms.Panel panelJM;
        private System.Windows.Forms.Panel panelJG;
        private System.Windows.Forms.Panel panelOM;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBackJM;
        private Jedn_M jedn_M1;
        private Jedn_G jedn_G1;
        private System.Windows.Forms.Button buttonBackJG;
        private OkresoweM okresoweM1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonBackJM0;
        private System.Windows.Forms.Button buttonBackJG0;
        private System.Windows.Forms.Button buttonBackOM0;
        private OkresoweG okresoweG1;
        private System.Windows.Forms.Button buttonBackOG0;
        private System.Windows.Forms.Panel panelOG;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBoxL;
        private Platnosc platnosc2;
        private Platnosc platnosc1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonPL2;
        private System.Windows.Forms.Button buttonENG2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer3;
    }
}

