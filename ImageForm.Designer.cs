using System.Windows.Forms;

namespace Winforms_Example_11___Email_Message
{
    partial class ImageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        internal System.Windows.Forms.Button cmdOK;

        internal System.Windows.Forms.Button cmdCancel;

        internal System.Windows.Forms.GroupBox GroupBox2;

        internal System.Windows.Forms.Label lblBorder;

        internal System.Windows.Forms.Label lblAlign;

        internal System.Windows.Forms.TextBox txtBorder;

        internal System.Windows.Forms.ComboBox cboAlign;

        internal System.Windows.Forms.GroupBox GroupBox3;

        internal System.Windows.Forms.TextBox txtAltText;

        internal System.Windows.Forms.Label lblAltText;
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
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.cboAlign = new System.Windows.Forms.ComboBox();
            this.lblAlign = new System.Windows.Forms.Label();
            this.txtBorder = new System.Windows.Forms.TextBox();
            this.lblBorder = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.txtAltText = new System.Windows.Forms.TextBox();
            this.lblAltText = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdOK.Location = new System.Drawing.Point(423, 92);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(72, 24);
            this.cmdOK.TabIndex = 0;
            this.cmdOK.Text = "&OK";
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCancel.Location = new System.Drawing.Point(423, 124);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(72, 24);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.cboAlign);
            this.GroupBox2.Controls.Add(this.lblAlign);
            this.GroupBox2.Controls.Add(this.txtBorder);
            this.GroupBox2.Controls.Add(this.lblBorder);
            this.GroupBox2.Location = new System.Drawing.Point(354, -2);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(158, 88);
            this.GroupBox2.TabIndex = 3;
            this.GroupBox2.TabStop = false;
            // 
            // cboAlign
            // 
            this.cboAlign.Items.AddRange(new object[] {
            "absbottom",
            "absmiddle",
            "baseline",
            "bottom",
            "left",
            "middle",
            "right",
            "texttop",
            "top"});
            this.cboAlign.Location = new System.Drawing.Point(62, 53);
            this.cboAlign.Name = "cboAlign";
            this.cboAlign.Size = new System.Drawing.Size(80, 21);
            this.cboAlign.TabIndex = 9;
            // 
            // lblAlign
            // 
            this.lblAlign.Location = new System.Drawing.Point(14, 56);
            this.lblAlign.Name = "lblAlign";
            this.lblAlign.Size = new System.Drawing.Size(48, 24);
            this.lblAlign.TabIndex = 8;
            this.lblAlign.Text = "Align";
            // 
            // txtBorder
            // 
            this.txtBorder.Location = new System.Drawing.Point(61, 17);
            this.txtBorder.Name = "txtBorder";
            this.txtBorder.Size = new System.Drawing.Size(80, 20);
            this.txtBorder.TabIndex = 6;
            // 
            // lblBorder
            // 
            this.lblBorder.Location = new System.Drawing.Point(13, 20);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.Size = new System.Drawing.Size(48, 24);
            this.lblBorder.TabIndex = 7;
            this.lblBorder.Text = "Border";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.label1);
            this.GroupBox3.Controls.Add(this.lblW);
            this.GroupBox3.Controls.Add(this.txtHeight);
            this.GroupBox3.Controls.Add(this.txtWidth);
            this.GroupBox3.Controls.Add(this.cmdBrowse);
            this.GroupBox3.Controls.Add(this.txtSource);
            this.GroupBox3.Controls.Add(this.lblSource);
            this.GroupBox3.Controls.Add(this.txtAltText);
            this.GroupBox3.Controls.Add(this.lblAltText);
            this.GroupBox3.Location = new System.Drawing.Point(8, -2);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(340, 154);
            this.GroupBox3.TabIndex = 4;
            this.GroupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Height";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(10, 97);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(35, 13);
            this.lblW.TabIndex = 13;
            this.lblW.Text = "Width";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(54, 126);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(93, 20);
            this.txtHeight.TabIndex = 12;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(54, 94);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(93, 20);
            this.txtWidth.TabIndex = 11;
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdBrowse.Location = new System.Drawing.Point(259, 19);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(72, 24);
            this.cmdBrowse.TabIndex = 10;
            this.cmdBrowse.Text = "&Browse";
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click_1);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(54, 19);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(199, 20);
            this.txtSource.TabIndex = 8;
            // 
            // lblSource
            // 
            this.lblSource.Location = new System.Drawing.Point(10, 22);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(48, 16);
            this.lblSource.TabIndex = 9;
            this.lblSource.Text = "Source";
            // 
            // txtAltText
            // 
            this.txtAltText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAltText.Location = new System.Drawing.Point(54, 49);
            this.txtAltText.Multiline = true;
            this.txtAltText.Name = "txtAltText";
            this.txtAltText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAltText.Size = new System.Drawing.Size(277, 34);
            this.txtAltText.TabIndex = 0;
            // 
            // lblAltText
            // 
            this.lblAltText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAltText.Location = new System.Drawing.Point(12, 56);
            this.lblAltText.Name = "lblAltText";
            this.lblAltText.Size = new System.Drawing.Size(40, 56);
            this.lblAltText.TabIndex = 1;
            this.lblAltText.Text = "Alt. Text";
            // 
            // ImageForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(517, 157);
            this.ControlBox = false;
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "ImageForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image Properties";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Button cmdBrowse;
        internal TextBox txtSource;
        internal Label lblSource;
        private Label label1;
        private Label lblW;
        internal TextBox txtHeight;
        internal TextBox txtWidth;
    }
}