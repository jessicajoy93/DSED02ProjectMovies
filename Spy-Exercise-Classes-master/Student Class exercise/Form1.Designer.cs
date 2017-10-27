namespace Student_Class_exercise
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
            this.lbxSpy = new System.Windows.Forms.ListBox();
            this.btnSpyDetails = new System.Windows.Forms.Button();
            this.txtCodeName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.dtpLastSeen = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumberOfAgents = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAgencyName = new System.Windows.Forms.TextBox();
            this.txtAgencyCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbspylevel = new System.Windows.Forms.ComboBox();
            this.btnSaveSpy = new System.Windows.Forms.Button();
            this.btnLoadFiles = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxSpy
            // 
            this.lbxSpy.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbxSpy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxSpy.FormattingEnabled = true;
            this.lbxSpy.ItemHeight = 16;
            this.lbxSpy.Location = new System.Drawing.Point(205, 13);
            this.lbxSpy.Name = "lbxSpy";
            this.lbxSpy.Size = new System.Drawing.Size(212, 144);
            this.lbxSpy.TabIndex = 0;
            this.lbxSpy.SelectedIndexChanged += new System.EventHandler(this.lbspy_SelectedIndexChanged);
            // 
            // btnSpyDetails
            // 
            this.btnSpyDetails.BackColor = System.Drawing.Color.Crimson;
            this.btnSpyDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpyDetails.ForeColor = System.Drawing.Color.White;
            this.btnSpyDetails.Location = new System.Drawing.Point(205, 204);
            this.btnSpyDetails.Name = "btnSpyDetails";
            this.btnSpyDetails.Size = new System.Drawing.Size(189, 33);
            this.btnSpyDetails.TabIndex = 1;
            this.btnSpyDetails.Text = "Create New Spy";
            this.btnSpyDetails.UseVisualStyleBackColor = false;
            this.btnSpyDetails.Click += new System.EventHandler(this.BtnCreateNewSpyClick);
            // 
            // txtCodeName
            // 
            this.txtCodeName.Location = new System.Drawing.Point(6, 53);
            this.txtCodeName.Name = "txtCodeName";
            this.txtCodeName.Size = new System.Drawing.Size(197, 22);
            this.txtCodeName.TabIndex = 2;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(3, 115);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpDOB.TabIndex = 3;
            // 
            // dtpLastSeen
            // 
            this.dtpLastSeen.Location = new System.Drawing.Point(6, 159);
            this.dtpLastSeen.Name = "dtpLastSeen";
            this.dtpLastSeen.Size = new System.Drawing.Size(200, 22);
            this.dtpLastSeen.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date Last Seen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Birth Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Spy Code Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNumberOfAgents);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtAgencyName);
            this.panel1.Controls.Add(this.txtAgencyCountry);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(644, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 170);
            this.panel1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Number Of Agents";
            // 
            // txtNumberOfAgents
            // 
            this.txtNumberOfAgents.Location = new System.Drawing.Point(41, 136);
            this.txtNumberOfAgents.Name = "txtNumberOfAgents";
            this.txtNumberOfAgents.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfAgents.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Agency Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Country";
            // 
            // txtAgencyName
            // 
            this.txtAgencyName.Location = new System.Drawing.Point(38, 91);
            this.txtAgencyName.Name = "txtAgencyName";
            this.txtAgencyName.Size = new System.Drawing.Size(100, 22);
            this.txtAgencyName.TabIndex = 2;
            // 
            // txtAgencyCountry
            // 
            this.txtAgencyCountry.Location = new System.Drawing.Point(38, 46);
            this.txtAgencyCountry.Name = "txtAgencyCountry";
            this.txtAgencyCountry.Size = new System.Drawing.Size(100, 22);
            this.txtAgencyCountry.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Agency";
            // 
            // cbspylevel
            // 
            this.cbspylevel.FormattingEnabled = true;
            this.cbspylevel.Items.AddRange(new object[] {
            "Choose a Spy level",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbspylevel.Location = new System.Drawing.Point(205, 174);
            this.cbspylevel.Name = "cbspylevel";
            this.cbspylevel.Size = new System.Drawing.Size(161, 24);
            this.cbspylevel.TabIndex = 9;
            this.cbspylevel.SelectedIndexChanged += new System.EventHandler(this.cbspylevel_SelectedIndexChanged);
            // 
            // btnSaveSpy
            // 
            this.btnSaveSpy.Location = new System.Drawing.Point(434, 205);
            this.btnSaveSpy.Name = "btnSaveSpy";
            this.btnSaveSpy.Size = new System.Drawing.Size(189, 32);
            this.btnSaveSpy.TabIndex = 10;
            this.btnSaveSpy.Text = "Save Spy";
            this.btnSaveSpy.UseVisualStyleBackColor = true;
            this.btnSaveSpy.Visible = false;
            this.btnSaveSpy.Click += new System.EventHandler(this.BtnSaveSpy_Click);
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Location = new System.Drawing.Point(644, 205);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(189, 30);
            this.btnLoadFiles.TabIndex = 11;
            this.btnLoadFiles.Text = "Load files";
            this.btnLoadFiles.UseVisualStyleBackColor = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtCodeName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpDOB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpLastSeen);
            this.panel2.Location = new System.Drawing.Point(434, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 186);
            this.panel2.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Green;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(202, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Choose Spy Level";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Class_exercise.Properties.Resources.TopSecret;
            this.pictureBox1.Location = new System.Drawing.Point(28, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Spy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(848, 243);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLoadFiles);
            this.Controls.Add(this.btnSaveSpy);
            this.Controls.Add(this.cbspylevel);
            this.Controls.Add(this.lbxSpy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSpyDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lbxSpy;
    private System.Windows.Forms.Button btnSpyDetails;
    private System.Windows.Forms.TextBox txtCodeName;
    private System.Windows.Forms.DateTimePicker dtpDOB;
    private System.Windows.Forms.DateTimePicker dtpLastSeen;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtAgencyName;
    private System.Windows.Forms.TextBox txtAgencyCountry;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtNumberOfAgents;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ComboBox cbspylevel;
    private System.Windows.Forms.Button btnSaveSpy;
    private System.Windows.Forms.Button btnLoadFiles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
    }
}

