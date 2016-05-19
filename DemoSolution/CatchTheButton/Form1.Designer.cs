namespace CatchTheButton
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
            this.CatchMe_Mouse_Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CatchMe_Mouse_Enter
            // 
            this.CatchMe_Mouse_Enter.Font = new System.Drawing.Font("News701 BT", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatchMe_Mouse_Enter.Location = new System.Drawing.Point(56, 39);
            this.CatchMe_Mouse_Enter.Name = "CatchMe_Mouse_Enter";
            this.CatchMe_Mouse_Enter.Size = new System.Drawing.Size(112, 59);
            this.CatchMe_Mouse_Enter.TabIndex = 0;
            this.CatchMe_Mouse_Enter.Text = "Catch me!";
            this.CatchMe_Mouse_Enter.UseVisualStyleBackColor = true;
            this.CatchMe_Mouse_Enter.Click += new System.EventHandler(this.CatchMe_Mouse_Enter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CatchMe_Mouse_Enter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CatchMe_Mouse_Enter;
    }
}

