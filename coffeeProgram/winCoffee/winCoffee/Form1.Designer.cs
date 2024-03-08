namespace winCoffee
{
    partial class coffeeForm
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
            this.labelCoffeeBag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCoffee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelBags = new System.Windows.Forms.Label();
            this.labelLarge = new System.Windows.Forms.Label();
            this.labelMedium = new System.Windows.Forms.Label();
            this.labelSmall = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCoffeeBag
            // 
            this.labelCoffeeBag.AutoSize = true;
            this.labelCoffeeBag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoffeeBag.Location = new System.Drawing.Point(52, 18);
            this.labelCoffeeBag.Name = "labelCoffeeBag";
            this.labelCoffeeBag.Size = new System.Drawing.Size(76, 13);
            this.labelCoffeeBag.TabIndex = 0;
            this.labelCoffeeBag.Text = "Coffee Bags";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter bags to order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxCoffee
            // 
            this.textBoxCoffee.Location = new System.Drawing.Point(161, 51);
            this.textBoxCoffee.Name = "textBoxCoffee";
            this.textBoxCoffee.Size = new System.Drawing.Size(68, 20);
            this.textBoxCoffee.TabIndex = 2;
            this.textBoxCoffee.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Coffee Bags";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Large";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Medium";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Small";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Your total cost is";
            // 
            // labelBags
            // 
            this.labelBags.AutoSize = true;
            this.labelBags.Location = new System.Drawing.Point(217, 115);
            this.labelBags.Name = "labelBags";
            this.labelBags.Size = new System.Drawing.Size(12, 13);
            this.labelBags.TabIndex = 8;
            this.labelBags.Text = "/";
            // 
            // labelLarge
            // 
            this.labelLarge.AutoSize = true;
            this.labelLarge.Location = new System.Drawing.Point(217, 139);
            this.labelLarge.Name = "labelLarge";
            this.labelLarge.Size = new System.Drawing.Size(12, 13);
            this.labelLarge.TabIndex = 9;
            this.labelLarge.Text = "/";
            // 
            // labelMedium
            // 
            this.labelMedium.AutoSize = true;
            this.labelMedium.Location = new System.Drawing.Point(217, 162);
            this.labelMedium.Name = "labelMedium";
            this.labelMedium.Size = new System.Drawing.Size(12, 13);
            this.labelMedium.TabIndex = 10;
            this.labelMedium.Text = "/";
            // 
            // labelSmall
            // 
            this.labelSmall.AutoSize = true;
            this.labelSmall.Location = new System.Drawing.Point(217, 192);
            this.labelSmall.Name = "labelSmall";
            this.labelSmall.Size = new System.Drawing.Size(12, 13);
            this.labelSmall.TabIndex = 11;
            this.labelSmall.Text = "/";
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Location = new System.Drawing.Point(217, 216);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(12, 13);
            this.labelTotalCost.TabIndex = 12;
            this.labelTotalCost.Text = "/";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(161, 77);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(68, 23);
            this.buttonCalculate.TabIndex = 13;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click_1);
            // 
            // coffeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 266);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.labelSmall);
            this.Controls.Add(this.labelMedium);
            this.Controls.Add(this.labelLarge);
            this.Controls.Add(this.labelBags);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCoffee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCoffeeBag);
            this.MaximizeBox = false;
            this.Name = "coffeeForm";
            this.Text = "Coffee Bag Orders";
            this.Load += new System.EventHandler(this.coffeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCoffeeBag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCoffee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelBags;
        private System.Windows.Forms.Label labelLarge;
        private System.Windows.Forms.Label labelMedium;
        private System.Windows.Forms.Label labelSmall;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

