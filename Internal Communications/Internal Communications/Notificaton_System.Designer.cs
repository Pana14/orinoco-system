namespace Internal_Communications
{
    partial class Notificaton_System
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
            this.tabNotifications = new System.Windows.Forms.TabControl();
            this.tabpgNotifications = new System.Windows.Forms.TabPage();
            this.lstbxNotifications = new System.Windows.Forms.ListBox();
            this.txtNotificationDescription = new System.Windows.Forms.TextBox();
            this.btnClearNotificationDisplay = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tabpgEmails = new System.Windows.Forms.TabPage();
            this.lstbxEmails = new System.Windows.Forms.ListBox();
            this.btnReply = new System.Windows.Forms.Button();
            this.txtEmailDisplay = new System.Windows.Forms.TextBox();
            this.btnClearEmailDisplay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabNotifications.SuspendLayout();
            this.tabpgNotifications.SuspendLayout();
            this.tabpgEmails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNotifications
            // 
            this.tabNotifications.Controls.Add(this.tabpgNotifications);
            this.tabNotifications.Controls.Add(this.tabpgEmails);
            this.tabNotifications.Location = new System.Drawing.Point(9, 63);
            this.tabNotifications.Name = "tabNotifications";
            this.tabNotifications.SelectedIndex = 0;
            this.tabNotifications.Size = new System.Drawing.Size(548, 291);
            this.tabNotifications.TabIndex = 11;
            // 
            // tabpgNotifications
            // 
            this.tabpgNotifications.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabpgNotifications.Controls.Add(this.lstbxNotifications);
            this.tabpgNotifications.Controls.Add(this.txtNotificationDescription);
            this.tabpgNotifications.Controls.Add(this.btnClearNotificationDisplay);
            this.tabpgNotifications.Controls.Add(this.btnNew);
            this.tabpgNotifications.Location = new System.Drawing.Point(4, 22);
            this.tabpgNotifications.Name = "tabpgNotifications";
            this.tabpgNotifications.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgNotifications.Size = new System.Drawing.Size(540, 265);
            this.tabpgNotifications.TabIndex = 0;
            this.tabpgNotifications.Text = "Notifications";
            // 
            // lstbxNotifications
            // 
            this.lstbxNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstbxNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxNotifications.FormattingEnabled = true;
            this.lstbxNotifications.ItemHeight = 20;
            this.lstbxNotifications.Location = new System.Drawing.Point(6, 6);
            this.lstbxNotifications.Name = "lstbxNotifications";
            this.lstbxNotifications.Size = new System.Drawing.Size(518, 24);
            this.lstbxNotifications.TabIndex = 1;
            // 
            // txtNotificationDescription
            // 
            this.txtNotificationDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNotificationDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotificationDescription.Location = new System.Drawing.Point(6, 36);
            this.txtNotificationDescription.Multiline = true;
            this.txtNotificationDescription.Name = "txtNotificationDescription";
            this.txtNotificationDescription.Size = new System.Drawing.Size(349, 198);
            this.txtNotificationDescription.TabIndex = 2;
            // 
            // btnClearNotificationDisplay
            // 
            this.btnClearNotificationDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnClearNotificationDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearNotificationDisplay.Location = new System.Drawing.Point(361, 139);
            this.btnClearNotificationDisplay.Name = "btnClearNotificationDisplay";
            this.btnClearNotificationDisplay.Size = new System.Drawing.Size(163, 97);
            this.btnClearNotificationDisplay.TabIndex = 4;
            this.btnClearNotificationDisplay.Text = "Clear";
            this.btnClearNotificationDisplay.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(361, 36);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(163, 97);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New Notification";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // tabpgEmails
            // 
            this.tabpgEmails.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabpgEmails.Controls.Add(this.lstbxEmails);
            this.tabpgEmails.Controls.Add(this.btnReply);
            this.tabpgEmails.Controls.Add(this.txtEmailDisplay);
            this.tabpgEmails.Controls.Add(this.btnClearEmailDisplay);
            this.tabpgEmails.Location = new System.Drawing.Point(4, 22);
            this.tabpgEmails.Name = "tabpgEmails";
            this.tabpgEmails.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgEmails.Size = new System.Drawing.Size(540, 265);
            this.tabpgEmails.TabIndex = 1;
            this.tabpgEmails.Text = "Emails";
            // 
            // lstbxEmails
            // 
            this.lstbxEmails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstbxEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxEmails.FormattingEnabled = true;
            this.lstbxEmails.ItemHeight = 20;
            this.lstbxEmails.Location = new System.Drawing.Point(6, 6);
            this.lstbxEmails.Name = "lstbxEmails";
            this.lstbxEmails.Size = new System.Drawing.Size(518, 24);
            this.lstbxEmails.TabIndex = 8;
            // 
            // btnReply
            // 
            this.btnReply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnReply.Enabled = false;
            this.btnReply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReply.Location = new System.Drawing.Point(361, 36);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(163, 94);
            this.btnReply.TabIndex = 12;
            this.btnReply.Text = "Reply";
            this.btnReply.UseVisualStyleBackColor = false;
            // 
            // txtEmailDisplay
            // 
            this.txtEmailDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmailDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailDisplay.Location = new System.Drawing.Point(6, 36);
            this.txtEmailDisplay.Multiline = true;
            this.txtEmailDisplay.Name = "txtEmailDisplay";
            this.txtEmailDisplay.Size = new System.Drawing.Size(349, 198);
            this.txtEmailDisplay.TabIndex = 9;
            // 
            // btnClearEmailDisplay
            // 
            this.btnClearEmailDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnClearEmailDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEmailDisplay.Location = new System.Drawing.Point(361, 140);
            this.btnClearEmailDisplay.Name = "btnClearEmailDisplay";
            this.btnClearEmailDisplay.Size = new System.Drawing.Size(163, 94);
            this.btnClearEmailDisplay.TabIndex = 10;
            this.btnClearEmailDisplay.Text = "Clear";
            this.btnClearEmailDisplay.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(9, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 39);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(73, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 31);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Notifications";
            // 
            // Notificaton_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 373);
            this.Controls.Add(this.tabNotifications);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Name = "Notificaton_System";
            this.Text = "Notificaton_System";
            this.tabNotifications.ResumeLayout(false);
            this.tabpgNotifications.ResumeLayout(false);
            this.tabpgNotifications.PerformLayout();
            this.tabpgEmails.ResumeLayout(false);
            this.tabpgEmails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabNotifications;
        private System.Windows.Forms.TabPage tabpgNotifications;
        private System.Windows.Forms.ListBox lstbxNotifications;
        private System.Windows.Forms.TextBox txtNotificationDescription;
        private System.Windows.Forms.Button btnClearNotificationDisplay;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TabPage tabpgEmails;
        private System.Windows.Forms.ListBox lstbxEmails;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.TextBox txtEmailDisplay;
        private System.Windows.Forms.Button btnClearEmailDisplay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
    }
}