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

namespace SvLuka.Construction
{
	/// <summary>
	/// Summary description for _default.
	/// </summary>
	public partial class _default : System.Web.UI.Page
	{
		protected SvLuka.controls.Header Header1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			

            this.Header1.lblPageTitle.Text = HttpContext.GetGlobalResourceObject("Strings", "72_construction_title").ToString();

			this.lblConstruction.Text = "";

            // Top of the page
            SvLuka.ConnString Conn = new ConnString();
            DataTable DTtop = new DataTable();
            OleDbDataAdapter DAtop = new OleDbDataAdapter("SELECT Distinct Year(CN_Date) FROM tblConstruction Order By Year(CN_Date) Desc", Conn.ConnenctionString);
            int year = 2013;
            int passedYear;
            bool bpassedYear = int.TryParse(Request.QueryString["year"], out passedYear);
            
            if (!bpassedYear) passedYear = 2013;

            DAtop.Fill(DTtop);

            do
            {
                bool match = false;

                foreach (System.Data.DataRow row in DTtop.Rows)
                {
                    if (Convert.ToInt32(row[0]) == year)
                    {
                        match = true;
                    }
                }

                if (match && (passedYear != year))
                {
                    this.lblConstruction.Text = this.lblConstruction.Text + " &nbsp;&nbsp;&nbsp; <a href='default.aspx?year=" + year + "'>" + year + "</a>";
                }
                else
                {
                    this.lblConstruction.Text = this.lblConstruction.Text + " &nbsp;&nbsp;&nbsp; " + year;
                }

                year = year - 1;
            } while (year >= 2006);


            if (Request["delID"] != null && Request["delID"] != "")
            {
                delConstruction(Request["delID"].ToString());
            }

            // Check to see if logged in
            bool logged = Conn.isLogged(Session["boolLogged"]);

            // Get the data
            string strSQL = "Select * From tblConstruction Where Year(CN_Date) = " + passedYear + " ";


            if (!logged)
            {
                strSQL = strSQL + "And CN_Visibile = -1 ";
            }

            strSQL = strSQL + " Order By CN_Date Desc";
            DataTable DT = new DataTable();
            OleDbDataAdapter DA = new OleDbDataAdapter(strSQL, Conn.ConnenctionString);

            DA.Fill(DT);

            // Check what language I need
            string lang = "";
            string field = "";
            if (Request.Cookies["language"] != null) { lang = Request.Cookies["language"].Value; }
            if (lang == "sr-SP-Cyrl" || lang == "sr-Cyrl-CS")	// Cirilica
            {
                field = "CN_Cirilica";
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
            }
            else if (lang == "sr-SP-Latn" || lang == "sr-Latn-CS")	// Latinica
            {
                field = "CN_Latinica";
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
            }
            else	// Engleski
            {
                field = "CN_English";
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            }

            // loop and build the page
            if (logged)
            {
                this.lblConstruction.Text = this.lblConstruction.Text + "<script language=javascript>" +
                    "function confDel(id)" +
                    "{" +
                    "	if (confirm('Are you sure you want to delete'))" +
                    "	{" +
                    "		window.location.replace('default.aspx?delID=' + id);" +
                    "	}" +
                    "}" +
                    "</script>";

                this.lblConstruction.Text = this.lblConstruction.Text + "<a href=edit.aspx?ID=0>Add New</a>";
            }

            this.lblConstruction.Text = this.lblConstruction.Text + "<table border=0 cellpadding=3>";

            foreach (System.Data.DataRow row in DT.Rows)
            {
                // if admin show edit delete
                if (logged)
                {
                    this.lblConstruction.Text = this.lblConstruction.Text + "<tr><td><a href=edit.aspx?ID=" + row["CN_ID"] + ">Edit</a>&nbsp&nbsp;&nbsp" +
                        "<a href=\"javascript:confDel('" + row["CN_ID"] + "');\">Delete</a>&nbsp;&nbsp;&nbsp;Order: " + row["CN_Order"];
                    if (!Convert.ToBoolean(row["CN_Visibile"]))
                    {
                        this.lblConstruction.Text = this.lblConstruction.Text + "&nbsp;&nbsp;&nbsp;<font color=red><b>NOT ACTIVE</b></font>";
                    }
                    this.lblConstruction.Text = this.lblConstruction.Text + "</td></tr>";
                }

                this.lblConstruction.Text = this.lblConstruction.Text +
                    "<tr>" +
                    "<td>" + HttpContext.GetGlobalResourceObject("Strings", "13_whatsnew_updated") + ": " + ((DateTime)row["CN_Date"]).ToString("D", CultureInfo.CurrentCulture) + "</td>" +
                    "</tr>" +
                    "<tr>" +
                    "<td>" + row[field] + "</td>" +
                    "</tr>" +
                    "<tr>" +
                    "<td colspan=2 align=center><img src=\"/SvLuka/imgs/vines.gif\"></td>" +
                    "</tr>";

            }
            this.lblConstruction.Text = this.lblConstruction.Text + "</table>";


		}

		private void delConstruction( string ID )
		{
			ConnString conn = new ConnString();
			bool logged = conn.isLogged( Session["boolLogged"] );

			if ( logged == true )
			{
				string strSQL = "Update tblConstruction Set CN_Visibile = 0 Where CN_ID = @ID";

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
