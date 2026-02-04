namespace LabelControl
{
    partial class frnLabelControl
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnLabelControl));
            DevExpress.Utils.ToolTipSeparatorItem toolTipSeparatorItem1 = new DevExpress.Utils.ToolTipSeparatorItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.lblControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnSuperTip = new System.Windows.Forms.Button();
            this.lblComplexSuperTip = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lblControl1
            // 
            this.lblControl1.AllowDrop = true;
            this.lblControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.lblControl1.Location = new System.Drawing.Point(42, 25);
            this.lblControl1.Name = "lblControl1";
            this.lblControl1.Size = new System.Drawing.Size(92, 17);
            this.lblControl1.TabIndex = 0;
            this.lblControl1.Text = "BorderStyle = Flat";
            // 
            // lblControl2
            // 
            this.lblControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblControl2.Location = new System.Drawing.Point(42, 55);
            this.lblControl2.Name = "lblControl2";
            this.lblControl2.Size = new System.Drawing.Size(101, 13);
            this.lblControl2.TabIndex = 1;
            this.lblControl2.Text = "Load from Resources";
            // 
            // lblControl3
            // 
            this.lblControl3.Appearance.Options.UseFont = true;
            this.lblControl3.Appearance.Options.UseForeColor = true;
            this.lblControl3.Appearance.Options.UseTextOptions = true;
            this.lblControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.lblControl3.Location = new System.Drawing.Point(42, 85);
            this.lblControl3.Name = "lblControl3";
            this.lblControl3.Size = new System.Drawing.Size(200, 20);
            this.lblControl3.TabIndex = 2;
            this.lblControl3.Text = "TextOptions.HAlignment = Center";
            // 
            // lblControl4
            // 
            this.lblControl4.AutoEllipsis = true;
            this.lblControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblControl4.Location = new System.Drawing.Point(42, 115);
            this.lblControl4.Name = "lblControl4";
            this.lblControl4.Size = new System.Drawing.Size(65, 13);
            this.lblControl4.TabIndex = 3;
            this.lblControl4.Text = "AutoEllipsis true";
            // 
            // lblControl5
            // 
            this.lblControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblControl5.Location = new System.Drawing.Point(42, 145);
            this.lblControl5.Name = "lblControl5";
            this.lblControl5.Size = new System.Drawing.Size(130, 13);
            this.lblControl5.TabIndex = 4;
            this.lblControl5.Text = "AutoSizeMode = Horizontal";
            // 
            // lblControl6
            // 
            this.lblControl6.Location = new System.Drawing.Point(42, 215);
            this.lblControl6.Name = "lblControl6";
            this.lblControl6.Size = new System.Drawing.Size(42, 13);
            this.lblControl6.TabIndex = 4;
            this.lblControl6.Text = "SuperTip";
            // 
            // btnSuperTip
            // 
            this.btnSuperTip.Location = new System.Drawing.Point(232, 210);
            this.btnSuperTip.Name = "btnSuperTip";
            this.btnSuperTip.Size = new System.Drawing.Size(103, 23);
            this.btnSuperTip.TabIndex = 5;
            this.btnSuperTip.Text = "Apply SuperTip";
            this.btnSuperTip.UseVisualStyleBackColor = true;
            this.btnSuperTip.Click += new System.EventHandler(this.btnSuperTip_Click);
            // 
            // lblComplexSuperTip
            // 
            this.lblComplexSuperTip.Location = new System.Drawing.Point(42, 245);
            this.lblComplexSuperTip.Name = "lblComplexSuperTip";
            this.lblComplexSuperTip.Size = new System.Drawing.Size(89, 13);
            toolTipTitleItem1.Text = "This is a title Item";
            toolTipItem1.Icon = ((System.Drawing.Icon)(resources.GetObject("toolTipItem1.Icon")));
            toolTipItem1.Text = "This is a Content Item.";
            toolTipItem2.Text = "This is another Content Item.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            superToolTip1.Items.Add(toolTipSeparatorItem1);
            superToolTip1.Items.Add(toolTipItem2);
            this.lblComplexSuperTip.SuperTip = superToolTip1;
            this.lblComplexSuperTip.TabIndex = 6;
            this.lblComplexSuperTip.Text = "Complex SuperTip ";
            // 
            // frnLabelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 354);
            this.Controls.Add(this.lblComplexSuperTip);
            this.Controls.Add(this.btnSuperTip);
            this.Controls.Add(this.lblControl6);
            this.Controls.Add(this.lblControl5);
            this.Controls.Add(this.lblControl4);
            this.Controls.Add(this.lblControl3);
            this.Controls.Add(this.lblControl2);
            this.Controls.Add(this.lblControl1);
            this.Name = "frnLabelControl";
            this.Text = "frnLabelControl";
            this.Load += new System.EventHandler(this.frnLabelControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblControl1;
        private DevExpress.XtraEditors.LabelControl lblControl2;
        private DevExpress.XtraEditors.LabelControl lblControl3;
        private DevExpress.XtraEditors.LabelControl lblControl4;
        private DevExpress.XtraEditors.LabelControl lblControl5;
        private DevExpress.XtraEditors.LabelControl lblControl6;
        private System.Windows.Forms.Button btnSuperTip;
        private DevExpress.XtraEditors.LabelControl lblComplexSuperTip;
    }
}

