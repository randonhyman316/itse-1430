﻿/*****************
 * Austin Lynes
 * ITSE 1430
 * 11/10/2017
 * 
 * **************/

namespace ContactManager.UI
{
    partial class MessageForm
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
            this._txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtSubject = new System.Windows.Forms.TextBox();
            this._btnSend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._txtMessage = new System.Windows.Forms.TextBox();
            this._btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // _txtName
            // 
            this._txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtName.Location = new System.Drawing.Point(63, 12);
            this._txtName.Name = "_txtName";
            this._txtName.ReadOnly = true;
            this._txtName.Size = new System.Drawing.Size(246, 20);
            this._txtName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // _txtEmailAddress
            // 
            this._txtEmailAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtEmailAddress.Location = new System.Drawing.Point(63, 42);
            this._txtEmailAddress.Name = "_txtEmailAddress";
            this._txtEmailAddress.ReadOnly = true;
            this._txtEmailAddress.Size = new System.Drawing.Size(246, 20);
            this._txtEmailAddress.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject";
            // 
            // _txtSubject
            // 
            this._txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtSubject.Location = new System.Drawing.Point(63, 70);
            this._txtSubject.Multiline = true;
            this._txtSubject.Name = "_txtSubject";
            this._txtSubject.Size = new System.Drawing.Size(245, 22);
            this._txtSubject.TabIndex = 2;
            // 
            // _btnSend
            // 
            this._btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSend.Location = new System.Drawing.Point(167, 273);
            this._btnSend.Name = "_btnSend";
            this._btnSend.Size = new System.Drawing.Size(74, 26);
            this._btnSend.TabIndex = 4;
            this._btnSend.Text = "Send";
            this._btnSend.UseVisualStyleBackColor = true;
            this._btnSend.Click += new System.EventHandler(this.OnButtonSend);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message";
            // 
            // _txtMessage
            // 
            this._txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtMessage.Location = new System.Drawing.Point(63, 98);
            this._txtMessage.Multiline = true;
            this._txtMessage.Name = "_txtMessage";
            this._txtMessage.Size = new System.Drawing.Size(245, 133);
            this._txtMessage.TabIndex = 3;
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.Location = new System.Drawing.Point(247, 273);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 26);
            this._btnCancel.TabIndex = 5;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._txtMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._btnSend);
            this.Controls.Add(this._txtSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtEmailAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(175, 250);
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Message";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtEmailAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtSubject;
        private System.Windows.Forms.Button _btnSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtMessage;
        private System.Windows.Forms.Button _btnCancel;
    }
}