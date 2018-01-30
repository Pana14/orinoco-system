namespace Internal_Communications
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
            this.btnNotificationSystem = new System.Windows.Forms.Button();
            this.btnInstandMessaging = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnAdditionalFunction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNotificationSystem
            // 
            this.btnNotificationSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnNotificationSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificationSystem.Location = new System.Drawing.Point(12, 12);
            this.btnNotificationSystem.Name = "btnNotificationSystem";
            this.btnNotificationSystem.Size = new System.Drawing.Size(252, 150);
            this.btnNotificationSystem.TabIndex = 13;
            this.btnNotificationSystem.Text = "Notification System";
            this.btnNotificationSystem.UseVisualStyleBackColor = false;
            this.btnNotificationSystem.Click += new System.EventHandler(this.btnNotificationSystem_Click);
            // 
            // btnInstandMessaging
            // 
            this.btnInstandMessaging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnInstandMessaging.Enabled = false;
            this.btnInstandMessaging.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstandMessaging.Location = new System.Drawing.Point(12, 229);
            this.btnInstandMessaging.Name = "btnInstandMessaging";
            this.btnInstandMessaging.Size = new System.Drawing.Size(252, 150);
            this.btnInstandMessaging.TabIndex = 14;
            this.btnInstandMessaging.Text = "INSTANT Messaging";
            this.btnInstandMessaging.UseVisualStyleBackColor = false;
            this.btnInstandMessaging.Click += new System.EventHandler(this.btnInstandMessaging_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.Location = new System.Drawing.Point(314, 12);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(252, 150);
            this.btnEmail.TabIndex = 15;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = false;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnAdditionalFunction
            // 
            this.btnAdditionalFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnAdditionalFunction.Enabled = false;
            this.btnAdditionalFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdditionalFunction.Location = new System.Drawing.Point(314, 229);
            this.btnAdditionalFunction.Name = "btnAdditionalFunction";
            this.btnAdditionalFunction.Size = new System.Drawing.Size(252, 150);
            this.btnAdditionalFunction.TabIndex = 16;
            this.btnAdditionalFunction.Text = "Additional Functionality";
            this.btnAdditionalFunction.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 391);
            this.Controls.Add(this.btnAdditionalFunction);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnInstandMessaging);
            this.Controls.Add(this.btnNotificationSystem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNotificationSystem;
        private System.Windows.Forms.Button btnInstandMessaging;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnAdditionalFunction;
    }
}

