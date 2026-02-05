using Mobilize.Web.Extensions;

namespace TestingDemos
{

   public partial class frmLinkLabelTest
      : Gap.Blazor.Form
   {

      public frmLinkLabelTest()
      {
         this.View = typeof(FrmLinkLabelTestView);
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
        
      }

      private void linkLabel1_LinkClicked(object sender, Gap.Blazor.LinkLabelLinkClickedEventArgs e)
      {
         var link = e.Link;
         if ( link != null )
         {
            // Marca el link como visitado para que cambie al VisitedLinkColor
            link.Visited = true;
            // Accede a las propiedades del link
            var url = link.LinkData as string; // "https://www.example.com"

            var startPosition = link.Start; // 0

            var length = link.Length; // 4

            var mouseButton = e.Button; // MouseButtons.Left, Right, etc.

            // Ejemplo: Navegar a la URL
            if ( !string.IsNullOrEmpty(url) )
            {
               MessageBox.Show($"URL: {url}");
            }
         }
      }

      private void Form1_Load(object sender, EventArgs e)
      {
      }

   }

}