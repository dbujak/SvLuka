namespace SvLuka.controls
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using System.Globalization;
	using System.Resources;

	/// <summary>
	///		Summary description for Prevod.
	/// </summary>
	public partial class Prevod : System.Web.UI.UserControl
	{

		protected void Page_Load(object sender, System.EventArgs e)
		{

            // Check what language I need
            String lang = "";
            if (Request.Cookies["language"] != null) { lang = Request.Cookies["language"].Value; }
            if (lang == "sr-SP-Cyrl" || lang == "sr-Cyrl-CS")	// Cirilica
            {
                this.lblPrevod.Text = HttpContext.GetGlobalResourceObject("Strings", "96_prevod").ToString();
            }
            else if (lang == "sr-SP-Latn" || lang == "sr-Latn-CS")	// Latinica
            {
                this.lblPrevod.Text = HttpContext.GetGlobalResourceObject("Strings", "96_prevod").ToString();
            }
            else
            {
                this.lblPrevod.Text = "";
            }

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
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{

		}
		#endregion
	}
}
