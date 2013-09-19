using System;
using System.Collections;
using System.ComponentModel;
using System.Web;
using System.Web.SessionState;
using System.Threading;
using System.Globalization;
using System.Resources;
using System.Reflection;

namespace SvLuka 
{
	/// <summary>
	/// Summary description for Global.
	/// </summary>
	public class Global : System.Web.HttpApplication
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public Global()
		{
			InitializeComponent();
		}	
		
		protected void Application_Start(Object sender, EventArgs e)
		{
            //string source_Language = "Strings";

            //ResourceManager rm = new ResourceManager(source_Language, System.Reflection.Assembly.Load("App_GlobalResources"));

            //ResourceManager rm = ResourceManager.CreateFileBasedResourceManager("resource", strResourcesPath, null); 


            //ResourceManager rm = new ResourceManager("SvLuka.Strings", Assembly.GetExecutingAssembly()); 


            //this.Application.Add("RM", rm);

		}
 
		protected void Session_Start(Object sender, EventArgs e)
		{

		}

		protected void Application_BeginRequest(Object sender, EventArgs e)
		{
			if ( Request.Cookies["language"] != null )
			{
				try
				{
					Thread.CurrentThread.CurrentUICulture = new CultureInfo( Request.Cookies["language"].Value.ToString() );
				}
				catch ( Exception ex )
				{
					Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(Request.UserLanguages[0]);
				}
				
			}

		}

		protected void Application_EndRequest(Object sender, EventArgs e)
		{

		}

		protected void Application_AuthenticateRequest(Object sender, EventArgs e)
		{

		}

		protected void Application_Error(Object sender, EventArgs e)
		{

		}

		protected void Session_End(Object sender, EventArgs e)
		{

		}

		protected void Application_End(Object sender, EventArgs e)
		{

		}
			
		#region Web Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.components = new System.ComponentModel.Container();
		}
		#endregion
	}
}

