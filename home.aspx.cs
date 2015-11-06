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


namespace SvLuka
{
	/// <summary>
	/// Summary description for home.
	/// </summary>
	public partial class home : System.Web.UI.Page
	{
		protected SvLuka.controls.Header Header1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here


            this.Announcments.Text = "";

            


            SvLuka.ConnString Conn = new ConnString();

            // Get the data
            string strSQL = "";
            // Have the line below setting english, so my query doesn't get broken with serbian date (22.11.2010 instead of 11/22/2010)
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            strSQL = "Select * From tblWhatsNew " +
                "Where WN_SDate <=#" + System.DateTime.Today.ToShortDateString() +
                "# And WN_EDate >=#" + System.DateTime.Today.ToShortDateString() +
                "# And WN_Visibile = -1 ";

            strSQL = strSQL + " Order By WN_Order Desc";
            DataTable DT = new DataTable();
            OleDbDataAdapter DA = new OleDbDataAdapter(strSQL, Conn.ConnenctionString);

            DA.Fill(DT);

            // Check what language I need
            string lang = "";
            string field = "";
            if (Request.Cookies["language"] != null) { lang = Request.Cookies["language"].Value; }

            // set up google group embeded part
            this.parishGoogleGroup.Text = @"<iframe id='forum_embed' src='javascript:void(0)' scrolling='no' frameborder='0' width='100%' height='1000'></iframe>
              <script type='text/javascript'>
            document.getElementById('forum_embed').src =
                   'https://groups.google.com/a/svluka.org/forum/embed/?place=forum/parish' 
                   + '&showsearch=false&hideforumtitle=true'
                   + '&showpopout=true&showtabs=false' 
                   + '&parenturl=' + encodeURIComponent(window.location.href)
";

        
            if (lang == "sr-SP-Cyrl" || lang == "sr-Cyrl-CS")	// Cirilica
            {
                field = "WN_Cirilica";
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);

                this.parishGoogleGroup.Text = this.parishGoogleGroup.Text + "+ '&hl=sr';";
            }
            else if (lang == "sr-SP-Latn" || lang == "sr-Latn-CS")	// Latinica
            {
                field = "WN_Latinica";
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
                this.parishGoogleGroup.Text = this.parishGoogleGroup.Text + "+ '&hl=bs';";
            }
            else	// Engleski
            {
                field = "WN_English";
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                this.parishGoogleGroup.Text = this.parishGoogleGroup.Text + "+ '&hl=en';";
            }

            this.parishGoogleGroup.Text = this.parishGoogleGroup.Text + @"
                </script>";

            this.Announcments.Text = this.Announcments.Text + "<table border=0 cellpadding=3>";

            foreach (System.Data.DataRow row in DT.Rows)
            {

                this.Announcments.Text = this.Announcments.Text +
                    //"<tr>" +
                    //"<td>" + HttpContext.GetGlobalResourceObject("Strings", "13_whatsnew_updated") + ": " + ((DateTime)row["WN_Date"]).ToString("D", CultureInfo.CurrentCulture) + "</td>" +
                    //"</tr>" +
                    "<tr>" +
                    "<td order=" + row["WN_Order"] + ">" + row[field] + "</td>" +
                    "</tr>" +
                    "<tr>" +
                    "<td colspan=2 align=center><img src=\"/SvLuka/imgs/vines.gif\"></td>" +
                    "</tr>";

            }
            this.Announcments.Text = this.Announcments.Text + "</table>";





            this.Header1.lblPageTitle.Text = HttpContext.GetGlobalResourceObject("Strings", "7_home_page_title").ToString();



            this.lblTroparon.Text = HttpContext.GetGlobalResourceObject("Strings", "2_home_religius").ToString();

            this.lblHomeMsg.Text = HttpContext.GetGlobalResourceObject("Strings", "8_home_text").ToString();


            
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

        protected void Right1_Load(object sender, EventArgs e)
        {

        }

	}
}
