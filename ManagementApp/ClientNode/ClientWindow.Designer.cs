﻿namespace ClientWindow
{
    partial class ClientWindow
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
            this.logPanel = new System.Windows.Forms.Panel();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.logLbl = new System.Windows.Forms.Label();
            this.receivedTextBox = new System.Windows.Forms.TextBox();
            this.receivedLbl = new System.Windows.Forms.Label();
            this.sendingGroupBox = new System.Windows.Forms.GroupBox();
            this.sendParamsGroupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.slotTextBox = new System.Windows.Forms.TextBox();
            this.nodeTextBox = new System.Windows.Forms.TextBox();
            this.slotLbl = new System.Windows.Forms.Label();
            this.nodeLbl = new System.Windows.Forms.Label();
            this.stopSendingBtn = new System.Windows.Forms.Button();
            this.sendingTextBox = new System.Windows.Forms.TextBox();
            this.sendComboBox = new System.Windows.Forms.ComboBox();
            this.sendPeriodicallyBtn = new System.Windows.Forms.Button();
            this.timeLbl = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.portLbl = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.logPanel.SuspendLayout();
            this.sendingGroupBox.SuspendLayout();
            this.sendParamsGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logPanel
            // 
            this.logPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logPanel.Controls.Add(this.logTextBox);
            this.logPanel.Controls.Add(this.logLbl);
            this.logPanel.Controls.Add(this.receivedTextBox);
            this.logPanel.Controls.Add(this.receivedLbl);
            this.logPanel.ForeColor = System.Drawing.Color.Red;
            this.logPanel.Location = new System.Drawing.Point(582, 13);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(335, 219);
            this.logPanel.TabIndex = 1;
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logTextBox.ForeColor = System.Drawing.Color.White;
            this.logTextBox.Location = new System.Drawing.Point(20, 124);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(301, 84);
            this.logTextBox.TabIndex = 3;
            // 
            // logLbl
            // 
            this.logLbl.AutoSize = true;
            this.logLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.logLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.logLbl.Location = new System.Drawing.Point(13, 101);
            this.logLbl.Name = "logLbl";
            this.logLbl.Size = new System.Drawing.Size(32, 17);
            this.logLbl.TabIndex = 2;
            this.logLbl.Text = "Log";
            // 
            // receivedTextBox
            // 
            this.receivedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.receivedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receivedTextBox.ForeColor = System.Drawing.Color.White;
            this.receivedTextBox.Location = new System.Drawing.Point(20, 30);
            this.receivedTextBox.Multiline = true;
            this.receivedTextBox.Name = "receivedTextBox";
            this.receivedTextBox.ReadOnly = true;
            this.receivedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receivedTextBox.Size = new System.Drawing.Size(301, 61);
            this.receivedTextBox.TabIndex = 1;
            // 
            // receivedLbl
            // 
            this.receivedLbl.AutoSize = true;
            this.receivedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.receivedLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.receivedLbl.Location = new System.Drawing.Point(13, 10);
            this.receivedLbl.Name = "receivedLbl";
            this.receivedLbl.Size = new System.Drawing.Size(135, 17);
            this.receivedLbl.TabIndex = 0;
            this.receivedLbl.Text = "Received messages";
            // 
            // sendingGroupBox
            // 
            this.sendingGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sendingGroupBox.Controls.Add(this.sendParamsGroupBox1);
            this.sendingGroupBox.Controls.Add(this.stopSendingBtn);
            this.sendingGroupBox.Controls.Add(this.sendingTextBox);
            this.sendingGroupBox.Controls.Add(this.sendComboBox);
            this.sendingGroupBox.Controls.Add(this.sendPeriodicallyBtn);
            this.sendingGroupBox.Controls.Add(this.timeLbl);
            this.sendingGroupBox.Controls.Add(this.sendBtn);
            this.sendingGroupBox.Controls.Add(this.timeTextBox);
            this.sendingGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.sendingGroupBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.sendingGroupBox.Location = new System.Drawing.Point(17, 13);
            this.sendingGroupBox.Name = "sendingGroupBox";
            this.sendingGroupBox.Size = new System.Drawing.Size(559, 219);
            this.sendingGroupBox.TabIndex = 7;
            this.sendingGroupBox.TabStop = false;
            this.sendingGroupBox.Text = "SENDING";
            // 
            // sendParamsGroupBox1
            // 
            this.sendParamsGroupBox1.Controls.Add(this.portTextBox);
            this.sendParamsGroupBox1.Controls.Add(this.portLbl);
            this.sendParamsGroupBox1.Controls.Add(this.addButton);
            this.sendParamsGroupBox1.Controls.Add(this.slotTextBox);
            this.sendParamsGroupBox1.Controls.Add(this.nodeTextBox);
            this.sendParamsGroupBox1.Controls.Add(this.slotLbl);
            this.sendParamsGroupBox1.Controls.Add(this.nodeLbl);
            this.sendParamsGroupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.sendParamsGroupBox1.Location = new System.Drawing.Point(173, 124);
            this.sendParamsGroupBox1.Name = "sendParamsGroupBox1";
            this.sendParamsGroupBox1.Size = new System.Drawing.Size(359, 54);
            this.sendParamsGroupBox1.TabIndex = 7;
            this.sendParamsGroupBox1.TabStop = false;
            this.sendParamsGroupBox1.Text = "SENDING PARAMETERS";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(265, 17);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(73, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // slotTextBox
            // 
            this.slotTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.slotTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slotTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.slotTextBox.Location = new System.Drawing.Point(129, 18);
            this.slotTextBox.Name = "slotTextBox";
            this.slotTextBox.Size = new System.Drawing.Size(28, 20);
            this.slotTextBox.TabIndex = 3;
            // 
            // nodeTextBox
            // 
            this.nodeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nodeTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.nodeTextBox.Location = new System.Drawing.Point(49, 17);
            this.nodeTextBox.Name = "nodeTextBox";
            this.nodeTextBox.Size = new System.Drawing.Size(40, 20);
            this.nodeTextBox.TabIndex = 2;
            // 
            // slotLbl
            // 
            this.slotLbl.AutoSize = true;
            this.slotLbl.Location = new System.Drawing.Point(95, 22);
            this.slotLbl.Name = "slotLbl";
            this.slotLbl.Size = new System.Drawing.Size(28, 13);
            this.slotLbl.TabIndex = 1;
            this.slotLbl.Text = "Slot:";
            // 
            // nodeLbl
            // 
            this.nodeLbl.AutoSize = true;
            this.nodeLbl.Location = new System.Drawing.Point(7, 20);
            this.nodeLbl.Name = "nodeLbl";
            this.nodeLbl.Size = new System.Drawing.Size(36, 13);
            this.nodeLbl.TabIndex = 0;
            this.nodeLbl.Text = "Node:";
            // 
            // stopSendingBtn
            // 
            this.stopSendingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.stopSendingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopSendingBtn.Location = new System.Drawing.Point(367, 184);
            this.stopSendingBtn.Name = "stopSendingBtn";
            this.stopSendingBtn.Size = new System.Drawing.Size(125, 24);
            this.stopSendingBtn.TabIndex = 6;
            this.stopSendingBtn.Text = "Stop sending";
            this.stopSendingBtn.UseVisualStyleBackColor = false;
            this.stopSendingBtn.Click += new System.EventHandler(this.stopSendingBtn_Click);
            // 
            // sendingTextBox
            // 
            this.sendingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendingTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.sendingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendingTextBox.ForeColor = System.Drawing.Color.White;
            this.sendingTextBox.Location = new System.Drawing.Point(16, 35);
            this.sendingTextBox.Multiline = true;
            this.sendingTextBox.Name = "sendingTextBox";
            this.sendingTextBox.Size = new System.Drawing.Size(516, 83);
            this.sendingTextBox.TabIndex = 0;
            // 
            // sendComboBox
            // 
            this.sendComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.sendComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendComboBox.ForeColor = System.Drawing.Color.White;
            this.sendComboBox.FormattingEnabled = true;
            this.sendComboBox.Location = new System.Drawing.Point(18, 124);
            this.sendComboBox.Name = "sendComboBox";
            this.sendComboBox.Size = new System.Drawing.Size(125, 21);
            this.sendComboBox.TabIndex = 3;
            this.sendComboBox.SelectedIndexChanged += new System.EventHandler(this.sendComboBox_SelectedIndexChanged);
            // 
            // sendPeriodicallyBtn
            // 
            this.sendPeriodicallyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.sendPeriodicallyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendPeriodicallyBtn.Location = new System.Drawing.Point(18, 184);
            this.sendPeriodicallyBtn.Name = "sendPeriodicallyBtn";
            this.sendPeriodicallyBtn.Size = new System.Drawing.Size(125, 24);
            this.sendPeriodicallyBtn.TabIndex = 2;
            this.sendPeriodicallyBtn.Text = "Send periodically";
            this.sendPeriodicallyBtn.UseVisualStyleBackColor = false;
            this.sendPeriodicallyBtn.Click += new System.EventHandler(this.sendPeriodicallyBtn_Click);
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.timeLbl.Location = new System.Drawing.Point(170, 188);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(68, 17);
            this.timeLbl.TabIndex = 5;
            this.timeLbl.Text = "time [ms]:";
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Location = new System.Drawing.Point(18, 151);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(125, 24);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.timeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeTextBox.ForeColor = System.Drawing.Color.White;
            this.timeTextBox.Location = new System.Drawing.Point(238, 187);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(92, 20);
            this.timeTextBox.TabIndex = 4;
            this.timeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // portLbl
            // 
            this.portLbl.AutoSize = true;
            this.portLbl.Location = new System.Drawing.Point(164, 20);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(29, 13);
            this.portLbl.TabIndex = 5;
            this.portLbl.Text = "Port:";
            // 
            // portTextBox
            // 
            this.portTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.portTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.portTextBox.Location = new System.Drawing.Point(199, 17);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(45, 20);
            this.portTextBox.TabIndex = 6;
            // 
            // ClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(934, 242);
            this.Controls.Add(this.sendingGroupBox);
            this.Controls.Add(this.logPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientWindow";
            this.Text = "ClientWindow";
            this.logPanel.ResumeLayout(false);
            this.logPanel.PerformLayout();
            this.sendingGroupBox.ResumeLayout(false);
            this.sendingGroupBox.PerformLayout();
            this.sendParamsGroupBox1.ResumeLayout(false);
            this.sendParamsGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion
        private System.Windows.Forms.Panel logPanel;
        private System.Windows.Forms.Label receivedLbl;
        private System.Windows.Forms.Label logLbl;
        private System.Windows.Forms.TextBox receivedTextBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.GroupBox sendingGroupBox;
        private System.Windows.Forms.TextBox sendingTextBox;
        private System.Windows.Forms.ComboBox sendComboBox;
        private System.Windows.Forms.Button sendPeriodicallyBtn;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Button stopSendingBtn;
        private System.Windows.Forms.GroupBox sendParamsGroupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox slotTextBox;
        private System.Windows.Forms.TextBox nodeTextBox;
        private System.Windows.Forms.Label slotLbl;
        private System.Windows.Forms.Label nodeLbl;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label portLbl;
    }
}