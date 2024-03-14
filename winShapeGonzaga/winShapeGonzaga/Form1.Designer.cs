namespace winShapeGonzaga
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rectLengthTextBox = new System.Windows.Forms.TextBox();
            this.rectWidthTextBox = new System.Windows.Forms.TextBox();
            this.rectCalculateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.circleRadiusTextBox = new System.Windows.Forms.TextBox();
            this.circleCalculateButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.triCalculateButton = new System.Windows.Forms.Button();
            this.triHeightTextBox = new System.Windows.Forms.TextBox();
            this.triBaseLengthTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rectResultLabel = new System.Windows.Forms.Label();
            this.circleResultLabel = new System.Windows.Forms.Label();
            this.triResultLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rectResultLabel);
            this.groupBox1.Controls.Add(this.rectCalculateButton);
            this.groupBox1.Controls.Add(this.rectWidthTextBox);
            this.groupBox1.Controls.Add(this.rectLengthTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Area of A Rectangle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // rectLengthTextBox
            // 
            this.rectLengthTextBox.Location = new System.Drawing.Point(84, 30);
            this.rectLengthTextBox.Name = "rectLengthTextBox";
            this.rectLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.rectLengthTextBox.TabIndex = 2;
            this.rectLengthTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rectWidthTextBox
            // 
            this.rectWidthTextBox.Location = new System.Drawing.Point(84, 57);
            this.rectWidthTextBox.Name = "rectWidthTextBox";
            this.rectWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.rectWidthTextBox.TabIndex = 3;
            // 
            // rectCalculateButton
            // 
            this.rectCalculateButton.Location = new System.Drawing.Point(20, 119);
            this.rectCalculateButton.Name = "rectCalculateButton";
            this.rectCalculateButton.Size = new System.Drawing.Size(164, 23);
            this.rectCalculateButton.TabIndex = 4;
            this.rectCalculateButton.Text = "Calculate";
            this.rectCalculateButton.UseVisualStyleBackColor = true;
            this.rectCalculateButton.Click += new System.EventHandler(this.rectCalculateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Radius";
            // 
            // circleRadiusTextBox
            // 
            this.circleRadiusTextBox.Location = new System.Drawing.Point(84, 30);
            this.circleRadiusTextBox.Name = "circleRadiusTextBox";
            this.circleRadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.circleRadiusTextBox.TabIndex = 2;
            // 
            // circleCalculateButton
            // 
            this.circleCalculateButton.Location = new System.Drawing.Point(20, 84);
            this.circleCalculateButton.Name = "circleCalculateButton";
            this.circleCalculateButton.Size = new System.Drawing.Size(164, 23);
            this.circleCalculateButton.TabIndex = 4;
            this.circleCalculateButton.Text = "Calculate";
            this.circleCalculateButton.UseVisualStyleBackColor = true;
            this.circleCalculateButton.Click += new System.EventHandler(this.circleCalculateButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.circleResultLabel);
            this.groupBox2.Controls.Add(this.circleCalculateButton);
            this.groupBox2.Controls.Add(this.circleRadiusTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 117);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Area of a Circle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Shapes Calculator";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "by Nimu Gonzaga";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.triResultLabel);
            this.groupBox3.Controls.Add(this.triCalculateButton);
            this.groupBox3.Controls.Add(this.triHeightTextBox);
            this.groupBox3.Controls.Add(this.triBaseLengthTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 385);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 147);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Area of A Triangle";
            // 
            // triCalculateButton
            // 
            this.triCalculateButton.Location = new System.Drawing.Point(20, 118);
            this.triCalculateButton.Name = "triCalculateButton";
            this.triCalculateButton.Size = new System.Drawing.Size(164, 23);
            this.triCalculateButton.TabIndex = 4;
            this.triCalculateButton.Text = "Calculate";
            this.triCalculateButton.UseVisualStyleBackColor = true;
            this.triCalculateButton.Click += new System.EventHandler(this.triCalculateButton_Click);
            // 
            // triHeightTextBox
            // 
            this.triHeightTextBox.Location = new System.Drawing.Point(84, 57);
            this.triHeightTextBox.Name = "triHeightTextBox";
            this.triHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.triHeightTextBox.TabIndex = 3;
            // 
            // triBaseLengthTextBox
            // 
            this.triBaseLengthTextBox.Location = new System.Drawing.Point(84, 30);
            this.triBaseLengthTextBox.Name = "triBaseLengthTextBox";
            this.triBaseLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.triBaseLengthTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Base Length";
            // 
            // rectResultLabel
            // 
            this.rectResultLabel.AutoSize = true;
            this.rectResultLabel.Location = new System.Drawing.Point(81, 93);
            this.rectResultLabel.Name = "rectResultLabel";
            this.rectResultLabel.Size = new System.Drawing.Size(14, 13);
            this.rectResultLabel.TabIndex = 5;
            this.rectResultLabel.Text = "~";
            this.rectResultLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // circleResultLabel
            // 
            this.circleResultLabel.AutoSize = true;
            this.circleResultLabel.Location = new System.Drawing.Point(81, 58);
            this.circleResultLabel.Name = "circleResultLabel";
            this.circleResultLabel.Size = new System.Drawing.Size(14, 13);
            this.circleResultLabel.TabIndex = 5;
            this.circleResultLabel.Text = "~";
            this.circleResultLabel.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // triResultLabel
            // 
            this.triResultLabel.AutoSize = true;
            this.triResultLabel.Location = new System.Drawing.Point(81, 92);
            this.triResultLabel.Name = "triResultLabel";
            this.triResultLabel.Size = new System.Drawing.Size(14, 13);
            this.triResultLabel.TabIndex = 5;
            this.triResultLabel.Text = "~";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Area is";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Area is";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Area is";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 544);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox rectWidthTextBox;
        private System.Windows.Forms.TextBox rectLengthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rectCalculateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox circleRadiusTextBox;
        private System.Windows.Forms.Button circleCalculateButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button triCalculateButton;
        private System.Windows.Forms.TextBox triHeightTextBox;
        private System.Windows.Forms.TextBox triBaseLengthTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label rectResultLabel;
        private System.Windows.Forms.Label circleResultLabel;
        private System.Windows.Forms.Label triResultLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

