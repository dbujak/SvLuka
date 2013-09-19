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

namespace SvLuka.Newsletter
{
	/// <summary>
	/// Summary description for _default.
	/// </summary>
	public partial class _default : System.Web.UI.Page
	{
		protected SvLuka.controls.Header Header1;

		protected void Page_Load(object sender, System.EventArgs e)
		{
			

            this.Header1.lblPageTitle.Text = HttpContext.GetGlobalResourceObject("Strings", "47_newsletterpage_title").ToString();
            this.lblPublications.Text = HttpContext.GetGlobalResourceObject("Strings", "48_newsletterpage_text").ToString();








            SvLuka.ConnString Conn = new ConnString();

            // Get the data
            string strSQL = "";
            // Have the line below setting english, so my query doesn't get broken with serbian date (22.11.2010 instead of 11/22/2010)
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            strSQL = "Select * From tblPublications Order By PB_Date Desc";

            DataTable DT = new DataTable();
            OleDbDataAdapter DA = new OleDbDataAdapter(strSQL, Conn.ConnenctionString);

            DA.Fill(DT);

            // Check what language I need
            string lang = "";
            string textField = "";
            string fileField = "";

            if (Request.Cookies["language"] != null) { lang = Request.Cookies["language"].Value; }
            if (lang == "sr-SP-Cyrl" || lang == "sr-Cyrl-CS")	// Cirilica
            {
                textField = "PB_TextCirilica";
                fileField = "PB_FileCirilica";
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
            }
            else if (lang == "sr-SP-Latn" || lang == "sr-Latn-CS")	// Latinica
            {
                textField = "PB_TextLatinica";
                fileField = "PB_FileLatinica";
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
            }
            else	// Engleski
            {
                textField = "PB_TextEnglish";
                fileField = "PB_FileEnglish";
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            }


            string monthYear = "";

            this.lblPublications.Text = this.lblPublications.Text + "<table border=0 cellpadding=3><tr><td>";

            foreach (System.Data.DataRow row in DT.Rows)
            {
                if (monthYear != ((DateTime)row["PB_Date"]).ToString("y", CultureInfo.CurrentCulture))
                {
                    if (monthYear != "") { this.lblPublications.Text = this.lblPublications.Text + "</ul>"; }

                    monthYear = ((DateTime)row["PB_Date"]).ToString("y", CultureInfo.CurrentCulture);
                    this.lblPublications.Text = this.lblPublications.Text + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(monthYear) + "<ul>";
                }

                this.lblPublications.Text = this.lblPublications.Text +
                    "<li><a href=\"PubFiles/" + row[fileField] + "\" target=_blank>" + row[textField] + "</a>, " + ((DateTime)row["PB_Date"]).ToString("D", CultureInfo.CurrentCulture) + "</li>";
            }
            this.lblPublications.Text = this.lblPublications.Text + "</ul></td></tr></table>";








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
