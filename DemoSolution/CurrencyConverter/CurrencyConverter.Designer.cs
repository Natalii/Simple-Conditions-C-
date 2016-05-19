namespace CurrencyConverter
{
    partial class CurrencyConverter
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
            this.labelConvert = new System.Windows.Forms.Label();
            this.labelBGNtoEUR = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConvert
            // 
            this.labelConvert.AutoSize = true;
            this.labelConvert.Location = new System.Drawing.Point(36, 51);
            this.labelConvert.Name = "labelConvert";
            this.labelConvert.Size = new System.Drawing.Size(44, 13);
            this.labelConvert.TabIndex = 0;
            this.labelConvert.Text = "Convert";
            // 
            // labelBGNtoEUR
            // 
            this.labelBGNtoEUR.AutoSize = true;
            this.labelBGNtoEUR.Location = new System.Drawing.Point(329, 51);
            this.labelBGNtoEUR.Name = "labelBGNtoEUR";
            this.labelBGNtoEUR.Size = new System.Drawing.Size(66, 13);
            this.labelBGNtoEUR.TabIndex = 1;
            this.labelBGNtoEUR.Text = "BNGToEUR";
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelResult.Location = new System.Drawing.Point(81, 106);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(258, 23);
            this.labelResult.TabIndex = 2;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(141, 44);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyUp);
            // 
            // CurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 163);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelBGNtoEUR);
            this.Controls.Add(this.labelConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CurrencyConverter";
            this.Text = "CurrencyConverter";
            this.Load += new System.EventHandler(this.CurrencyConverter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConvert;
        private System.Windows.Forms.Label labelBGNtoEUR;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

