namespace Internal_Communications
{
    partial class Email_Options
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
            this.chkDeliver = new System.Windows.Forms.CheckBox();
            this.lblOptions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkDeliver
            // 
            this.chkDeliver.AutoSize = true;
            this.chkDeliver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.chkDeliver.Font = new System.Drawing.Font("Arial", 11.25F);
            this.chkDeliver.Location = new System.Drawing.Point(42, 124);
            this.chkDeliver.Name = "chkDeliver";
            this.chkDeliver.Size = new System.Drawing.Size(142, 21);
            this.chkDeliver.TabIndex = 3;
            this.chkDeliver.Text = "Deliver E-mail at :";
            this.chkDeliver.UseVisualStyleBackColor = false;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblOptions.Font = new System.Drawing.Font("Arial", 27.75F);
            this.lblOptions.Location = new System.Drawing.Point(35, 34);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(145, 42);
            this.lblOptions.TabIndex = 2;
            this.lblOptions.Text = "Options";
            // 
            // Email_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 447);
            this.Controls.Add(this.chkDeliver);
            this.Controls.Add(this.lblOptions);
            this.Name = "Email_Options";
            this.Text = "Email_Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDeliver;
        private System.Windows.Forms.Label lblOptions;
    }
}