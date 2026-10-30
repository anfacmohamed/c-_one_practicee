namespace airline_ticked_booking_system
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbaggage = new System.Windows.Forms.TextBox();
            this.txttickets = new System.Windows.Forms.TextBox();
            this.txtpassengerage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassengername = new System.Windows.Forms.TextBox();
            this.rdnnormalclass = new System.Windows.Forms.GroupBox();
            this.rdnfirstclass = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdnbusinessclass = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.checkBoxaddtravelinsurance = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.rdnnormalclass.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "passenger name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.txtbaggage);
            this.groupBox1.Controls.Add(this.txttickets);
            this.groupBox1.Controls.Add(this.txtpassengerage);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtpassengername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(331, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "personal information";
            // 
            // txtbaggage
            // 
            this.txtbaggage.Location = new System.Drawing.Point(184, 134);
            this.txtbaggage.Name = "txtbaggage";
            this.txtbaggage.Size = new System.Drawing.Size(100, 20);
            this.txtbaggage.TabIndex = 3;
            // 
            // txttickets
            // 
            this.txttickets.Location = new System.Drawing.Point(184, 96);
            this.txttickets.Name = "txttickets";
            this.txttickets.Size = new System.Drawing.Size(100, 20);
            this.txttickets.TabIndex = 4;
            // 
            // txtpassengerage
            // 
            this.txtpassengerage.Location = new System.Drawing.Point(184, 69);
            this.txtpassengerage.Name = "txtpassengerage";
            this.txtpassengerage.Size = new System.Drawing.Size(100, 20);
            this.txtpassengerage.TabIndex = 5;
            this.txtpassengerage.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "baggage weight(kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "tickets";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "passenger age";
            // 
            // txtpassengername
            // 
            this.txtpassengername.Location = new System.Drawing.Point(184, 27);
            this.txtpassengername.Name = "txtpassengername";
            this.txtpassengername.Size = new System.Drawing.Size(100, 20);
            this.txtpassengername.TabIndex = 2;
            // 
            // rdnnormalclass
            // 
            this.rdnnormalclass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdnnormalclass.Controls.Add(this.rdnfirstclass);
            this.rdnnormalclass.Controls.Add(this.radioButton2);
            this.rdnnormalclass.Controls.Add(this.rdnbusinessclass);
            this.rdnnormalclass.Location = new System.Drawing.Point(6, 199);
            this.rdnnormalclass.Name = "rdnnormalclass";
            this.rdnnormalclass.Size = new System.Drawing.Size(324, 100);
            this.rdnnormalclass.TabIndex = 2;
            this.rdnnormalclass.TabStop = false;
            this.rdnnormalclass.Text = "travel class";
            this.rdnnormalclass.Enter += new System.EventHandler(this.rdnnormalclass_Enter);
            // 
            // rdnfirstclass
            // 
            this.rdnfirstclass.AutoSize = true;
            this.rdnfirstclass.Location = new System.Drawing.Point(22, 49);
            this.rdnfirstclass.Name = "rdnfirstclass";
            this.rdnfirstclass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdnfirstclass.Size = new System.Drawing.Size(68, 17);
            this.rdnfirstclass.TabIndex = 3;
            this.rdnfirstclass.TabStop = true;
            this.rdnfirstclass.Text = "first class";
            this.rdnfirstclass.UseVisualStyleBackColor = true;
            this.rdnfirstclass.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(126, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "normal class";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdnbusinessclass
            // 
            this.rdnbusinessclass.AutoSize = true;
            this.rdnbusinessclass.Location = new System.Drawing.Point(225, 49);
            this.rdnbusinessclass.Name = "rdnbusinessclass";
            this.rdnbusinessclass.Size = new System.Drawing.Size(93, 17);
            this.rdnbusinessclass.TabIndex = 5;
            this.rdnbusinessclass.TabStop = true;
            this.rdnbusinessclass.Text = "business class";
            this.rdnbusinessclass.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Controls.Add(this.btncalculate);
            this.groupBox3.Controls.Add(this.btnclear);
            this.groupBox3.Controls.Add(this.btnexit);
            this.groupBox3.Controls.Add(this.checkBoxaddtravelinsurance);
            this.groupBox3.Location = new System.Drawing.Point(6, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 116);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "add options";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(15, 64);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 23);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(118, 64);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(237, 64);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // checkBoxaddtravelinsurance
            // 
            this.checkBoxaddtravelinsurance.AutoSize = true;
            this.checkBoxaddtravelinsurance.Location = new System.Drawing.Point(62, 19);
            this.checkBoxaddtravelinsurance.Name = "checkBoxaddtravelinsurance";
            this.checkBoxaddtravelinsurance.Size = new System.Drawing.Size(196, 17);
            this.checkBoxaddtravelinsurance.TabIndex = 7;
            this.checkBoxaddtravelinsurance.Text = "add travel insurance ($25 per ticket)";
            this.checkBoxaddtravelinsurance.UseVisualStyleBackColor = true;
            this.checkBoxaddtravelinsurance.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(603, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 212);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.rdnnormalclass);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.rdnnormalclass.ResumeLayout(false);
            this.rdnnormalclass.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbaggage;
        private System.Windows.Forms.TextBox txttickets;
        private System.Windows.Forms.TextBox txtpassengerage;
        private System.Windows.Forms.TextBox txtpassengername;
        private System.Windows.Forms.GroupBox rdnnormalclass;
        private System.Windows.Forms.RadioButton rdnfirstclass;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdnbusinessclass;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.CheckBox checkBoxaddtravelinsurance;
        private System.Windows.Forms.ListBox listBox1;
    }
}

