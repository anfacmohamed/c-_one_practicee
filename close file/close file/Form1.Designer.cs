namespace close_file
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
            this.btnreadlines = new System.Windows.Forms.Button();
            this.btnreadAlllines = new System.Windows.Forms.Button();
            this.btnreadblock = new System.Windows.Forms.Button();
            this.btnwritefile = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndeleteitems = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.ListBox();
            this.btndeletethefile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnreadlines
            // 
            this.btnreadlines.Location = new System.Drawing.Point(147, 33);
            this.btnreadlines.Name = "btnreadlines";
            this.btnreadlines.Size = new System.Drawing.Size(75, 23);
            this.btnreadlines.TabIndex = 0;
            this.btnreadlines.Text = "readlines";
            this.btnreadlines.UseVisualStyleBackColor = true;
            // 
            // btnreadAlllines
            // 
            this.btnreadAlllines.Location = new System.Drawing.Point(147, 94);
            this.btnreadAlllines.Name = "btnreadAlllines";
            this.btnreadAlllines.Size = new System.Drawing.Size(75, 23);
            this.btnreadAlllines.TabIndex = 1;
            this.btnreadAlllines.Text = "readAlllines";
            this.btnreadAlllines.UseVisualStyleBackColor = true;
            this.btnreadAlllines.Click += new System.EventHandler(this.btnreadAlllines_Click);
            // 
            // btnreadblock
            // 
            this.btnreadblock.Location = new System.Drawing.Point(147, 201);
            this.btnreadblock.Name = "btnreadblock";
            this.btnreadblock.Size = new System.Drawing.Size(75, 23);
            this.btnreadblock.TabIndex = 2;
            this.btnreadblock.Text = "readblock";
            this.btnreadblock.UseVisualStyleBackColor = true;
            // 
            // btnwritefile
            // 
            this.btnwritefile.Location = new System.Drawing.Point(147, 297);
            this.btnwritefile.Name = "btnwritefile";
            this.btnwritefile.Size = new System.Drawing.Size(75, 23);
            this.btnwritefile.TabIndex = 3;
            this.btnwritefile.Text = "write file";
            this.btnwritefile.UseVisualStyleBackColor = true;
            this.btnwritefile.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(363, 309);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndeleteitems
            // 
            this.btndeleteitems.Location = new System.Drawing.Point(336, 155);
            this.btndeleteitems.Name = "btndeleteitems";
            this.btndeleteitems.Size = new System.Drawing.Size(75, 23);
            this.btndeleteitems.TabIndex = 6;
            this.btndeleteitems.Text = "delete items from the file";
            this.btndeleteitems.UseVisualStyleBackColor = true;
            this.btndeleteitems.Click += new System.EventHandler(this.btndeleteitems_Click);
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(516, 50);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(168, 212);
            this.listbox.TabIndex = 7;
            // 
            // btndeletethefile
            // 
            this.btndeletethefile.Location = new System.Drawing.Point(336, 245);
            this.btndeletethefile.Name = "btndeletethefile";
            this.btndeletethefile.Size = new System.Drawing.Size(75, 23);
            this.btndeletethefile.TabIndex = 8;
            this.btndeletethefile.Text = "delete the file";
            this.btndeletethefile.UseVisualStyleBackColor = true;
            this.btndeletethefile.Click += new System.EventHandler(this.btndeletethefile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndeletethefile);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.btndeleteitems);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnwritefile);
            this.Controls.Add(this.btnreadblock);
            this.Controls.Add(this.btnreadAlllines);
            this.Controls.Add(this.btnreadlines);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnreadlines;
        private System.Windows.Forms.Button btnreadAlllines;
        private System.Windows.Forms.Button btnreadblock;
        private System.Windows.Forms.Button btnwritefile;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndeleteitems;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button btndeletethefile;
    }
}

