using Mobilize.Web.Extensions;

namespace TestingDemos
{

   partial class frmLinkLabelTest
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private Gap.Blazor.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if ( disposing && (components != null) )
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

#region Windows Form Designer generated code
      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         lnkLabelEvent = new Gap.Blazor.DevE.LabelControl();
         btnAddLinks = new Gap.Blazor.Button();
         lnkLabelNeverUnderline = new Gap.Blazor.LinkLabel();
         lnkGreenColor = new Gap.Blazor.LinkLabel();
         lnkHoverUnderline = new Gap.Blazor.LinkLabel();
         lnkRedColor = new Gap.Blazor.LinkLabel();
         SuspendLayout();
         // 
         // lnkLabelEvent
         // 
         lnkLabelEvent.AutoSize = true;
         lnkLabelEvent.ForeColor = Gap.Blazor.SystemColors.WindowText;         
         lnkLabelEvent.Location = new Point(58, 45);
         lnkLabelEvent.Name = "lnkLabelEvent";
         lnkLabelEvent.RightToLeft = Gap.Blazor.RightToLeft.No;
         lnkLabelEvent.Size = new Size(127, 15);
         lnkLabelEvent.TabIndex = 0;
         lnkLabelEvent.TabStop = true;
         lnkLabelEvent.Text = "Nacion Google NoLink";
         
         // 
         // btnAddLinks
         // 
         btnAddLinks.Location = new Point(216, 45);
         btnAddLinks.Name = "btnAddLinks";
         btnAddLinks.Size = new Size(75, 23);
         btnAddLinks.TabIndex = 1;
         btnAddLinks.Text = "Add Links";
         btnAddLinks.UseVisualStyleBackColor = true;
         btnAddLinks.Click += button1_Click;
         // 
         // lnkLabelNeverUnderline
         // 
         lnkLabelNeverUnderline.AutoSize = true;
         lnkLabelNeverUnderline.LinkBehavior = Gap.Blazor.LinkBehavior.NeverUnderline;
         lnkLabelNeverUnderline.Location = new Point(58, 77);
         lnkLabelNeverUnderline.Name = "lnkLabelNeverUnderline";
         lnkLabelNeverUnderline.Size = new Size(148, 15);
         lnkLabelNeverUnderline.TabIndex = 2;
         lnkLabelNeverUnderline.TabStop = true;
         lnkLabelNeverUnderline.Text = "Link Label Never Underline";
         // 
         // lnkGreenColor
         // 
         lnkGreenColor.AutoSize = true;
         lnkGreenColor.LinkColor = Color.FromArgb(0, 192, 0);
         lnkGreenColor.Location = new Point(58, 105);
         lnkGreenColor.Name = "lnkGreenColor";
         lnkGreenColor.Size = new Size(119, 15);
         lnkGreenColor.TabIndex = 3;
         lnkGreenColor.TabStop = true;
         lnkGreenColor.Text = "Link Label Gree Color";
         lnkGreenColor.VisitedLinkColor = Color.FromArgb(128, 255, 255);
         // 
         // lnkHoverUnderline
         // 
         lnkHoverUnderline.AutoSize = true;
         lnkHoverUnderline.LinkBehavior = Gap.Blazor.LinkBehavior.HoverUnderline;
         lnkHoverUnderline.Location = new Point(58, 138);
         lnkHoverUnderline.Name = "lnkHoverUnderline";
         lnkHoverUnderline.Size = new Size(149, 15);
         lnkHoverUnderline.TabIndex = 4;
         lnkHoverUnderline.TabStop = true;
         lnkHoverUnderline.Text = "Link Label Hover Underline";
         // 
         // lnkRedColor
         // 
         lnkRedColor.AutoSize = true;
         lnkRedColor.LinkColor = Color.Red;
         lnkRedColor.Location = new Point(58, 171);
         lnkRedColor.Name = "lnkRedColor";
         lnkRedColor.Size = new Size(83, 15);
         lnkRedColor.TabIndex = 5;
         lnkRedColor.TabStop = true;
         lnkRedColor.Text = "Link Label Red";
         this.Properties().
         // 
         // frmLinkLabel
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new Size(526, 307);
         Controls.Add(lnkRedColor);
         Controls.Add(lnkHoverUnderline);
         Controls.Add(lnkGreenColor);
         Controls.Add(lnkLabelNeverUnderline);
         Controls.Add(btnAddLinks);
         Controls.Add(lnkLabelEvent);
         Name = "frmLinkLabel";
         Text = "frmLinkLabel";
         Load += Form1_Load;
         ResumeLayout(false);
         PerformLayout();
      }
        #endregion

      public Gap.Blazor.DevE.LabelControl lnkLabelEvent { get; set; }

      public Gap.Blazor.Button btnAddLinks { get; set; }

      public Gap.Blazor.LinkLabel lnkLabelNeverUnderline { get; set; }

      public Gap.Blazor.LinkLabel lnkGreenColor { get; set; }

      public Gap.Blazor.LinkLabel lnkHoverUnderline { get; set; }

      public Gap.Blazor.LinkLabel lnkRedColor { get; set; }

   }

}