using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelControl
{
    public partial class frnLabelControl : Form
    {
        public frnLabelControl()
        {
            InitializeComponent();
        }

        private void btnSuperTip_Click(object sender, EventArgs e)
        {
            lblControl6.SuperTip = new DevExpress.Utils.SuperToolTip() { Items = { lblControl6.Text } };
        }

        private void frnLabelControl_Load(object sender, EventArgs e)
        {
            var label = new DevExpress.XtraEditors.LabelControl
            {
                Font = new Font("Tahoma", 8),
                Text = "Created on Form Load, AutoSizeMode = Vertical",
                Left = 42,
                Top =175,
                Width = 120,
                Height = 5,
                Visible = true,
                Name = "lblControl7",
                AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            };
            this.Controls.Add(label);
        }
    }
}
