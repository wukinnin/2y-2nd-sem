namespace winConversion
{
    partial class formConversion
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
            this.label2 = new System.Windows.Forms.Label();
            this.textboxLengthInCentimeters = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelYard = new System.Windows.Forms.Label();
            this.labelFoot = new System.Windows.Forms.Label();
            this.labelInch = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversion Program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter length (in cm)";
            // 
            // textboxLengthInCentimeters
            // 
            this.textboxLengthInCentimeters.Location = new System.Drawing.Point(176, 55);
            this.textboxLengthInCentimeters.Name = "textboxLengthInCentimeters";
            this.textboxLengthInCentimeters.Size = new System.Drawing.Size(100, 20);
            this.textboxLengthInCentimeters.TabIndex = 2;
            this.textboxLengthInCentimeters.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "yard/s";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "foot (feet)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "inch/es";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelYard
            // 
            this.labelYard.AutoSize = true;
            this.labelYard.Location = new System.Drawing.Point(131, 134);
            this.labelYard.Name = "labelYard";
            this.labelYard.Size = new System.Drawing.Size(12, 13);
            this.labelYard.TabIndex = 6;
            this.labelYard.Text = "/";
            // 
            // labelFoot
            // 
            this.labelFoot.AutoSize = true;
            this.labelFoot.Location = new System.Drawing.Point(131, 169);
            this.labelFoot.Name = "labelFoot";
            this.labelFoot.Size = new System.Drawing.Size(12, 13);
            this.labelFoot.TabIndex = 7;
            this.labelFoot.Text = "/";
            // 
            // labelInch
            // 
            this.labelInch.AutoSize = true;
            this.labelInch.Location = new System.Drawing.Point(131, 204);
            this.labelInch.Name = "labelInch";
            this.labelInch.Size = new System.Drawing.Size(12, 13);
            this.labelInch.TabIndex = 8;
            this.labelInch.Text = "/";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(176, 81);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 9;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // formConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 247);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelInch);
            this.Controls.Add(this.labelFoot);
            this.Controls.Add(this.labelYard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxLengthInCentimeters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formConversion";
            this.Text = "Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxLengthInCentimeters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelYard;
        private System.Windows.Forms.Label labelFoot;
        private System.Windows.Forms.Label labelInch;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

