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
using System.Threading;
using System.Globalization;
using System.Resources;
using System.Reflection;

namespace SvLuka
{
	/// <summary>
	/// Summary description for _default.
	/// </summary>
	public partial class _default : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			
			// Check if language preferences set from before
			if ( this.Request.Cookies["language"] != null )
			{
				Response.Redirect("/SvLuka/home.aspx");
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.cmdSerbian.Click += new System.Web.UI.ImageClickEventHandler(this.cmdSerbian_Click);
			this.cmdEnglish.Click += new System.Web.UI.ImageClickEventHandler(this.cmdEnglish_Click);
			this.cmdLatinica.Click += new System.Web.UI.ImageClickEventHandler(this.cmdLatinica_Click);

		}
		#endregion

		private void cmdSerbian_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
            try
            {
                Response.Cookies["language"].Value = "sr-Cyrl-CS";
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("sr-Cyrl-CS");
            }
            catch  	// Depending on updates one or the other works
            {
                Response.Cookies["language"].Value = "sr-SP-Cyrl";
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("sr-SP-Cyrl");
            }
			Response.Cookies["language"].Expires = DateTime.Now.AddYears(1);
			Response.Redirect("/SvLuka/home.aspx");		
		}

		private void cmdEnglish_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Cookies["language"].Value = "en-US";
			Thread.CurrentThread.CurrentUICulture = new CultureInfo( "en-US" );
			Response.Cookies["language"].Expires = DateTime.Now.AddYears(1);
			Response.Redirect("/SvLuka/home.aspx");		
		}

		private void cmdLatinica_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{
				Response.Cookies["language"].Value = "sr-Latn-CS";
				Thread.CurrentThread.CurrentUICulture = new CultureInfo( "sr-Latn-CS" );
			}
			catch  	// Depending on updates one or the other works
			{
				Response.Cookies["language"].Value = "sr-SP-Latn";
				Thread.CurrentThread.CurrentUICulture = new CultureInfo( "sr-SP-Latn" );
			}
			Response.Cookies["language"].Expires = DateTime.Now.AddYears(1);
			Response.Redirect( Request.UrlReferrer.AbsolutePath );
		}

//		private void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
//		{
//			Thread.CurrentThread.CurrentUICulture = new CultureInfo( this.DropDownList1.SelectedItem.Value );	
//			SetUIText();
//		}
//
//		void SetUIText()
//		{
//			ResourceManager rm = new ResourceManager("SvLuka.Strings", Assembly.GetExecutingAssembly());
//
//			this.Label1.Text = HttpContext.GetGlobalResourceObject("Strings", "title");
//			this.Label2.Text = HttpContext.GetGlobalResourceObject("Strings", "message");
//		}

	}
}
