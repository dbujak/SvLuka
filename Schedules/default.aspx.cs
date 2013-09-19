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


namespace SvLuka.Schedules
{
	/// <summary>
	/// Summary description for _default.
	/// </summary>
	public class _default : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblSchedules;
        protected System.Web.UI.WebControls.Label lblFastDays;
        protected System.Web.UI.WebControls.Label lblCalendarEn;
        protected System.Web.UI.WebControls.Label lblCalendarSr;
        protected System.Web.UI.WebControls.Label lblCalendars;
        protected SvLuka.controls.Header Header1;


//		void delSchedule (string ID )
//		{
//			ConnString conn = new ConnString();
//			bool logged = conn.isLogged( Session["boolLogged"] );
//
//			if ( logged == true )
//			{
//				string strSQL = "Delete From tblSchedules Where SC_ID = @ID";
//
//				System.Data.OleDb.OleDbCommand comm = new System.Data.OleDb.OleDbCommand();
//			
//				comm.Parameters.Add( new System.Data.OleDb.OleDbParameter( "@ID", ID ) );
//
//				ConnString conStr = new ConnString();
//				comm.Connection = new System.Data.OleDb.OleDbConnection( conStr.ConnenctionString );
//				comm.Connection.Open();
//				comm.CommandText = strSQL;
//				comm.CommandType = CommandType.Text;
//				comm.ExecuteNonQuery();
//				comm.Connection.Close();
//			}
//		}


		private void Page_Load(object sender, System.EventArgs e)
		{


            this.Header1.lblPageTitle.Text = HttpContext.GetGlobalResourceObject("Strings", "14_schedules_page_title").ToString();
            this.lblSchedules.Text = HttpContext.GetGlobalResourceObject("Strings", "91_schedules_page_page").ToString();
            this.lblFastDays.Text = HttpContext.GetGlobalResourceObject("Strings", "91.5_schedules_page_fast").ToString();
            this.lblCalendars.Text = HttpContext.GetGlobalResourceObject("Strings", "91.7_schedules_calendars").ToString();


            string lang = "";

            if (Request.Cookies["language"] != null) { lang = Request.Cookies["language"].Value; }
            if (lang == "sr-SP-Cyrl" || lang == "sr-Cyrl-CS")	// Cirilica
            {
                this.lblCalendarEn.Visible = false;
                this.lblCalendarSr.Visible = true;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
            }
            else if (lang == "sr-SP-Latn" || lang == "sr-Latn-CS")	// Latinica
            {
                this.lblCalendarEn.Visible = false;
                this.lblCalendarSr.Visible = true;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
            }
            else	// Engleski
            {
                this.lblCalendarEn.Visible = true;
                this.lblCalendarSr.Visible = false;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            }
            //			this.lblSchedules.Text = "<p>" + this.lblSchedules.Text + rm.GetString("91_schedules_page_page") + "<br><br>";
//
//			if ( Request["delID"] !=null && Request["delID"] != "" )
//			{
//				delSchedule( Request["delID"].ToString() );
//			}
//		
//			// Get the data
//			SvLuka.ConnString Conn = new ConnString();
//			// Check to see if logged in
//			bool logged = Conn.isLogged( Session["boolLogged"] );
//
//			string strSQL = "";
//
//			if ( logged == true )
//			{
//				strSQL = "Select * From tblSchedules Left Join tblDirections " +
//					" On tblSchedules.SC_LC_ID_FK = tblDirections.LC_ID " + 
//					"Where SC_Date >=#" + System.DateTime.Today.ToShortDateString() +
//					"# And SC_Date <=#" + System.DateTime.Today.AddYears(1).ToShortDateString() + 
//					"# Order By SC_Date";
//			}
//			else
//			{
//				strSQL = "Select * From tblSchedules Left Join tblDirections " +
//					" On tblSchedules.SC_LC_ID_FK = tblDirections.LC_ID " + 
//					"Where SC_Date >=#" + System.DateTime.Today.ToShortDateString() +
//					"# And SC_Date <=#" + System.DateTime.Today.AddMonths(2).ToShortDateString() + 
//					"# Order By SC_Date";
//			}
//			
//			DataTable DT = new DataTable();
//			OleDbDataAdapter DA = new OleDbDataAdapter( strSQL, Conn.ConnenctionString );
//
//			DA.Fill( DT );
//
//			// Check what language I need
//			string lang = "";
//			string field = "";
//			string location = "";
//			if ( Request.Cookies["language"] != null ) { lang = Request.Cookies["language"].Value; }
//			if ( lang == "sr-SP-Cyrl" || lang == "sr-Cyrl-CS" )	// Cirilica
//			{
//				field = "SC_Cirilica";
//				location = "LC_NameCir";
//				Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture( lang );
//			}
//			else if ( lang == "sr-SP-Latn" || lang == "sr-Latn-CS" )	// Latinica
//			{
//				field = "SC_Latinica";
//				location = "LC_NameLat";
//				Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture( lang );
//			}
//			else	// Engleski
//			{
//				field = "SC_English";
//				location = "LC_NameEng";
//				Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture( "en-US" );
//			}
//
//			if ( logged == true )
//			{
//				this.lblSchedules.Text = this.lblSchedules.Text + "<script language=javascript>" +
//					"function confDel(id)" +
//					"{" +
//					"	if (confirm('Are you sure you want to delete'))" +
//					"	{" +
//					"		window.location.replace('default.aspx?delID=' + id);" +
//					"	}" +
//					"}" +
//					"</script>";
//				this.lblSchedules.Text = this.lblSchedules.Text + "<a href=edit.aspx?ID=0>Add New</a>";
//			}
//			// loop and build the page
//			this.lblSchedules.Text = this.lblSchedules.Text + "<table border=0 cellpadding=3>";
//			foreach ( System.Data.DataRow row in DT.Rows )
//			{
//				if ( logged == true )
//				{
//					this.lblSchedules.Text = this.lblSchedules.Text +
//						"<tr>" +
//						"<td colsan=2><a href=edit.aspx?ID=" + row["SC_ID"].ToString().Replace(" ", "%20") + ">Edit</a>&nbsp;&nbsp;&nbsp;" +
//						"<a href='javascript:confDel(\"" + row["SC_ID"] + "\");'>Delete</a>";
//				}
//
//				this.lblSchedules.Text = this.lblSchedules.Text + 
//					"<tr>" +
//					"<td valign=top>";
//				// show time if time specified
//				if ( Convert.ToBoolean( row["SC_NoTime"] ) == false )
//				{
//					this.lblSchedules.Text = this.lblSchedules.Text + ((DateTime)row["SC_Date"]).ToString("f", CultureInfo.CurrentCulture);
//				}
//				else
//				{
//					this.lblSchedules.Text = this.lblSchedules.Text + ((DateTime)row["SC_Date"]).ToString("D", CultureInfo.CurrentCulture);
//				}
//				this.lblSchedules.Text = this.lblSchedules.Text + "</td><td valign=top>" + row[field] ;
//				// show location if specified
//				if ( row[location].ToString() != "" )
//				{
//					this.lblSchedules.Text = this.lblSchedules.Text + " (<a href=/SvLuka/Directions/default.aspx#" + row["LC_ID"] + ">" +
//						row[location] + "</a>)";
//				}
//					
//					
//				this.lblSchedules.Text = this.lblSchedules.Text + "</td></tr>"; 
//
//			}
//			this.lblSchedules.Text = this.lblSchedules.Text + "</table>";

			// Add disclamer
//			this.lblSchedules.Text = this.lblSchedules.Text + "<p><font size=1>" + rm.GetString("58_schedule_disclamer") + "</font></p>";
		
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
