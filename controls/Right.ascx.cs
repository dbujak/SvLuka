namespace SvLuka.controls
{
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

	/// <summary>
	///		Summary description for Right.
	/// </summary>
	public partial class Right : System.Web.UI.UserControl
	{

		protected void Page_Load(object sender, System.EventArgs e)
		{


            string lang = "";

            if (Request.Cookies["language"] != null) { lang = Request.Cookies["language"].Value; }
            if (lang == "sr-SP-Cyrl" || lang == "sr-Cyrl-CS")	// Cirilica
            {
                this.lblText.Text = "<b>Календар / Службе / Дешавања</b><br>";
                this.lblAgendaEn.Visible = false;
                this.lblAgendaSr.Visible = true;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
            }
            else if (lang == "sr-SP-Latn" || lang == "sr-Latn-CS")	// Latinica
            {
                this.lblText.Text = "<b>Kalendar / Službe / Dešavanja</b><br>";
                this.lblAgendaEn.Visible = false;
                this.lblAgendaSr.Visible = true;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
            }
            else	// Engleski
            {
                this.lblText.Text = "<b>Calendar / Services / Events</b><br>";
                this.lblAgendaEn.Visible = true;
                this.lblAgendaSr.Visible = false;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            }


//			// Check if amount stored in the session
//			int height = 0;
//			if ( Session["thermostatAmount"] != null && Session["thermostatAmount"].ToString() != "" )
//			{
//				height = GetHeight ( Convert.ToInt32( Session["thermostatAmount"] ) );
//				this.lblThermostat.Text = Thermostat( Convert.ToInt32( Session["thermostatAmount"] ), height );
//			}
//			else	// get it from database
//			{
//				RedrawThermostat();
//			}
//
//			this.lblLabel.Text = HttpContext.GetGlobalResourceObject("Strings", "55_right_label") + "<br>$" + Session["thermostatAmount"].ToString();

		}


        //public void RedrawThermostat()
        //{
		
        //    int height = 0;
        //    int amount = 0;
        //    // get it from database
        //    string strSQL = "Select Sum( DN_Amount ) From tblDonations";

        //    SvLuka.ConnString Conn = new ConnString();
        //    System.Data.OleDb.OleDbConnection objConn = new System.Data.OleDb.OleDbConnection( Conn.ConnenctionString );
        //    objConn.Open();
        //    System.Data.OleDb.OleDbCommand total = new System.Data.OleDb.OleDbCommand( strSQL, objConn );
        //    amount = Convert.ToInt32(total.ExecuteScalar());
        //    height = GetHeight( amount );
        //    objConn.Close();
        //    Session["thermostatAmount"] = amount;

        //    this.lblThermostat.Text = Thermostat( amount, height );
			
        //}

        //string Thermostat( int amount, int height )
        //{
        //    string table = "";

        //    table = "<TABLE id=\"Table1\" style=\"BACKGROUND-POSITION-X: left; BACKGROUND-IMAGE: url(/SvLuka/imgs/Thermometer.gif); BACKGROUND-REPEAT: no-repeat\"" +
        //        "height=\"277\" cellSpacing=\"0\" cellPadding=\"0\" border=\"0\" width=84px>" +
        //        "<TR>" +
        //        "	<TD width=\"20\"></TD>" +
        //        "	<TD valign=bottom><font size=1>";

        //    if ( amount < 1000 )
        //    {
        //        table = table + amount;
        //    }
        //    else
        //    {
        //        table = table + amount/1000 + "K";
        //    }

        //    table = table + "</font></TD>" +
        //        "	<TD></TD>" +
        //        "</TR>" +
        //        "<TR>" +
        //        "	<TD></TD>" +
        //        "	<TD width=\"19\" bgColor=\"#39586d\" height=" + height + "px></TD>" +
        //        "	<TD width=\"30\"></TD>" +
        //        "</TR>" +
        //        "<TR>" +
        //        "	<TD height=\"75\"></TD>" +
        //        "	<TD height=\"75\"></TD>" +
        //        "	<TD height=\"75\"></TD>" +
        //        "</TR>" +
        //        "</TABLE>";


        //    return table;
        //}


        //int GetHeight( int money )
        //{
        //    int totalMoney = 5000;

        //    // get how many dollars for each pixel
        //    double dpp = (double)160 / (double)totalMoney;
        //    int ret = Convert.ToInt32( money * dpp );
        //    if (ret == 0) ret = 1;

        //    return ret;
        //}

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
