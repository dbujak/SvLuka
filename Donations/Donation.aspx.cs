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
            this.lblInstuctions.Text = @"
<h2>$90/Month Fundraising Campaign</h2>
<em>“For where your treasure is, there your heart will be also.” [Luke 12:34]</em>

<h3>The Facts</h3>
<ol>
<li>After many years and challenges we completed our Church and Hall in September of 2014 (<a href='http://svluka.org/SvLuka/Construction/'>see here</a> for more info and pictures).</li>
<li>Our monthly expenses are significantly higher now with the new facility than before (higher mortgage, utilities, etc.).</li>
<li>We <b><u>need</b></u> $30,000/month to cover our projected expenses</li>
<li>We are <b><u>currently</b></u> receiving just over $21,000 a month.    </li>
</ol>

<h3>The Goal</h3>
<p>We have set a target of $39,000 a month in revenue to cover our expenses and to raise additional funds to pay down our loan of $2,212,000.</p>

<h3>What Is Being Asked of You & Your Family</h3>
<ol>
<li>Sign up to donate $90 a month; we have created a very simple <a href='https://secure.etransfer.com/SLSOC/Campaign.cfm' target=_blank>one-page form</a> for this campaign; on this form, you can sign up for monthly payments via credit card or electronic transfer from your bank account.</li>
<li>Equally, if not more importantly: as soon as we publish a list of donors (on our church web site and in the church hall), call your friends/kumovi/family members that are not on the list and get at least 2 of them sign up to donate $90/month. </li>
</ol>

<h3>Interesting Tidbits</h3>
<ol>
<li>We are asking for donations in units of $90/month – this is equivalent to $3/day (the cost of coffee at Starbuck’s). </li>
<li>For the vast majority of households in our area, this represents less than 1% of gross household income.</li>
<li>For 2014, we sent out 286 tax letters; only 54 of those were for over $90/month.</li>
<li>We have almost 600 people on our mailing list, over 500 on our e-mail list, and many thousands more in the Baltimore/DC area – we can do better!</li>
</ol>

<h3>Where Is Your Heart?</h3>
<p>Regardless of your income, if the church is the last item on your budget list (after retirement funds, kid’s college funds, vacation savings, house savings, car savings,  etc.) there probably will be no funds left for the church...</p>

<p>Budgeting at least $90 per month to help our church as the 1st item on your budget list is a way better investment than college, 401K and any other funds and earthly treasures you might have - all put together.</p>

<p>By supporting the church we will continue to have our Serbian Orthodox Church to worship God regularly, come together for fellowship & social activities, to baptize our children, to celebrate the sacrament of holy matrimony, to conduct memorial services & funerals and all other spiritual needs.</p>



";




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
