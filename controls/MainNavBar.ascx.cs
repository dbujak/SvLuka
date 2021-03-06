namespace SvLuka.controls
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using System.Globalization;
	using System.Resources;
    using System.Threading;

	/// <summary>
	///		Summary description for MainNavBar.
	/// </summary>
	public partial class MainNavBar : System.Web.UI.UserControl
	{
		protected System.Web.UI.WebControls.LinkButton cmdSundaySchool;

		protected void Page_Load(object sender, System.EventArgs e)
		{



            string lang = "";

            if (Request.Cookies["language"] != null) { lang = Request.Cookies["language"].Value; }
            if (lang == "sr-SP-Cyrl" || lang == "sr-Cyrl-CS")	// Cirilica
            {
                this.lblSubscribe.Text = "<b>Драги парохијани, молимо вас да нам пошаљете своју е-маил адресу, да можемо да вам шаљемо обавјештења:</b>";
                this.cmdSubscribe.Text = "Пошаљи";
                this.RegularExpressionValidator1.ErrorMessage = "Неправилна е-маил адреса";
                this.RequiredFieldValidator1.ErrorMessage = "Заборавили сте е-маил";
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
            }
            else if (lang == "sr-SP-Latn" || lang == "sr-Latn-CS")	// Latinica
            {
                this.lblSubscribe.Text = "<b>Dragi parohijani, molimo vas da nam pošaljete svoju e-mail adresu, da možemo da vam šaljemo obavještenja:</b>";
                this.cmdSubscribe.Text = "Pošalji";
                this.RegularExpressionValidator1.ErrorMessage = "Nepravilna e-mail adresa";
                this.RequiredFieldValidator1.ErrorMessage = "Zaboravili ste e-mail";
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
            }
            else	// Engleski
            {
                this.lblSubscribe.Text = "<b>Dear parishoners, please provide us with your e-mail address, so we can send you regular updates:</b>";
                this.cmdSubscribe.Text = "Send";
                this.RegularExpressionValidator1.ErrorMessage = "Invalid e-mail address";
                this.RequiredFieldValidator1.ErrorMessage = "Please enter your e-mail";
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            }

			// Put user code to initialize the page here
            //
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("sr-Cyrl-CS");
            //Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("sr-Cyrl-CS");

//            this.cmdIntroduction.Text = HttpContext.GetGlobalResourceObject("Strings", "3_introduction");
//            this.cmdHome.Text = "<img src=\"/SvLuka/imgs/NavBarThreeDots.gif\" border=0> " + HttpContext.GetGlobalResourceObject("Strings", "4_home");
//            this.cmdContact.Text = "<img src=\"/SvLuka/imgs/NavBarThreeDots.gif\" border=0> " + HttpContext.GetGlobalResourceObject("Strings", "29_contactus");
//            this.cmdPhotos.Text = "<img src=\"/SvLuka/imgs/NavBarThreeDots.gif\" border=0> " + HttpContext.GetGlobalResourceObject("Strings", "30_photos");
//            this.cmdDirections.Text = "<img src=\"/SvLuka/imgs/NavBarThreeDots.gif\" border=0> " + HttpContext.GetGlobalResourceObject("Strings", "12_directions");
//            this.cmdDonations.Text = "<img src=\"/SvLuka/imgs/NavBarThreeDots.gif\" border=0> " + HttpContext.GetGlobalResourceObject("Strings", "27_donations");

//            this.cmdUptodate.Text = HttpContext.GetGlobalResourceObject("Strings", "76_uptodate");
////			this.cmdWhatsNew.Text = "<img src=\"/SvLuka/imgs/NavBarThreeDots.gif\" border=0> " + HttpContext.GetGlobalResourceObject("Strings", "5_whatsnew");
//            this.cmdSchedules.Text = "<img src=\"/SvLuka/imgs/NavBarThreeDots.gif\" border=0> " + HttpContext.GetGlobalResourceObject("Strings", "6_schedules");
//            this.cmdConstruction.Text = "<img src=\"/SvLuka/imgs/NavBarThreeDots.gif\" border=0> " + HttpContext.GetGlobalResourceObject("Strings", "67_construction_diary");

//            this.cmdTeen.Text = HttpContext.GetGlobalResourceObject("Strings", "32_teenpage");
//            this.cmdTeenHome.Text = "<img src=\"/SvLuka/imgs/NavBarThreeDots.gif\" border=0> " + HttpContext.GetGlobalResourceObject("Strings", "33_teenhome");
//            this.cmdTeenGroup.Text = "<img src=\"/SvLuka/imgs/NavBarThreeDots.gif\" border=0> " + HttpContext.GetGlobalResourceObject("Strings", "34_teenyouthgroup");

//            this.cmdFolklore.Text = HttpContext.GetGlobalResourceObject("Strings", "92_folklore");
//            this.cmdFolkloreHome.Text = "<img src=\"/SvLuka/imgs/NavBarThreeDots.gif\" border=0> " + HttpContext.GetGlobalResourceObject("Strings", "93_folklorehome");
//            this.cmdFolkloreCalendar.Text = "<img src=\"/SvLuka/imgs/NavBarThreeDots.gif\" border=0> " + HttpContext.GetGlobalResourceObject("Strings", "97_folklore_calendar");

//            this.cmdOther.Text = HttpContext.GetGlobalResourceObject("Strings", "28_other");
//            this.cmdNewsletter.Text = "<img src=\"/SvLuka/imgs/NavBarThreeDots.gif\" border=0> " + HttpContext.GetGlobalResourceObject("Strings", "31_newsletter");
//            this.cmdForms.Text = "<img src=\"/SvLuka/imgs/NavBarThreeDots.gif\" border=0> " + HttpContext.GetGlobalResourceObject("Strings", "68_forms");
//            this.cmdYellowPages.Text = "<img src=\"/SvLuka/imgs/NavBarThreeDots.gif\" border=0> " + HttpContext.GetGlobalResourceObject("Strings", "69_yellow_pages");
//            this.cmdLinks.Text = "<img src=\"/SvLuka/imgs/NavBarThreeDots.gif\" border=0> " + HttpContext.GetGlobalResourceObject("Strings", "79_links");

//            ConnString conn = new ConnString();
			
//            if ( conn.isLogged( Session["boolLogged"] ) == false )
//            {
//                this.cmdAdmin.Text = HttpContext.GetGlobalResourceObject("Strings", "56_admin_log_in");
//            }
//            else
//            {
//                this.cmdAdmin.Text = HttpContext.GetGlobalResourceObject("Strings", "57_admin_log_out");
//            }
			
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
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{

		}
		#endregion

		protected void cmdIntroduction_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/home.aspx");
		}

		protected void cmdHome_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/Donations/NewLoan2018.aspx");
		}

//		private void cmdWhatsNew_Click(object sender, System.EventArgs e)
//		{
//			this.Redirect("/SvLuka/WhatsNew/default.aspx");
//		}

		protected void cmdDirections_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/Directions/default.aspx");
		}

		protected void cmdSchedules_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/Schedules/default.aspx");
		}

		protected void cmdDonations_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/Donations/default.aspx");
		}

		protected void cmdOther_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/newsletter/default.aspx");
		}

		protected void cmdUptodate_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/WhatsNew/default.aspx");
		}

		protected void cmdContact_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/AboutUs/default.aspx");
		}

		protected void cmdTeen_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/Teens/default.aspx");
		}

		protected void cmdTeenHome_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/Teens/default.aspx");
		}

		protected void cmdTeenGroup_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/Teens/YouthGroup.aspx");
		}

		protected void cmdPhotos_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/Photos/default.aspx");
		}

		protected void cmdNewsletter_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/Newsletter/default.aspx");
		}

		protected void cmdAdmin_Click(object sender, System.EventArgs e)
		{
            //ConnString conn = new ConnString();
			
            //if ( conn.isLogged( Session["boolLogged"] ) == true )
            //{
            //    Session["boolLogged"] = false;
				
            //    this.cmdAdmin.Text = HttpContext.GetGlobalResourceObject("Strings", "56_admin_log_in").ToString();
            //}
            //else
            //{
            //    Session["lastPage"] = Request["HTTP_REFERER"];
            //    this.Redirect("https://secures7.brinkster.com/dbujak/Login/Default.aspx?Project={0E452B4C-958B-4C84-919C-EEABB30EBC68}");
            //}
		}

		private void cmdSearch_Click(object sender, System.EventArgs e)
		{
            //this.Redirect("/SvLuka/Search/default.asp?search=" + this.txtSearch.Text);
		}

		protected void cmdConstruction_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/Construction/");
		}

		private void Redirect(string link)
		{
		Response.Write("<script language=javascript>"
			+ "window.location.replace(\"" + link + "\")"
			+ "</script>");
		}

		protected void cmdForms_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/Forms/");
		}


		protected void cmdLinks_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/Links/");
		}

		protected void cmdFolklore_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/Folklor/");
		}

		protected void cmdFolkloreHome_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/Folklor/");
		}

		protected void cmdFolkloreCalendar_Click(object sender, System.EventArgs e)
		{
			this.Redirect("/SvLuka/Folklor/Calendar.aspx");
		}

        protected void cmdSubscribe_Click(object sender, EventArgs e)
        {

            if (Page.IsValid == false) 
            {
                return;
            }

            System.Net.Mail.MailMessage NetMail = new System.Net.Mail.MailMessage();
            System.Net.Mail.SmtpClient MailClient = new System.Net.Mail.SmtpClient();
            

            try
            {
                NetMail.From = new System.Net.Mail.MailAddress("brinkstermakesmehaveaccount@properit.com");
                NetMail.To.Add(new System.Net.Mail.MailAddress("info@svluka.org"));
                NetMail.IsBodyHtml = true;
                NetMail.Subject = "New e-mail subscription on svluka.org";
                NetMail.Body = this.txtSubscribe.Text;

                MailClient.Host = "mymail.brinkster.com";
                MailClient.Port = 2525;
                MailClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                MailClient.UseDefaultCredentials = false;
                MailClient.Credentials = new System.Net.NetworkCredential("brinkstermakesmehaveaccount@properit.com", "pepelari1");

                MailClient.Send(NetMail);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                NetMail.Dispose();
                NetMail = null;
                MailClient = null;
                this.txtSubscribe.Text = "";

                string lang = "";

                if (Request.Cookies["language"] != null) { lang = Request.Cookies["language"].Value; }
                if (lang == "sr-SP-Cyrl" || lang == "sr-Cyrl-CS")	// Cirilica
                {
                    Response.Write("<h3><font color=red>Хвала, добили смо ваш е-маил.</font></h3>");
                    this.lblSubscribe.Text = "Хвала, добили смо ваш е-маил.";
                }
                else if (lang == "sr-SP-Latn" || lang == "sr-Latn-CS")	// Latinica
                {
                    Response.Write("<h3><font color=red>Hvala, dobilo smo vaš e-mail.</font></h3>");
                    this.lblSubscribe.Text = "Hvala, dobilo smo vaš e-mail.";
                }
                else	// Engleski
                {
                    Response.Write("<h3><font color=red>Thank you, we recorded your email.</font></h3>");
                    this.lblSubscribe.Text = "Thank you, we recorded your email.";
                }

            }
        }
	}
}
