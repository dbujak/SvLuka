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
using System.Web.Mail; 

namespace SvLuka.Donations
{
	/// <summary>
	/// Summary description for Donation.
	/// </summary>
	public partial class Donation : System.Web.UI.Page
	{
		protected SvLuka.controls.Header Header1;

		protected void Page_Load(object sender, System.EventArgs e)
		{
			

            this.Header1.lblPageTitle.Text = HttpContext.GetGlobalResourceObject("Strings", "15_donation_page_title").ToString();


            string strSQL = "Select * From tblDonations Where Amount > 83 Order By LastName + FirstName";

            SvLuka.ConnString Conn = new ConnString();

            DataTable DT = new DataTable();
            OleDbDataAdapter DA = new OleDbDataAdapter(strSQL, Conn.ConnenctionString);

            DA.Fill(DT);

            this.lblList.Text = "<div class='newspaper'>";

            int goal = 39000;
            int counter = 0;
            int total = 0;
            string backgroundColor = "";
            foreach (System.Data.DataRow row in DT.Rows)
            {
                counter = counter + 1;
                //if (counter % 2 == 0)
                //{
                //    backgroundColor = "background-color: lightyellow;";
                //}
                //else {
                //    backgroundColor = "";
                //}
                this.lblList.Text = this.lblList.Text + "<div counter=" + counter + " style='padding-top:10px; font-weight: bold" + backgroundColor + "'>" + row["LastName"] + ", " + row["FirstName"];
                if (row["SpouseName"] != System.DBNull.Value)
                {
                    this.lblList.Text = this.lblList.Text + " and " + row["SpouseName"];
                }
                    this.lblList.Text = this.lblList.Text + "</div>";
                total = total + Convert.ToInt32(row["Amount"]);

            }

            this.lblList.Text = this.lblList.Text + "</div>";

            int progressPercent = Convert.ToInt16(Convert.ToDecimal(total) / goal * 100);
            this.lblProgress.Text = @"
                <a href='https://secure.etransfer.com/SLSOC/Campaign.cfm' target=_blank border=0>
                <div class='donation-meter'>
                  <strong>Monthly Goal</strong>
                  <strong class='goal'>$" + goal.ToString("###,###") + @"</strong>
                  <span class='glass'>
                      <strong class='total' style='bottom: " + progressPercent + "%'>$" + total.ToString("###,###") + @"</strong>
                      <span class='amount' style='height: " + progressPercent + @"%'></span>
                  </span>
                  <div class='bulb'>
                      <span class='red-circle'></span>
                      <span class='filler'>
                          <span></span>
                      </span>
                  </div>
                </div>
                </a>";

            this.lblInstuctions.Text = HttpContext.GetGlobalResourceObject("Strings", "16_donation_instruction").ToString();

            this.lblMoreInfo.Text = HttpContext.GetGlobalResourceObject("Strings", "17_donation_instruction_more").ToString().Replace("dbTotalAMonth", total.ToString("$###,###"));





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
