using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Globalization;
using System.Resources;
using System.Collections.Specialized;
using System.Web.Mail;


namespace SvLuka.Donations
{
	/// <summary>
	/// Summary description for ThankYou.
	/// </summary>
	public partial class ThankYou : System.Web.UI.Page
	{
		protected SvLuka.controls.Header Header1;
		protected SvLuka.controls.Right Right1;

		protected void Page_Load(object sender, System.EventArgs e)
		{

			// set the page title
			

            this.Header1.lblPageTitle.Text = HttpContext.GetGlobalResourceObject("Strings", "23_thinkyou_title").ToString();

			// Check if hit refresh and don't update the database twice
			string oid = Request.Form["OID"];
			string strSQL = "Select Count(DN_Date) From tblDonations Where DN_oid='" + oid + "'";

			SvLuka.ConnString Conn = new ConnString();
			System.Data.OleDb.OleDbConnection objConn = new System.Data.OleDb.OleDbConnection( Conn.ConnenctionString );
			objConn.Open();
			System.Data.OleDb.OleDbCommand Com = new System.Data.OleDb.OleDbCommand( strSQL, objConn );

			int count = Convert.ToInt16( Com.ExecuteScalar() );
			
			// update database with the amount
			double amount = Convert.ToDouble( Request["chargetotal"] );
			// Say Thank you
            string msg = HttpContext.GetGlobalResourceObject("Strings", "24_thankyou_text").ToString();

			string bname = Convert.ToString( Request["bname"] );
			
			msg = msg.Replace( "dbujakbname", bname );
			msg = msg.Replace( "dbujakamount", amount.ToString() );

			this.lblThankYou.Text = msg;

			if ( amount >= 250 )
			{
                this.lblThankYou.Text += HttpContext.GetGlobalResourceObject("Strings", "25_thankyou_ps").ToString();
			}

			if ( count == 0 && oid != null && oid != "" )	// new request
			{
				strSQL = "Insert Into tblDonations (DN_Date, DN_Amount, DN_oid) Values(#" + DateTime.Now + 
					"#, " + amount.ToString() + ", '" + oid + "')";

				Com.CommandText = strSQL;

				Com.ExecuteNonQuery();
			}

			objConn.Close();

			// redraw thermostat
            //Right1.RedrawThermostat();

			// send e-mail to let me know atempt made
			MailMessage oMessage = new MailMessage();
			oMessage.To = "dbujak@properit.com"; 
			oMessage.From = "webmaster2006@svluka.org	"; 
			oMessage.Subject = "Donation atempt successful for $" + amount.ToString() + ""; 
			oMessage.Body = msg;
			oMessage.Fields["http://schemas.microsoft.com/cdo/configuration/sendusing"] = 2; 
			oMessage.Fields["http://schemas.microsoft.com/cdo/configuration/smtpserver"] = "mail.properit.com"; 
			oMessage.Fields["http://schemas.microsoft.com/cdo/configuration/sendusername"] = "dbujak@properit.com"; 
			oMessage.Fields["http://schemas.microsoft.com/cdo/configuration/sendpassword"] = "pepelari"; 
			oMessage.Fields["http://schemas.microsoft.com/cdo/configuration/smtpauthenticate"] = 1; 
			System.Web.Mail.SmtpMail.SmtpServer = "mail.properit.com"; 

			try 
			{ 
				System.Web.Mail.SmtpMail.Send(oMessage); 
				//				Response.Write("Email sent!"); 
			} 
			catch (Exception Ex) 
			{ 
				//				Response.Write("Unable to send mail! " + Ex.Message); 
			}

		}

//*************************************
// Responses from approved cards
//*************************************
//
//Key: status
//Value 0: APPROVED
//Key: OID
//Value 0: 172.30.184.47-109C0A4123D-12F3B59-88447
//Value 1: 172.30.184.47-109C0A4123D-12F3B59-88447
//Key: ttime
//Value 0: 03/03/06 10:05:13 AM
//Key: merchant
//Value 0: STLUKE ORTHODOX CHURCH
//Key: merchantphone
//Value 0: (301)299-2704
//Key: merchantemail
//Value 0: dbujak@hotmail.com
//Key: approval_code
//Value 0: Y:9678570101338773:YYYM:100415355837:
//Key: refnumber
//Value 0: 967857
//Key: txnorg
//Value 0: eci
//Key: chargetotal
//Value 0: 10.00
//Key: cardnumber
//Value 0: (MasterCard) ....1704
//Key: expmonth
//Value 0: 03
//Key: expyear
//Value 0: 2007
//Key: bname
//Value 0: Dejan Bujak
//Key: baddr1
//Value 0: 3122 Homewood PKWY
//Key: City, State, Zip:
//Value 0: Kensington, MD, 20895
//Key: bcountry
//Value 0: US
//Key: test1
//Value 0: 
//Key: shippingbypass
//Value 0: true
//Key: bcity
//Value 0: Kensington
//Key: bstate2
//Value 0: 
//Key: cctype
//Value 0: M
//Key: bzip
//Value 0: 20895
//Key: bstate
//Value 0: MD
//Key: Checkout2
//Value 0: Continue

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
