namespace SvLuka.controls
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using System.Threading;
	using System.Globalization;
	using System.Resources;

	/// <summary>
	///		Summary description for Footer.
	/// </summary>
	public partial class Footer : System.Web.UI.UserControl
	{

		protected void Page_Load(object sender, System.EventArgs e)
		{
			if ( Request.Cookies["language"] != null )
			{
				if ( Request.Cookies["language"].Value.ToString() == "sr-SP-Cyrl" || Request.Cookies["language"].Value.ToString() == "sr-Cyrl-CS" )
				{
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("sr-Cyrl-CS");

					this.cmdCirilica.Enabled = false;
					this.cmdCirilicaImg.Visible=false;
				}
				else if ( Request.Cookies["language"].Value.ToString() == "sr-SP-Latn" || Request.Cookies["language"].Value.ToString() == "sr-Latn-CS" )
				{
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("sr-Latn-CS");

					this.cmdLatinica.Enabled=false;
					this.cmdLatinicaimg.Visible=false;
				}
				else
				{
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");		

					this.cmdEnglish.Enabled=false;
					this.cmdEnglishimg.Visible=false;
				}

			}
			
			// Check the day and time of the day and display chat option
			bool boolWork = false;

			// Check the day
			System.DayOfWeek day = DateTime.Today.DayOfWeek;
			
			if ( day == DayOfWeek.Monday || day == DayOfWeek.Tuesday || day == DayOfWeek.Wednesday || 
				day == DayOfWeek.Thursday || day == DayOfWeek.Friday )
			{
				if ( DateTime.Now.Hour < 9 || DateTime.Now.Hour >= 17 ) boolWork = false;
				else boolWork = true;
			}
			else boolWork = false;

			this.lblChat.Visible = false;

			// Hide chat all the time
			boolWork = false;

			if ( boolWork == true )  
			{
				this.lblChat.Visible = true;
				
                this.lblChat.Text = HttpContext.GetGlobalResourceObject("Strings", "22_footer_chat").ToString();
			}

			// Add copyright text
			this.lblCopyright.Text = "Copyright © " + DateTime.Now.Year + " by St. Luke Serbian Orthodox Church. All rights reserved.";
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
			this.cmdCirilicaImg.Click += new System.Web.UI.ImageClickEventHandler(this.cmdCirilicaImg_Click);
			this.cmdEnglishimg.Click += new System.Web.UI.ImageClickEventHandler(this.cmdEnglishimg_Click);
			this.cmdLatinicaimg.Click += new System.Web.UI.ImageClickEventHandler(this.cmdLatinicaimg_Click);

		}
		#endregion

		protected void cmdCirilica_Click(object sender, System.EventArgs e)
		{
			Cirilica();
		}

		private void Cirilica()
		{
			try
			{
				Response.Cookies["language"].Value = "sr-Cyrl-CS";
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("sr-Cyrl-CS");
			}
			catch  	// Depending on updates one or the other works
			{
				Response.Cookies["language"].Value = "sr-SP-Cyrl";
				Thread.CurrentThread.CurrentUICulture = new CultureInfo( "sr-SP-Cyrl" );
			}
				
			Response.Cookies["language"].Expires = DateTime.Now.AddYears(1);
			Response.Redirect( Request.UrlReferrer.AbsolutePath );
		}

		protected void cmdLatinica_Click(object sender, System.EventArgs e)
		{
			Latinica();
		}

		private void Latinica()
		{
			try
			{
				Response.Cookies["language"].Value = "sr-Latn-CS";
				Thread.CurrentThread.CurrentUICulture = new CultureInfo( "sr-Latn-CS" );
			}
			catch  	// Depending on updates one or the other works
			{
				Response.Cookies["language"].Value = "sr-SP-Latn";
				Thread.CurrentThread.CurrentUICulture = new CultureInfo( "sr-SP-Latn" );
			}
			Response.Cookies["language"].Expires = DateTime.Now.AddYears(1);
			Response.Redirect( Request.UrlReferrer.AbsolutePath );
		}

		private void cmdLatinicaimg_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Latinica();
		}

		protected void cmdEnglish_Click(object sender, System.EventArgs e)
		{
			English();
		}

		private void English()
		{
			Response.Cookies["language"].Value = "en-US";
			Response.Cookies["language"].Expires = DateTime.Now.AddYears(1);
			Thread.CurrentThread.CurrentUICulture = new CultureInfo( "en-US" );		
			Response.Redirect( Request.UrlReferrer.AbsolutePath );
		}

		private void cmdEnglishimg_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			English();
		}

		private void cmdCirilicaImg_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Cirilica();
		}


	}
}
