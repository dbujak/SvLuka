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
	///		Summary description for Header.
	/// </summary>
	public partial class Header : System.Web.UI.UserControl
	{
		public System.Web.UI.WebControls.Label lblPageTitle;

		protected void Page_Load(object sender, System.EventArgs e)
		{


            this.lblTitle.Text = HttpContext.GetGlobalResourceObject("Strings", "1_title").ToString();
            this.lblDonations.Text = HttpContext.GetGlobalResourceObject("Strings", "24_header_donate").ToString();
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
