namespace Bank
{
    partial class FormBalance
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
            this.buttonExitBalance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account balance $:";
            // 
            // buttonExitBalance
            // 
            this.buttonExitBalance.Location = new System.Drawing.Point(15, 68);
            this.buttonExitBalance.Name = "buttonExitBalance";
            this.buttonExitBalance.Size = new System.Drawing.Size(75, 23);
            this.buttonExitBalance.TabIndex = 1;
            this.buttonExitBalance.Text = "Exit";
            this.buttonExitBalance.UseVisualStyleBackColor = true;
            this.buttonExitBalance.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 415);
            this.Controls.Add(this.buttonExitBalance);
            this.Controls.Add(this.label1);
            this.Name = "FormBalance";
            this.Text = "Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExitBalance;
    }
}