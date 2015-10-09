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
                this.lblList.Text = this.lblList.Text + "<div counter=" + counter + " style='padding-top:10px; font-weight: bold" + backgroundColor + "'>" + row["LastName"] + ", " + row["FirstName"] + "</div>";
                total = total + Convert.ToInt32(row["Amount"]);

            }

            this.lblList.Text = this.lblList.Text + "</div>";

            int progressPercent = Convert.ToInt16(Convert.ToDecimal(total) / goal * 100);
            this.lblProgress.Text = @"<div class='donation-meter'>
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
</div>";

            //this.lblProgress.Text = "<img border='0' alt='Goal $39,000 / month; currently $" + total + " / month' src='http://thermometer.fund-raising-ideas-center.com/thermometer.php?currency=dollar&goal=38000&current=" + total + "&color=red&size=large'>";


//            this.lblInstuctions.Text = HttpContext.GetGlobalResourceObject("Strings", "16_donation_instruction").ToString();
            this.lblInstuctions.Text = @"<p>As many of you know after many years and problems we built our Church and Hall (<a href='/SvLuka/Construction/'>see here for more info and pictures</a>).

<p>Naturally, our monthly expenses are much higher now with new mortgage than before. 

<p>To have smooth operations of the church (pay for mortgage, utilities, priest, candles etc.) we need $" + goal.ToString("###,###") + @". Right now we receive " + total.ToString("C") + @". 

<p>This goal is easily attainable! If you don’t see your name in the list below please do the following 2 things:
<ol>
<li><a href='https://secure.etransfer.com/SLSOC/Campaign.cfm' target=_blank>sign up</a> to give at least $90 / month (it takes less than 2 minutes)</li>
<li>call 2 other families that are not on the list below  and have them do the same.</li></ol>

<p>For vast majority of people working in America $90 per month is less than 1% of household income. 

<p>Please join families below and make sure we have our Serbian Orthodox Church to worship God regularly, for baptisms, marriages, burials and all other spiritual needs.

<p>Giving at least $90 per month to church is way better investment than college, 401K or any other funds or earthly treasures you might have. For where your treasure is, there your heart will be also [Luke 12:34]. Make sure your treasure is where no thief comes near nor moth destroys.";




//			this.lblAmount.Text = HttpContext.GetGlobalResourceObject("Strings", "17_donation_select_amount");
//			this.RequiredFieldValidator1.Text = HttpContext.GetGlobalResourceObject("Strings", "18_donation_missing");
//			this.RangeValidator1.Text = HttpContext.GetGlobalResourceObject("Strings", "19_donation_notvalid");
//			this.lblMinimum.Text = HttpContext.GetGlobalResourceObject("Strings", "21_donation_min");
//			this.cmdDonate.Text = HttpContext.GetGlobalResourceObject("Strings", "20_donation_submit");
//
//			// attach javascript to combo box
//			string java = "";
//			java = "" +
//				"if ( this.value == 'Other' )" +
//				"{" +
//				"	txtAmount.style.visibility = 'visible';" +
//				"	lblMinimum.style.visibility = 'visible';" +
//				"	lblDol.style.visibility = 'visible';" +
//				"}" +
//				"else" +
//				"{" +
//				"	Form1.txtAmount.style.visibility = 'hidden';" +
//				"	lblMinimum.style.visibility = 'hidden';" +
//				"	lblDol.style.visibility = 'hidden';" +
//				"	Form1.txtAmount.value = this.value;" +
//				"}";
//			this.cboAmount.Attributes.Add("onChange", java);
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

//		private void cmdDonate_Click(object sender, System.EventArgs e)
//		{
//			// send e-mail to let me know atempt made
//			MailMessage oMessage = new MailMessage();
//			oMessage.To = "dbujak@properit.com"; 
//			oMessage.From = "webmaster2006@svluka.org	"; 
//			oMessage.Subject = "Donation atempt for $" + this.txtAmount.Text + " just made"; 
//			oMessage.Body = "we'll see if it works ;-).";
//			oMessage.Fields["http://schemas.microsoft.com/cdo/configuration/sendusing"] = 2; 
//			oMessage.Fields["http://schemas.microsoft.com/cdo/configuration/smtpserver"] = "mail.properit.com"; 
//			oMessage.Fields["http://schemas.microsoft.com/cdo/configuration/sendusername"] = "dbujak@properit.com"; 
//			oMessage.Fields["http://schemas.microsoft.com/cdo/configuration/sendpassword"] = "pepelari"; 
//			oMessage.Fields["http://schemas.microsoft.com/cdo/configuration/smtpauthenticate"] = 1; 
//			System.Web.Mail.SmtpMail.SmtpServer = "mail.properit.com"; 
//
//			try 
//			{ 
//				System.Web.Mail.SmtpMail.Send(oMessage); 
////				Response.Write("Email sent!"); 
//			} 
//			catch (Exception Ex) 
//			{ 
////				Response.Write("Unable to send mail! " + Ex.Message); 
//			}
//
//			// build string to send to old asp page (old asp page will post to credit card processing center)
//			Session["amount"] = this.txtAmount.Text;
//			Response.Redirect("http://www.svluka.org/SvLuka/Donations/submit.asp?amount=" + this.txtAmount.Text);
//		}
	}
}
