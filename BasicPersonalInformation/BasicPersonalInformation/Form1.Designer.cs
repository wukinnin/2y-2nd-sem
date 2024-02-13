namespace BasicPersonalInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lNameTxt = new System.Windows.Forms.TextBox();
            this.BPI = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.mNameTxt = new System.Windows.Forms.TextBox();
            this.fNameTxt = new System.Windows.Forms.TextBox();
            this.SecondName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Soccer = new System.Windows.Forms.CheckBox();
            this.Tennis = new System.Windows.Forms.CheckBox();
            this.Volleyball = new System.Windows.Forms.CheckBox();
            this.Basketball = new System.Windows.Forms.CheckBox();
            this.Sports = new System.Windows.Forms.Label();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Gender = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.cStatus = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Bdate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lNameTxt);
            this.groupBox1.Controls.Add(this.BPI);
            this.groupBox1.Controls.Add(this.lName);
            this.groupBox1.Controls.Add(this.FirstName);
            this.groupBox1.Controls.Add(this.mNameTxt);
            this.groupBox1.Controls.Add(this.fNameTxt);
            this.groupBox1.Controls.Add(this.SecondName);
            this.groupBox1.Location = new System.Drawing.Point(17, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lNameTxt
            // 
            this.lNameTxt.Location = new System.Drawing.Point(85, 114);
            this.lNameTxt.Name = "lNameTxt";
            this.lNameTxt.Size = new System.Drawing.Size(136, 20);
            this.lNameTxt.TabIndex = 7;
            // 
            // BPI
            // 
            this.BPI.AutoSize = true;
            this.BPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPI.Location = new System.Drawing.Point(6, 16);
            this.BPI.Name = "BPI";
            this.BPI.Size = new System.Drawing.Size(158, 13);
            this.BPI.TabIndex = 3;
            this.BPI.Text = "Basic Personal Information";
            this.BPI.Click += new System.EventHandler(this.BPI_Click);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(6, 114);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(58, 13);
            this.lName.TabIndex = 4;
            this.lName.Text = "Last Name";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(6, 43);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(57, 13);
            this.FirstName.TabIndex = 6;
            this.FirstName.Text = "First Name";
            // 
            // mNameTxt
            // 
            this.mNameTxt.Location = new System.Drawing.Point(85, 78);
            this.mNameTxt.Name = "mNameTxt";
            this.mNameTxt.ShortcutsEnabled = false;
            this.mNameTxt.Size = new System.Drawing.Size(136, 20);
            this.mNameTxt.TabIndex = 8;
            // 
            // fNameTxt
            // 
            this.fNameTxt.Location = new System.Drawing.Point(85, 40);
            this.fNameTxt.Name = "fNameTxt";
            this.fNameTxt.Size = new System.Drawing.Size(136, 20);
            this.fNameTxt.TabIndex = 9;
            // 
            // SecondName
            // 
            this.SecondName.AutoSize = true;
            this.SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondName.Location = new System.Drawing.Point(6, 81);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(69, 13);
            this.SecondName.TabIndex = 5;
            this.SecondName.Text = "Middle Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Soccer);
            this.groupBox2.Controls.Add(this.Tennis);
            this.groupBox2.Controls.Add(this.Volleyball);
            this.groupBox2.Controls.Add(this.Basketball);
            this.groupBox2.Controls.Add(this.Sports);
            this.groupBox2.Controls.Add(this.Female);
            this.groupBox2.Controls.Add(this.Male);
            this.groupBox2.Controls.Add(this.Gender);
            this.groupBox2.Controls.Add(this.comboBox);
            this.groupBox2.Controls.Add(this.cStatus);
            this.groupBox2.Controls.Add(this.Date);
            this.groupBox2.Controls.Add(this.Bdate);
            this.groupBox2.Location = new System.Drawing.Point(8, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 187);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Soccer
            // 
            this.Soccer.AutoSize = true;
            this.Soccer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soccer.Location = new System.Drawing.Point(182, 148);
            this.Soccer.Name = "Soccer";
            this.Soccer.Size = new System.Drawing.Size(60, 17);
            this.Soccer.TabIndex = 17;
            this.Soccer.Text = "&Soccer";
            this.Soccer.UseVisualStyleBackColor = true;
            // 
            // Tennis
            // 
            this.Tennis.AutoSize = true;
            this.Tennis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tennis.Location = new System.Drawing.Point(182, 125);
            this.Tennis.Name = "Tennis";
            this.Tennis.Size = new System.Drawing.Size(58, 17);
            this.Tennis.TabIndex = 18;
            this.Tennis.Text = "&Tennis";
            this.Tennis.UseVisualStyleBackColor = true;
            // 
            // Volleyball
            // 
            this.Volleyball.AutoSize = true;
            this.Volleyball.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volleyball.Location = new System.Drawing.Point(85, 148);
            this.Volleyball.Name = "Volleyball";
            this.Volleyball.Size = new System.Drawing.Size(70, 17);
            this.Volleyball.TabIndex = 19;
            this.Volleyball.Text = "&Volleyball";
            this.Volleyball.UseVisualStyleBackColor = true;
            // 
            // Basketball
            // 
            this.Basketball.AutoSize = true;
            this.Basketball.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Basketball.Location = new System.Drawing.Point(85, 125);
            this.Basketball.Name = "Basketball";
            this.Basketball.Size = new System.Drawing.Size(75, 17);
            this.Basketball.TabIndex = 20;
            this.Basketball.Text = "&Basketball";
            this.Basketball.UseVisualStyleBackColor = true;
            // 
            // Sports
            // 
            this.Sports.AutoSize = true;
            this.Sports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sports.Location = new System.Drawing.Point(6, 125);
            this.Sports.Name = "Sports";
            this.Sports.Size = new System.Drawing.Size(37, 13);
            this.Sports.TabIndex = 16;
            this.Sports.Text = "Sports";
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female.Location = new System.Drawing.Point(144, 91);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(59, 17);
            this.Female.TabIndex = 14;
            this.Female.TabStop = true;
            this.Female.Text = "&Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male.Location = new System.Drawing.Point(85, 91);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(48, 17);
            this.Male.TabIndex = 15;
            this.Male.TabStop = true;
            this.Male.Text = "&Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(6, 91);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(42, 13);
            this.Gender.TabIndex = 13;
            this.Gender.Text = "Gender";
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced"});
            this.comboBox.Location = new System.Drawing.Point(85, 56);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(132, 21);
            this.comboBox.TabIndex = 12;
            this.comboBox.Text = "<< Select One >>";
            // 
            // cStatus
            // 
            this.cStatus.AutoSize = true;
            this.cStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cStatus.Location = new System.Drawing.Point(6, 59);
            this.cStatus.Name = "cStatus";
            this.cStatus.Size = new System.Drawing.Size(59, 13);
            this.cStatus.TabIndex = 11;
            this.cStatus.Text = "Civil Status";
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(85, 25);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(206, 20);
            this.Date.TabIndex = 10;
            // 
            // Bdate
            // 
            this.Bdate.AutoSize = true;
            this.Bdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdate.Location = new System.Drawing.Point(6, 25);
            this.Bdate.Name = "Bdate";
            this.Bdate.Size = new System.Drawing.Size(54, 13);
            this.Bdate.TabIndex = 9;
            this.Bdate.Text = "Birth Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(357, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(357, 165);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(126, 23);
            this.displayButton.TabIndex = 4;
            this.displayButton.Text = "Display Information";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 416);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lNameTxt;
        private System.Windows.Forms.Label BPI;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox mNameTxt;
        private System.Windows.Forms.TextBox fNameTxt;
        private System.Windows.Forms.Label SecondName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Soccer;
        private System.Windows.Forms.CheckBox Tennis;
        private System.Windows.Forms.CheckBox Volleyball;
        private System.Windows.Forms.CheckBox Basketball;
        private System.Windows.Forms.Label Sports;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label cStatus;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label Bdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button displayButton;
    }
}

