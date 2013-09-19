using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Globalization;
using System.Resources;

namespace SvLuka.Links
{
	/// <summary>
	/// Summary description for _default.
	/// </summary>
	public partial class _default : System.Web.UI.Page
	{
		protected SvLuka.controls.Header Header1;

		protected void Page_Load(object sender, System.EventArgs e)
		{
			

            this.Header1.lblPageTitle.Text = HttpContext.GetGlobalResourceObject("Strings", "79_links").ToString();

            this.lblLinks.Text = "<p>" + HttpContext.GetGlobalResourceObject("Strings", "81_links_page").ToString() + "</p>";



			SvLuka.ConnString Conn = new ConnString();

			// Get the data
			string strSQL = "";
			strSQL = "Select * From tblLinks Order By LK_Order ";
			
			DataTable DT = new DataTable();
			OleDbDataAdapter DA = new OleDbDataAdapter( strSQL, Conn.ConnenctionString );

			DA.Fill( DT );

			// Check what language I need
//			string lang = "";
//			string field = "";
//			if ( Request.Cookies["language"] != null ) { lang = Request.Cookies["language"].Value; }
//			if ( lang == "sr-SP-Cyrl" || lang == "sr-Cyrl-CS" )	// Cirilica
//			{
//				field = "WN_Cirilica";
//				Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture( lang );
//			}
//			else if ( lang == "sr-SP-Latn" || lang == "sr-Latn-CS" )	// Latinica
//			{
//				field = "WN_Latinica";
//				Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture( lang );
//			}
//			else	// Engleski
//			{
//				field = "WN_English";
//				Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture( "en-US" );
//			}

			// loop and build the page
			
			this.lblLinks.Text = this.lblLinks.Text + "<table border=0 cellpadding=3>";
			
			foreach ( System.Data.DataRow row in DT.Rows )
			{
						
				this.lblLinks.Text = this.lblLinks.Text + 
					"<tr>" +
					"<td><a href='" + row["LK_URL"] + "' target=_blank>" + row["LK_Name"] + "</a></td><td width=20>&nbsp</td>" +
					"<td><a href='" + row["LK_URL"] + "' target=_blank>" + row["LK_URL"] + "</a></td>" +
					"</tr>" +
					"<tr>" +
					"<td colspan=3 height=10>&nbsp</td>" +
					"</tr>"; 
				
			}
			this.lblLinks.Text = this.lblLinks.Text + "</table>";

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
