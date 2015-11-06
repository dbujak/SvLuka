using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Globalization;
using System.Resources;

namespace SvLuka.Folklor
{
	/// <summary>
	/// Summary description for _default.
	/// </summary>
	public partial class _default : System.Web.UI.Page
	{
		protected SvLuka.controls.Header Header1;

		protected void Page_Load(object sender, System.EventArgs e)
		{
			

            this.Header1.lblPageTitle.Text = HttpContext.GetGlobalResourceObject("Strings", "94_folklorepage_title").ToString();
            this.lblFolklore.Text = HttpContext.GetGlobalResourceObject("Strings", "95_folklorepage_text").ToString();

            string lang = "";

            if (Request.Cookies["language"] != null) { lang = Request.Cookies["language"].Value; }

            // set up google group embeded part
            this.googleGroup.Text = @"<iframe id='forum_embed' src='javascript:void(0)' scrolling='no' frameborder='0' width='100%' height='1000'></iframe>
              <script type='text/javascript'>
            document.getElementById('forum_embed').src =
                   'https://groups.google.com/a/svluka.org/forum/embed/?place=forum/folklore' 
                   + '&showsearch=false&hideforumtitle=true'
                   + '&showpopout=true&showtabs=false' 
                   + '&parenturl=' + encodeURIComponent(window.location.href)
";


            if (lang == "sr-SP-Cyrl" || lang == "sr-Cyrl-CS")	// Cirilica
            {
                this.googleGroup.Text = "<h2>Обавјештења</h2>" + this.googleGroup.Text + "+ '&hl=sr';";
            }
            else if (lang == "sr-SP-Latn" || lang == "sr-Latn-CS")	// Latinica
            {
                this.googleGroup.Text = "<h2>Obavjestenja</h2>" + this.googleGroup.Text + "+ '&hl=bs';";
            }
            else	// Engleski
            {
                this.googleGroup.Text = "<h2>Announcements</h2>" + this.googleGroup.Text + "+ '&hl=en';";
            }

            this.googleGroup.Text = this.googleGroup.Text + @"
                </script>";
        }

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    

		}
		#endregion
	}
}
