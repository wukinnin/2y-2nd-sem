namespace WindowsFormsApp1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnGetValues = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetArray = new System.Windows.Forms.Button();
            this.btnViewArray = new System.Windows.Forms.Button();
            this.btnComputeMean = new System.Windows.Forms.Button();
            this.btnComputeMode = new System.Windows.Forms.Button();
            this.btnComputeMedian = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(15, 36);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(124, 20);
            this.txtInput.TabIndex = 0;
            // 
            // btnGetValues
            // 
            this.btnGetValues.Location = new System.Drawing.Point(165, 33);
            this.btnGetValues.Name = "btnGetValues";
            this.btnGetValues.Size = new System.Drawing.Size(75, 24);
            this.btnGetValues.TabIndex = 1;
            this.btnGetValues.Text = "Get Values";
            this.btnGetValues.UseVisualStyleBackColor = true;
            this.btnGetValues.Click += new System.EventHandler(this.getValuesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter an integer value of size 10";
            // 
            // btnResetArray
            // 
            this.btnResetArray.Location = new System.Drawing.Point(327, 33);
            this.btnResetArray.Name = "btnResetArray";
            this.btnResetArray.Size = new System.Drawing.Size(75, 23);
            this.btnResetArray.TabIndex = 4;
            this.btnResetArray.Text = "Reset Array";
            this.btnResetArray.UseVisualStyleBackColor = true;
            this.btnResetArray.Click += new System.EventHandler(this.btnResetArray_Click);
            // 
            // btnViewArray
            // 
            this.btnViewArray.Location = new System.Drawing.Point(246, 33);
            this.btnViewArray.Name = "btnViewArray";
            this.btnViewArray.Size = new System.Drawing.Size(75, 23);
            this.btnViewArray.TabIndex = 5;
            this.btnViewArray.Text = "View Array";
            this.btnViewArray.UseVisualStyleBackColor = true;
            this.btnViewArray.Click += new System.EventHandler(this.btnViewArray_Click);
            // 
            // btnComputeMean
            // 
            this.btnComputeMean.Location = new System.Drawing.Point(15, 84);
            this.btnComputeMean.Name = "btnComputeMean";
            this.btnComputeMean.Size = new System.Drawing.Size(124, 23);
            this.btnComputeMean.TabIndex = 6;
            this.btnComputeMean.Text = "Compute Mean";
            this.btnComputeMean.UseVisualStyleBackColor = true;
            this.btnComputeMean.Click += new System.EventHandler(this.btnComputeMean_Click);
            // 
            // btnComputeMode
            // 
            this.btnComputeMode.Location = new System.Drawing.Point(148, 84);
            this.btnComputeMode.Name = "btnComputeMode";
            this.btnComputeMode.Size = new System.Drawing.Size(124, 23);
            this.btnComputeMode.TabIndex = 7;
            this.btnComputeMode.Text = "Compute Mode";
            this.btnComputeMode.UseVisualStyleBackColor = true;
            this.btnComputeMode.Click += new System.EventHandler(this.btnComputeMode_Click);
            // 
            // btnComputeMedian
            // 
            this.btnComputeMedian.Location = new System.Drawing.Point(278, 84);
            this.btnComputeMedian.Name = "btnComputeMedian";
            this.btnComputeMedian.Size = new System.Drawing.Size(124, 23);
            this.btnComputeMedian.TabIndex = 8;
            this.btnComputeMedian.Text = "Compute Median";
            this.btnComputeMedian.UseVisualStyleBackColor = true;
            this.btnComputeMedian.Click += new System.EventHandler(this.btnComputeMedian_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 130);
            this.Controls.Add(this.btnComputeMedian);
            this.Controls.Add(this.btnComputeMode);
            this.Controls.Add(this.btnComputeMean);
            this.Controls.Add(this.btnViewArray);
            this.Controls.Add(this.btnResetArray);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetValues);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Mode, Mean, and Median";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnGetValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResetArray;
        private System.Windows.Forms.Button btnViewArray;
        private System.Windows.Forms.Button btnComputeMean;
        private System.Windows.Forms.Button btnComputeMode;
        private System.Windows.Forms.Button btnComputeMedian;
    }
}

