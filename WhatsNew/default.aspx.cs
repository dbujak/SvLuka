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
using System.Threading;

namespace SvLuka.WhatsNew
{
	/// <summary>
	/// Summary description for _default.
	/// </summary>
	/// 

	
	public partial class _default : System.Web.UI.Page
	{
		protected SvLuka.controls.Header Header1;

		private void delWhatsNew( string ID )
		{
			ConnString conn = new ConnString();
			bool logged = conn.isLogged( Session["boolLogged"] );

			if ( logged == true )
			{
				string strSQL = "Update tblWhatsNew Set WN_Visibile = 0 Where WN_ID = @ID";

				System.Data.OleDb.OleDbCommand comm = new System.Data.OleDb.OleDbCommand();
			
				comm.Parameters.Add( new System.Data.OleDb.OleDbParameter( "@ID", ID ) );

				ConnString conStr = new ConnString();
				comm.Connection = new System.Data.OleDb.OleDbConnection( conStr.ConnenctionString );
				comm.Connection.Open();
				comm.CommandText = strSQL;
				comm.CommandType = CommandType.Text;
				comm.ExecuteNonQuery();
				comm.Connection.Close();
			}

		}
		
		protected void Page_Load(object sender, System.EventArgs e)
		{
			this.lblWhatsNew.Text = "";

			

            this.Header1.lblPageTitle.Text = HttpContext.GetGlobalResourceObject("Strings", "9_whatsnew_page_title").ToString();

			if ( Request["delID"] !=null && Request["delID"] != "" )
			{
				delWhatsNew( Request["delID"].ToString() );
			}
			
			SvLuka.ConnString Conn = new ConnString();
			// Check to see if logged in
			bool logged = Conn.isLogged( Session["boolLogged"] );

			// Get the data
			string strSQL = "";
			if ( logged )
			{
				strSQL = "Select * From tblWhatsNew " +
					"Where WN_SDate <=#" + System.DateTime.Today.ToShortDateString() +
					"# And WN_EDate >=#" +  System.DateTime.Today.ToShortDateString() +
					"# ";
			}
			else
			{
				strSQL = "Select * From tblWhatsNew " +
					"Where WN_SDate <=#" + System.DateTime.Today.ToShortDateString() +
					"# And WN_EDate >=#" +  System.DateTime.Today.ToShortDateString() +
					"# And WN_Visibile = -1 ";
			}
			
			strSQL = strSQL + " Order By WN_Order Desc";
			DataTable DT = new DataTable();
			OleDbDataAdapter DA = new OleDbDataAdapter( strSQL, Conn.ConnenctionString );

			DA.Fill( DT );

			// Check what language I need
			string lang = "";
			string field = "";
			if ( Request.Cookies["language"] != null ) { lang = Request.Cookies["language"].Value; }
			if ( lang == "sr-SP-Cyrl" || lang == "sr-Cyrl-CS" )	// Cirilica
			{
				field = "WN_Cirilica";
				Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture( lang );
			}
			else if ( lang == "sr-SP-Latn" || lang == "sr-Latn-CS" )	// Latinica
			{
				field = "WN_Latinica";
				Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture( lang );
			}
			else	// Engleski
			{
				field = "WN_English";
				Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture( "en-US" );
			}

			// loop and build the page
			if (logged)
			{
				this.lblWhatsNew.Text = "<script language=javascript>" +
					"function confDel(id)" +
					"{" +
					"	if (confirm('Are you sure you want to delete'))" +
					"	{" +
					"		window.location.replace('default.aspx?delID=' + id);" +
					"	}" +
					"}" +
					"</script>";

				this.lblWhatsNew.Text = this.lblWhatsNew.Text + "<a href=edit.aspx?ID=0>Add New</a>";
			}
			
			this.lblWhatsNew.Text = this.lblWhatsNew.Text  + "<table border=0 cellpadding=3>";
			
			foreach ( System.Data.DataRow row in DT.Rows )
			{
				// if admin show edit delete
				if ( logged )
				{
					this.lblWhatsNew.Text = this.lblWhatsNew.Text + "<tr><td><a href=edit.aspx?ID=" + row["WN_ID"] + ">Edit</a>&nbsp&nbsp;&nbsp" +
						"<a href=\"javascript:confDel('" + row["WN_ID"] + "');\">Delete</a>&nbsp;&nbsp;&nbsp;Order: " + row["WN_Order"];
					if ( !Convert.ToBoolean( row["WN_Visibile"] ) )
					{
						this.lblWhatsNew.Text = this.lblWhatsNew.Text + "&nbsp;&nbsp;&nbsp;<font color=red><b>NOT ACTIVE</b></font>";
					}
					this.lblWhatsNew.Text = this.lblWhatsNew.Text + "</td></tr>";
				}
						
				this.lblWhatsNew.Text = this.lblWhatsNew.Text + 
					"<tr>" +
					"<td>" + HttpContext.GetGlobalResourceObject("Strings", "13_whatsnew_updated") + ": " + ((DateTime)row["WN_Date"]).ToString("D", CultureInfo.CurrentCulture) + "</td>" +
					"</tr>" +
					"<tr>" +
					"<td>" + row[field] + "</td>" +
					"</tr>" +
					"<tr>" +
					"<td colspan=2 align=center><img src=\"/SvLuka/imgs/vines.gif\"></td>" +
					"</tr>"; 
				
			}
			this.lblWhatsNew.Text = this.lblWhatsNew.Text + "</table>";
		
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
