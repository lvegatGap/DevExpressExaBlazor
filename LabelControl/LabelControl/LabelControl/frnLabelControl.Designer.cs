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
            this.lblLabeControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lblLabeControl1
            // 
            this.lblLabeControl1.Location = new System.Drawing.Point(45, 73);
            this.lblLabeControl1.Name = "lblLabeControl1";
            this.lblLabeControl1.Size = new System.Drawing.Size(74, 13);
            this.lblLabeControl1.TabIndex = 0;
            this.lblLabeControl1.Text = "lblLabeControl1";
            // 
            // frnLabelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 191);
            this.Controls.Add(this.lblLabeControl1);
            this.Name = "frnLabelControl";
            this.Text = "frnLabelControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblLabeControl1;
    }
}

