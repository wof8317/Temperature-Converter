
namespace Celsius_Fahrenheit_Converter
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
            this.btnCtoF = new System.Windows.Forms.Button();
            this.btnFtoC = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtConverted = new System.Windows.Forms.TextBox();
            this.lblConverted = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCtoF
            // 
            this.btnCtoF.Location = new System.Drawing.Point(167, 271);
            this.btnCtoF.Name = "btnCtoF";
            this.btnCtoF.Size = new System.Drawing.Size(96, 55);
            this.btnCtoF.TabIndex = 0;
            this.btnCtoF.Text = "Convert to Fahrenheit";
            this.btnCtoF.UseVisualStyleBackColor = true;
            this.btnCtoF.Click += new System.EventHandler(this.btnCtoF_Click);
            // 
            // btnFtoC
            // 
            this.btnFtoC.Location = new System.Drawing.Point(530, 271);
            this.btnFtoC.Name = "btnFtoC";
            this.btnFtoC.Size = new System.Drawing.Size(96, 55);
            this.btnFtoC.TabIndex = 1;
            this.btnFtoC.Text = "Convert to Celsius";
            this.btnFtoC.UseVisualStyleBackColor = true;
            this.btnFtoC.Click += new System.EventHandler(this.btnFtoC_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(342, 271);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 55);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(228, 190);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(107, 13);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "Enter a Temperature:";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(365, 190);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(100, 20);
            this.txtTemperature.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Celsius_Fahrenheit_Converter.Properties.Resources.celsiustofahrenheit;
            this.pictureBox1.Location = new System.Drawing.Point(231, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtConverted
            // 
            this.txtConverted.Enabled = false;
            this.txtConverted.Location = new System.Drawing.Point(365, 216);
            this.txtConverted.Name = "txtConverted";
            this.txtConverted.Size = new System.Drawing.Size(100, 20);
            this.txtConverted.TabIndex = 6;
            // 
            // lblConverted
            // 
            this.lblConverted.AutoSize = true;
            this.lblConverted.Location = new System.Drawing.Point(228, 216);
            this.lblConverted.Name = "lblConverted";
            this.lblConverted.Size = new System.Drawing.Size(122, 13);
            this.lblConverted.TabIndex = 7;
            this.lblConverted.Text = "Converted Temperature:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConverted);
            this.Controls.Add(this.txtConverted);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFtoC);
            this.Controls.Add(this.btnCtoF);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Celsius and Fahrenheit Temperature Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCtoF;
        private System.Windows.Forms.Button btnFtoC;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtConverted;
        private System.Windows.Forms.Label lblConverted;
    }
}

