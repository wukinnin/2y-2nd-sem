namespace winTemp
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
            this.trbCelsius = new System.Windows.Forms.TrackBar();
            this.lblCelcius = new System.Windows.Forms.Label();
            this.lblCelVal = new System.Windows.Forms.Label();
            this.lblFarVal = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblKelVal = new System.Windows.Forms.Label();
            this.lblKelvin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbCelsius)).BeginInit();
            this.SuspendLayout();
            // 
            // trbCelsius
            // 
            this.trbCelsius.Location = new System.Drawing.Point(12, 51);
            this.trbCelsius.Maximum = 100;
            this.trbCelsius.Minimum = -100;
            this.trbCelsius.Name = "trbCelsius";
            this.trbCelsius.Size = new System.Drawing.Size(879, 45);
            this.trbCelsius.TabIndex = 0;
            this.trbCelsius.TickFrequency = 10;
            this.trbCelsius.Scroll += new System.EventHandler(this.trbCelcius_Scroll);
            // 
            // lblCelcius
            // 
            this.lblCelcius.AutoSize = true;
            this.lblCelcius.Location = new System.Drawing.Point(12, 24);
            this.lblCelcius.Name = "lblCelcius";
            this.lblCelcius.Size = new System.Drawing.Size(40, 13);
            this.lblCelcius.TabIndex = 1;
            this.lblCelcius.Text = "Celsius";
            // 
            // lblCelVal
            // 
            this.lblCelVal.AutoSize = true;
            this.lblCelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelVal.Location = new System.Drawing.Point(96, 24);
            this.lblCelVal.Name = "lblCelVal";
            this.lblCelVal.Size = new System.Drawing.Size(66, 13);
            this.lblCelVal.TabIndex = 2;
            this.lblCelVal.Text = "<<value>>";
            // 
            // lblFarVal
            // 
            this.lblFarVal.AutoSize = true;
            this.lblFarVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarVal.Location = new System.Drawing.Point(96, 107);
            this.lblFarVal.Name = "lblFarVal";
            this.lblFarVal.Size = new System.Drawing.Size(66, 13);
            this.lblFarVal.TabIndex = 4;
            this.lblFarVal.Text = "<<value>>";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(12, 107);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(57, 13);
            this.lblF.TabIndex = 3;
            this.lblF.Text = "Fahrenheit";
            // 
            // lblKelVal
            // 
            this.lblKelVal.AutoSize = true;
            this.lblKelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelVal.Location = new System.Drawing.Point(96, 134);
            this.lblKelVal.Name = "lblKelVal";
            this.lblKelVal.Size = new System.Drawing.Size(66, 13);
            this.lblKelVal.TabIndex = 6;
            this.lblKelVal.Text = "<<value>>";
            // 
            // lblKelvin
            // 
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Location = new System.Drawing.Point(12, 134);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(36, 13);
            this.lblKelvin.TabIndex = 5;
            this.lblKelvin.Text = "Kelvin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 166);
            this.Controls.Add(this.lblKelVal);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.lblFarVal);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblCelVal);
            this.Controls.Add(this.lblCelcius);
            this.Controls.Add(this.trbCelsius);
            this.Name = "Form1";
            this.Text = "Temparature Converter";
            ((System.ComponentModel.ISupportInitialize)(this.trbCelsius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbCelsius;
        private System.Windows.Forms.Label lblCelcius;
        private System.Windows.Forms.Label lblCelVal;
        private System.Windows.Forms.Label lblFarVal;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblKelVal;
        private System.Windows.Forms.Label lblKelvin;
    }
}

