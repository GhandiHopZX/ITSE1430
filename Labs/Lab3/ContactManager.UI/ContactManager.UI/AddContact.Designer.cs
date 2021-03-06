﻿namespace ContactManager.UI
{
    partial class AddContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.components = new System.ComponentModel.Container();
            this.ContactSaveButton = new System.Windows.Forms.Button();
            this.ContactCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contact_namebox = new System.Windows.Forms.TextBox();
            this.contact_emailbox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // ContactSaveButton
            // 
            this.ContactSaveButton.Location = new System.Drawing.Point(162, 248);
            this.ContactSaveButton.Name = "ContactSaveButton";
            this.ContactSaveButton.Size = new System.Drawing.Size(75, 23);
            this.ContactSaveButton.TabIndex = 0;
            this.ContactSaveButton.Text = "Save";
            this.ContactSaveButton.UseVisualStyleBackColor = true;
            this.ContactSaveButton.Click += new System.EventHandler(this.OnSaveContact);
            // 
            // ContactCancelButton
            // 
            this.ContactCancelButton.Location = new System.Drawing.Point(255, 248);
            this.ContactCancelButton.Name = "ContactCancelButton";
            this.ContactCancelButton.Size = new System.Drawing.Size(75, 23);
            this.ContactCancelButton.TabIndex = 1;
            this.ContactCancelButton.Text = "Cancel";
            this.ContactCancelButton.UseVisualStyleBackColor = true;
            this.ContactCancelButton.Click += new System.EventHandler(this.ContactCancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contact Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // contact_namebox
            // 
            this.contact_namebox.Location = new System.Drawing.Point(35, 83);
            this.contact_namebox.Name = "contact_namebox";
            this.contact_namebox.Size = new System.Drawing.Size(295, 22);
            this.contact_namebox.TabIndex = 4;
            this.contact_namebox.Validating += new System.ComponentModel.CancelEventHandler(this.contact_namebox_Validating);
            // 
            // contact_emailbox
            // 
            this.contact_emailbox.Location = new System.Drawing.Point(35, 177);
            this.contact_emailbox.Name = "contact_emailbox";
            this.contact_emailbox.Size = new System.Drawing.Size(295, 22);
            this.contact_emailbox.TabIndex = 5;
            this.contact_emailbox.Validating += new System.ComponentModel.CancelEventHandler(this.contact_emailbox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(382, 333);
            this.Controls.Add(this.contact_emailbox);
            this.Controls.Add(this.contact_namebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContactCancelButton);
            this.Controls.Add(this.ContactSaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddContact";
            this.Text = "New Contact";
            this.Load += new System.EventHandler(this.AddContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ContactSaveButton;
        private System.Windows.Forms.Button ContactCancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contact_namebox;
        private System.Windows.Forms.TextBox contact_emailbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}