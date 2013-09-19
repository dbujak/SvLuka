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

namespace SvLuka.Directions
{
	/// <summary>
	/// Summary description for _default.
	/// </summary>
	public partial class _default : System.Web.UI.Page
	{
		protected SvLuka.controls.Header Header1;

		protected void Page_Load(object sender, System.EventArgs e)
		{

			

            this.Header1.lblPageTitle.Text = HttpContext.GetGlobalResourceObject("Strings", "10_directions_page_title").ToString();

			// Get the data
			string strSQL = "Select * From tblDirections Where LC_ID <> 'dummy' Order By LC_Order";
			DataTable DT = new DataTable();
			SvLuka.ConnString Conn = new ConnString();
			OleDbDataAdapter DA = new OleDbDataAdapter( strSQL, Conn.ConnenctionString );

			DA.Fill( DT );

			// Check what language I need
			string lang = "";
			string field = "";
			string name = "";
			if ( Request.Cookies["language"] != null ) { lang = Request.Cookies["language"].Value; }
			if ( lang == "sr-SP-Cyrl" || lang == "sr-Cyrl-CS" )	// Cirilica
			{
				field = "LC_Cirilica";
				name = "LC_NameCir";
			}
			else if ( lang == "sr-SP-Latn" || lang == "sr-Latn-CS" )	// Latinica
			{
				field = "LC_Latinica";
				name = "LC_NameLat";
			}
			else	// Engleski
			{
				field = "LC_English";
				name = "LC_NameEng";
			}

			// loop and build the page
			this.lblDirections.Text = "<table border=0 cellpadding=3>";
			foreach ( System.Data.DataRow row in DT.Rows )
			{
				this.lblDirections.Text = this.lblDirections.Text + 
					"<tr>" +
						"<td valign=top><a name=#" + row["LC_ID"] + "></a></td>" +
						"<td><div class=addressBold>" + row[name] + "</div><br>" + row["LC_Address"] + "</td>" +
					"</tr>" +
					"<tr>" +
						"<td valign=top><div class=addressBold>" + HttpContext.GetGlobalResourceObject("Strings", "11_directions_directions") + "</div></td>" +
						"<td>" + row[field] + "</td>" +
					"</tr>" +
					"<tr>" +
						"<td colspan=2 align=center><img src=\"/SvLuka/imgs/vines.gif\"></td>" +
					"</tr>"; 
			}
			this.lblDirections.Text = this.lblDirections.Text + "</table>";

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
