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

namespace SvLuka.MailingList
{
	/// <summary>
	/// Summary description for _default.
	/// </summary>
	public partial class _default : System.Web.UI.Page
	{
		protected SvLuka.controls.Header Header1;

		protected void Page_Load(object sender, System.EventArgs e)
		{
			

			if (this.IsPostBack == false)
			{
                this.Header1.lblPageTitle.Text = HttpContext.GetGlobalResourceObject("Strings", "82_mailinglist_title").ToString();
                this.lblMailingList.Text = HttpContext.GetGlobalResourceObject("Strings", "83_mailinglist_page").ToString();
                this.lblEmail.Text = HttpContext.GetGlobalResourceObject("Strings", "84_mailinglist_email").ToString();
                this.valEmail.ErrorMessage = HttpContext.GetGlobalResourceObject("Strings", "85_mailinglist_email_error").ToString();
                this.valEmailReq.ErrorMessage = HttpContext.GetGlobalResourceObject("Strings", "85_mailinglist_email_error").ToString();
                this.lblFName.Text = HttpContext.GetGlobalResourceObject("Strings", "86_mailinglist_Fname").ToString();
                this.lblLName.Text = HttpContext.GetGlobalResourceObject("Strings", "87_mailinglist_Lname").ToString();
                this.lblAddress.Text = HttpContext.GetGlobalResourceObject("Strings", "88_mailinglist_Address").ToString();
                this.lblCityEtc.Text = HttpContext.GetGlobalResourceObject("Strings", "89_mailinglist_CityEtc").ToString();
                this.cmdSubscribe.Text = HttpContext.GetGlobalResourceObject("Strings", "90_mailinglist_Submit").ToString();
			}
			else
			{}

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
