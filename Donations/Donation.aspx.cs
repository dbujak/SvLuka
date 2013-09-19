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

            this.lblInstuctions.Text = HttpContext.GetGlobalResourceObject("Strings", "16_donation_instruction").ToString();
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
