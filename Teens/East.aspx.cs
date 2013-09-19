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

namespace SvLuka.Teens
{
	/// <summary>
	/// Summary description for East.
	/// </summary>
	public partial class East : System.Web.UI.Page
	{
		protected SvLuka.controls.Header Header1;

		protected void Page_Load(object sender, System.EventArgs e)
		{
			

			this.Header1.lblPageTitle.Text = HttpContext.GetGlobalResourceObject("Strings", "39_eastpage_title").ToString();
            this.lblEast.Text = HttpContext.GetGlobalResourceObject("Strings", "40_eastpage_text").ToString();
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
